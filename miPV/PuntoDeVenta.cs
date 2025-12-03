using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Windows.Forms;

namespace miPV
{
    public partial class PuntoDeVenta : Form
    {
        Caja caja;
        Venta venta;
        GestionDGV dgv;
        Cliente cliente;
        Producto producto;
        TicketPrint ticketPrint;
        DetalleVenta detalleVenta;
        DataTable tableIdProductos; 
        FormActividad formAct = new FormActividad();
        List<Producto> producto_invetanrio = new List<Producto>();
        
        decimal descuento = 0.0M;

        public int entra = 0;

        public Thread wRserial;
        public SerialPort sp = new SerialPort();

        public static System.Windows.Forms.Timer tEnvioCaracter;
        public static System.Windows.Forms.Timer tActualizarPeso;

        public bool Work = false;
        private bool permiso = false; 
        
        private string sDataSerial = "";
        private string sDataSerialBefore = "";

        #region constructor
        public PuntoDeVenta(bool permiso)//, string rol)
        {
            InitializeComponent();
            lClienteVenta.Text = "";
            inicializarVariables();
            dgv.cargarColumnas();
            dgv.inicializarDgv();
            crearColumna();
            producto.loadComboBox(cbProductos, false, ref entra);
            cliente.loadComboBox(cbClientes);

            this.permiso = permiso;

            inicializarInterface(permiso);

            this.Text = "Punto de venta - Actualizacion 11.4.4";
            //this.usuario = usuario;
            //this.rol = rol;
        }
        #endregion

        #region botones

        #region producto -> abre el formulario producto
        private void cmdProductos_Click(object sender, EventArgs e)
        {
            FrmProducto productoFrm = new FrmProducto(ref producto,ref cbProductos);
            productoFrm.Show();
        }
        #endregion

        #region bonton Pagar -> guardar venta y detalle de venta
        private void cmdPagar_Click(object sender, EventArgs e)
        {
            decimal total = Convert.ToDecimal(lTotal.Text);
            decimal pago = 0.0M;
            string simbolo_descuento;

            if (txtPago.Text.Trim() != "")
            {
                pago = Convert.ToDecimal(txtPago.Text);
            }

            if (lTotal.Text != "0.0")
            {
                if(validar_cambio(total, pago))
                {
                    int id_cliente = cliente.idCliente(cbClientes.Text);
                    //string nombre_cliente = cliente.list().Find(x => x.id_cliente == id_cliente).nombre;
                    venta.fecha = DateTime.Now.ToString(venta.DATE_CAST);
                    venta.fk_id_cliente = id_cliente;
                    venta.descuento = $"{descuento:N0}";
                    //venta.abono = "";

                    if (chbCredito.Checked)
                    {
                        venta.credito = "1";
                        simbolo_descuento = "%";
                    }
                    else
                    {
                        venta.credito = "0";
                        simbolo_descuento = "$";
                    }

                     //venta.insert();
                    if (venta.insert())
                    {
                        venta.RefreshList();

                        detalleVenta.fk_id_venta = venta.list(true).Last().id_venta;// [0].id_venta;

                        if (!detalleVenta.insertar())
                        {
                            //if (!Mensaje.result_bool)
                            //{
                            venta.eliminarVenta();
                            detalleVenta.eliminarDetalleVenta(detalleVenta.queryEliminarDetalleVenta());
                        }
                        else
                        {
                            cambiarCantidadProducto();
                            cargarTabla();
                            ticketPrint = new TicketPrint();
                            ticketPrint.imprimirTicket(tableIdProductos, lTotal.Text, detalleVenta.fk_id_venta.ToString(), "nombre_cliente", $"{simbolo_descuento}{descuento.ToString()}");
                            limpiarRegistro();
                            crearNotificacion("Venta registrada EXITOSAMENTE!!", Color.Green);
                        }
                    }
                    else
                    {
                        crearNotificacion("La venta no se registro intente nuevamente", Color.Red);
                    }
                }
            }
            else
            {
                crearNotificacion("La tabla esta vacia, ingrese articulos para registrar la venta", Color.Red);
            }
        }
        #endregion

        #region buscar -> crea el efecto de presionado del boton buscar
        private void cmdBuscarProducto_Click(object sender, EventArgs e)
        {
            activarDesactivarBotonCliente(true);
            activarBotonBuscarProducto(false);
        }

        public void activarBotonBuscarProducto(bool boton_cliente)
        {
            if (boton_cliente)
            {
                if (cmdBuscarProducto.BackColor == Color.Lime)
                { 
                    cmdBuscarProducto.BackColor = Color.Transparent;
                    limpiarNotificaciones();
                    cbProductos.Visible = false;
                }
            }
            else
            {
                if (cmdBuscarProducto.BackColor == Color.Transparent)
                {
                    cmdBuscarProducto.BackColor = Color.Lime;
                    crearNotificacion("Boton de busqueda producto ACTIVADO", Color.Green);
                    cbProductos.Visible = true;
                }
                else
                {
                    cmdBuscarProducto.BackColor = Color.Transparent;
                    limpiarNotificaciones();
                    cbProductos.Visible = false;
                }
            }
        }
        #endregion

        #region corte de caja
        //private void cmdCorteCaja_Click(object sender, EventArgs e)
        //{
        //    if (cmdCorteCaja.BackColor == Color.Transparent)
        //    {
        //        lMontoCorte.Text = "$ ";
        //        cmdCorteCaja.BackColor = Color.Lime;
        //        crearNotificacion("Boton de corte de caja ACTIVADO", Color.Green);

        //        dtpFecha.Visible = true;
        //        lMontoCorte.Visible = true;

        //        string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");

        //        lMontoCorte.Text += caja.corte(fecha);
        //    }
        //    else
        //    {
        //        cmdCorteCaja.BackColor = Color.Transparent;
        //        limpiarNotificaciones();

        //        dtpFecha.Visible = false;
        //        lMontoCorte.Visible = false;
        //        dtpFecha.Value = DateTime.Now;
        //    }
        //}
        #endregion

        #endregion

        #region eventos texbox

        #region codigo KeyPress -> busca codigo en la bd y carga el producto
        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region validar enter
            if (txtCodigo.Text != "")
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    //limpia txtPago 
                    limpiarTxtPago();

                    //se crea la variable local codigo
                    string codigo = txtCodigo.Text;

                    #region validar que el producto exista
                    //se valida la existencia del prodcto
                    //producto.query(codigo, $"{producto.WHERE} {producto.codigo_a} {producto.igual} ?");
                    Producto producto_cargar = producto.list().Find(x => x.codigo == codigo);

                    if (producto_cargar != null)//Mensaje.result_bool)//producto.cargarProducto(codigo))
                    {
                        //se inserta el producto en la tabla dgvProducto
                        dgv.cargarDgvProductos(producto_cargar, false);//producto.list<Producto>().Find(x => x.codigo == codigo));

                        //se almacena en una tabla los datos del dataGridView
                        cargarTabla();

                        //se hace la suma del dgvProducto y se carga a la etiqueta lTotal
                        sumarTotal();

                        //inicializa la etiqueta lNotificaciones 
                        limpiarNotificaciones();

                        //se inicializa la caja de texto codigo
                        txtCodigo.Text = "";
                    }
                    else
                    {
                        //se manda la notificacion "producto no encontrado" en lNotificaciones
                        crearNotificacion("Producto no encotrado", Color.Red);
                        txtCodigo.Text = "";
                    }
                }
                #endregion
            }
            #endregion
        }
        #endregion

        #region codigo TextChanged -> realiza la busqueda de un producto en la misma tabla
        #endregion
        
        #region pago KeyPress-> valida que sean numeros y calcula el cambio
        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region valida que sean solo numeros
            //valida que el texto sean solo numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                crearNotificacion("Digite solo numeros", Color.Red);
                e.Handled = true;
            }
            else
            {
                limpiarNotificaciones();
            }
            #endregion

            #region calcular cambio del pago al dar enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                limpiarNotificaciones();
                decimal pago = 0;
                decimal total = Convert.ToDecimal(lTotal.Text);
                decimal.TryParse(txtPago.Text, out pago);
                decimal cambio = 0;

                if(pago < total)
                {
                    crearNotificacion("El pago no puede ser menor al total", Color.Red);
                    txtPago.Text = "";
                }
                else
                {
                    cambio = pago - total;
                    crearNotificacion("Su cambio $"+ $"{cambio:N2}", Color.Blue);
                    //lCambio.Text = string.Format("{0:N2}", cambio);
                    e.Handled = false;
                }
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            #endregion
        }
        #endregion
        #endregion

        #region eventos dataGridView

        #region romover una fila -> calcula la suma del dgvProducto
        private void dgvProductos_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (entra == 0)
            {
                limpiarTxtPago();
                sumarTotal();
                cargarTabla();
            }
        }
        #endregion

        #region modificar fila -> calcula la suma del dgvProducto
        private void dgvProductos_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductos.Rows.Count > 0)
            {
                try
                {
                    limpiarTxtPago();
                    dgv.sumarFilas(e);
                    sumarTotal();
                    cargarTabla();
                }
                catch (Exception)
                {
                    crearNotificacion("Digite solo numeros", Color.Red);
                    dgvProductos.CurrentRow.Cells["cCantidad"].Value = "1";
                }
            }
        }
        #endregion

        #endregion

        #region metodos del formulario

        #region inicializarVariables() -> instancia todos los objetos usados en el formulario
        public void inicializarVariables()
        {
            caja = new Caja();
            venta = new Venta();
            cliente = new Cliente();
            producto = new Producto();
            dgv = new GestionDGV(dgvProductos);
            tableIdProductos = new DataTable();
            detalleVenta = new DetalleVenta(tableIdProductos);
            //ticketPrint = new TicketPrint();
        }
        #endregion


        #region limpiarNotificacion() -> limpia el label lNotificaciones
        public void limpiarNotificaciones()
        {
            crearNotificacion("Notificaciones:", Color.Red);
        }
        #endregion

        #region limpiarTxtpago() -> limpiar textBox pago 
        public void limpiarTxtPago()
        {
            if (txtPago.Text != "")
            { 
                txtPago.Text = "";
                //lCambio.Text = "0.0";
            }
        }
        #endregion

        #region limpiarRegistro() -> limpia todos los registros despues de la venta;
        public void limpiarRegistro()
        {
            entra = 1;
            dgvProductos.Rows.Clear();
            limpiarTxtPago();
            //lTotal.Text = "0.0";
            //lCambio.Text = "0.0";
            cbClientes.Text = "";
            cbProductos.Text = "";
            lClienteVenta.Text = "";
            txtDescuento.Text = "";
            chbCredito.Checked = false;

            tsBtnActualizarVenta.Visible = false;
            tsBtnCancelarVenta.Visible = false;
            tsBtnReimprimirTicket.Visible = false;

            //activarBotonBuscarProducto(false);

            cmdPagar.Enabled = true;
            entra = 0;
        }
        #endregion

        #region crearNotificacion() -> crea los mesajes de notificacion
        public void crearNotificacion(string mensaje, Color color)
        {
            lNotificaciones.ForeColor = color;
            lNotificaciones.Text = mensaje;
        }
        #endregion

        #region crearColumna() -> crea las columnas para el dataTable tableIdProducto
        public void crearColumna()
        {
            tableIdProductos.Columns.Add("Codigo");
            tableIdProductos.Columns.Add("Cantidad");
            tableIdProductos.Columns.Add("Descripcion");
            tableIdProductos.Columns.Add("Precio U.");
            tableIdProductos.Columns.Add("Total");
        }
        #endregion

        #region cargarTabla() -> carga los datos del dgvProducto al tableIdProducto
        public void cargarTabla()
        {
            tableIdProductos.Rows.Clear();

            DataRow filaNueva;

            foreach (DataGridViewRow filaDatos in dgvProductos.Rows)
            {
                filaNueva = tableIdProductos.NewRow();

                filaNueva["Codigo"] = filaDatos.Cells[0].Value;
                filaNueva["Cantidad"] = $"{filaDatos.Cells[1].Value:N2}";
                filaNueva["Descripcion"] = filaDatos.Cells[2].Value;
                filaNueva["Precio U."] = filaDatos.Cells[3].Value;
                filaNueva["Total"] = filaDatos.Cells[4].Value;
          
                tableIdProductos.Rows.Add(filaNueva);
            }
        }
        #endregion

        #region sumarTotal() -> sumar el total del dgvProducto
        public void sumarTotal()
        {
            lTotal.Text = dgv.sumarTotalPagado(dgvProductos);
        }
        #endregion

        #region botonActivado() -> Devuelve si el boton esta presionado
        public bool botonActivado(Button boton)
        {
            if (boton.BackColor == Color.Lime)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        public void inicializarInterface(bool mostrar)
        {
            if (!mostrar)
            {
                tsBtnProducto.Enabled = false;
                tsBtnCliente.Enabled = false;
                tsBtnProveedor.Enabled = false;
                tsBtnConsulta.Enabled = false;
                tsBtnBascula.Enabled = false;
            }
        }
           
        #endregion

        //private void dtpFecha_ValueChanged(object sender, EventArgs e)
        //{
        //    string fecha = dtpFecha.Value.ToString("dd/MM/yyyy");

        //    lMontoCorte.Text = "$ "+ caja.corte(fecha);
        //}

        private void btnActividades_Click(object sender, EventArgs e)
        {
            formAct.Show();
        }

        private Boolean validar_cambio(decimal total, decimal pago)
        {
            if (pago != 0.0M)
            {
                if (pago >= total)
                {
                    return true;
                }

                else
                {
                    crearNotificacion("El pago es menor al total requerido", Color.Red);
                    return false;
                }
            }
            return true;
        }

        private void Actividades_Click(object sender, EventArgs e)
        {

        }

        private void tsBtnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto productoFrm = new FrmProducto(ref producto, ref cbProductos);
            productoFrm.Show();
        }

        private void btnMostrarCbCliente_Click(object sender, EventArgs e)
        {
            activarBotonBuscarProducto(true);
            activarDesactivarBotonCliente(false);
        }
    
        public void activarDesactivarBotonCliente(bool botonProducto)
        {
            if (botonProducto)
            {
                if (btnMostrarCbCliente.BackColor == Color.Lime)
                {
                    btnMostrarCbCliente.BackColor = Color.Transparent;
                    limpiarNotificaciones();
                    cbClientes.Visible = false;
                }
            }
            else
            {
                if (btnMostrarCbCliente.BackColor == Color.Transparent)
                {
                    btnMostrarCbCliente.BackColor = Color.Lime;
                    crearNotificacion("Boton de busqueda cliente ACTIVADO", Color.Green);
                    cbClientes.Visible = true;
                }
                else
                {
                    btnMostrarCbCliente.BackColor = Color.Transparent;
                    limpiarNotificaciones();
                    cbClientes.Visible = false;
                }
            }
        }

        private void tsBtnCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void tsBtnProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedor proveedor = new FrmProveedor();
            proveedor.Show();
        }

        private void cbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entra != 1)
            {
                //limpia txtPago 
                limpiarTxtPago();

                //se crea la variable local codigo
                string codigo = cbProductos.Text;

                #region validar que el producto exista

                //se valida la existencia del prodcto
                //producto.query(codigo, $"{producto.WHERE} {producto.codigo_a} {producto.igual} ?");
                Producto producto_cargar = producto.list().Find(x => x.descripcion == cbProductos.Text);

                if (producto_cargar != null) //Mensaje.result_bool)//producto.cargarProducto(codigo))
                {
                    //se inserta el producto en la tabla dgvProducto
                    dgv.cargarDgvProductos(producto_cargar,
                        false); //producto.list<Producto>().Find(x => x.descripcion == cbProductos.Text));

                    //se almacena en una tabla los datos del dataGridView
                    cargarTabla();

                    //se hace la suma del dgvProducto y se carga a la etiqueta lTotal
                    sumarTotal();

                    //inicializa la etiqueta lNotificaciones 
                    limpiarNotificaciones();

                    //se inicializa la caja de texto codigo
                    cbProductos.Text = "";
                    activarBotonBuscarProducto(false);//***checar esta linea
                }
                else
                {
                    //se manda la notificacion "producto no encontrado" en lNotificaciones
                    crearNotificacion("Producto no encotrado", Color.Red);
                    txtCodigo.Text = "";
                }
            }

            #endregion
        }

        private void cbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entra == 0)
            {
                activarDesactivarBotonCliente(false);
                lClienteVenta.Text = $"CLIENTE: {cbClientes.Text}";
            }
        }

        private void lClienteVenta_Click(object sender, EventArgs e)
        {
            DialogResult result = Mensaje.responseMessage("Remover");//estaba index 2;
            
            if(result == DialogResult.OK)
            {
                lClienteVenta.Text = "";
                cbClientes.Text = "";
            }
        }

        private void tsBtnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
            limpiarNotificaciones();
            limpiarTxtPago();
            dgvProductos.Rows.Clear();
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            #region valida que sean solo numeros
            //valida que el texto sean solo numeros
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(Keys.Back))
            {
                crearNotificacion("Digite solo numeros", Color.Red);
                e.Handled = true;
            }
            else
            {
                limpiarNotificaciones();
            }
            #endregion

            #region calcular cambio del pago al dar enter
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                limpiarNotificaciones();
                //decimal pago = 0;
                descuento = 0.0M;

                if (txtDescuento.Text != "")
                {
                    descuento = Convert.ToDecimal(txtDescuento.Text);
                }

                decimal total = Convert.ToDecimal(lTotal.Text);
                //decimal.TryParse(txtPago.Text, out pago);
                //decimal cambio = 0;
                if (descuento > 0.0M)
                {
                    if (total > 0.0M)
                    {
                        if (chkDescuento.Checked)
                        {
                            total = total - ((descuento / 100) * total);
                            descuento = (descuento / 100) * total;
                        }
                        else
                        {
                            total -= descuento;
                        }

                        if (total <= 0)
                        {
                            crearNotificacion("El descuento no puede ser igual o mayor del 100%", Color.Red);
                            txtDescuento.Text = "";
                        }
                        else
                        {
                            lTotal.Text = $"{total:N2}";
                            //this.descuento = descuento;
                            txtDescuento.Text = "";
                        }
                    }
                    //else
                    //{
                    //    cambio = pago - total;
                    //    lCambio.Text = string.Format("{0:N2}", cambio);
                    //    e.Handled = false;
                    //}
                }
            }
            else if (e.KeyChar == Convert.ToChar(Keys.Back))
            {
                e.Handled = false;
            }
            #endregion
        }

        private void chkDescuento_CheckedChanged(object sender, EventArgs e)
        {
            lDescuento.Text = lDescuento.Text == "$Descuento" ? "%Descuento" : "$Descuento";
            //if (lDescuento.Text == "$Descuento")
            //{
            //    lDescuento.Text = "%Descuento";
            //}
            //else
            //{
            //    lDescuento.Text = "$Descuento";
            //}
        }

        public void cambiarCantidadProducto()
        {
            int index = 0;
            decimal cantidad_producto;
            Producto producto_actualizar = new Producto();
            List<string> cantidad_tabla = new List<string>();

            foreach (var codigo in dgv.listaColumna("cCodigo"))
            {
                producto_actualizar = producto.list().Find(x => x.codigo == codigo);

                cantidad_producto = Convert.ToDecimal(producto_actualizar.cantidad);

                //foreach (var cantidad_tabla in dgv.listaColumna("cCantidad"))
                //{
                cantidad_tabla = dgv.listaColumna("cCantidad");

                string query = $"{codigo}";

                cantidad_producto -= Convert.ToDecimal(cantidad_tabla[index]);

                producto_actualizar.cantidad = $"{cantidad_producto:N2}";

                producto_actualizar.update(query);

                producto.RefreshList();
                //}
                index++;
            }
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            limpiarRegistro();
            string id_venta = txtCodigo.Text;
            //string query = $"{detalleVenta.WHERE} {detalleVenta.fk_id_venta_a} {detalleVenta.igual} ?";

            if (txtCodigo.Text != "")
            {
                detalleVenta.query(id_venta, id_venta);

                if (detalleVenta.list().Count > 0)
                {
                    foreach (var detalle_venta in detalleVenta.list())
                    {
                        cargarVentaDgv(detalle_venta);
                    }

                    tsBtnActualizarVenta.Visible = true;
                    tsBtnCancelarVenta.Visible = true;
                    tsBtnReimprimirTicket.Visible = true;
                    cmdPagar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("No se encontro el folio de venta solicitado");
                }
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Escriba el folio de venta");
            }
        }

        private void cargarVentaDgv(DetalleVenta dv)
        {
            Producto producto_cargar = producto.list().Find(x => x.codigo == dv.fk_codigo_producto.ToString());

            producto_cargar.cantidad = dv.cantidad;
            //if (producto_cargar != null)//Mensaje.result_bool)//producto.cargarProducto(codigo))
            //{
            //se inserta el producto en la tabla dgvProducto
            dgv.cargarDgvProductos(producto_cargar, true);//producto.list<Producto>().Find(x => x.codigo == codigo));

            //se almacena en una tabla los datos del dataGridView
            cargarTabla();

            //se hace la suma del dgvProducto y se carga a la etiqueta lTotal
            sumarTotal();

            //inicializa la etiqueta lNotificaciones 
            limpiarNotificaciones();

            //se inicializa la caja de texto codigo
            txtCodigo.Text = "";
            //}
            //else
            //{
            //se manda la notificacion "producto no encontrado" en lNotificaciones
            //crearNotificacion("Producto no encotrado", Color.Red);
            //txtCodigo.Text = "";
            //}
        }

        private void tsBtnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiarRegistro();
        }

        private void tsBtnActualizarVenta_Click(object sender, EventArgs e)
        {
            //int index = 0;
            decimal diferencia = 0.0M;

            foreach (DetalleVenta dv in detalleVenta.list())
            {
                bool entra = true;

                foreach (DataGridViewRow row in dgvProductos.Rows)
                {
                    string codigo_producto_dgv = row.Cells[0].Value.ToString();
                  
                    if (dv.fk_codigo_producto == codigo_producto_dgv)
                    {
                        entra = false;

                        if (dv.cantidad != row.Cells[1].Value.ToString())
                        {
                            Producto producto_actualizar = producto.list().Find(x => x.codigo == dv.fk_codigo_producto.ToString());

                            //if (Convert.ToDecimal(dv.cantidad) > Convert.ToDecimal(row.Cells[1].Value))
                            //{
                                diferencia = Convert.ToDecimal(dv.cantidad) - Convert.ToDecimal(row.Cells[1].Value);

                                diferencia += Convert.ToDecimal(producto_actualizar.cantidad);
                            //}
                            //else
                            //{
                                //diferencia = Convert.ToDecimal(row.Cells[1].Value) - Convert.ToDecimal(dv.cantidad);

                                //diferencia += Convert.ToDecimal(producto_actualizar.cantidad);
                            //}

                            dv.cantidad = row.Cells[1].Value.ToString();

                            dv.update($"{detalleVenta.WHERE} {dv.fk_id_venta_a} " +
                                                $"{dv.igual} {dv.fk_id_venta} " +
                                                $"{dv.AND} " +
                                                $"{dv.fk_codigo_producto_a} " +
                                                $"{dv.igual} {dv.fk_codigo_producto}");


                            string query = $"{producto_actualizar.codigo}";

                            producto_actualizar.cantidad = $"{diferencia:N2}";

                            producto_actualizar.update(query);
                            crearNotificacion("La actulización fue realizada intente nuevamente", Color.Red);
                        }
                    }
                }
                //si no existe una coincidencia entre el detalle venta y el dgv
                //elimina el articulo
                if (entra)
                {
                    string fk_id_venta = dv.fk_id_venta.ToString();
                    string fk_codigo_producto = dv.fk_codigo_producto.ToString();
                    string query = $"DELETE FROM detalle_venta WHERE fk_id_venta = {fk_id_venta} AND fk_codigo_producto = {fk_codigo_producto}";

                    detalleVenta.eliminarProductoDetalleVenta(query);    
                }
            }

            if (Mensaje.result_bool)
            {
                crearNotificacion("Detalle de venta actulizado", Color.Lime);
                MessageBox.Show("Correcto");
                limpiarRegistro();
            }
            else
            {
                Mensaje.responseMessage("Fallo actualización");
            }
        }

        private void tsBtnBascula_Click(object sender, EventArgs e)
        {
            if (tsBtnBascula.BackColor == SystemColors.ControlLightLight)
            {
                tsBtnBascula.BackColor = Color.Lime;

                String name_puerto = "";

                foreach (string puerto in SerialPort.GetPortNames())
                {
                    if (puerto == "COM3")
                    {
                        name_puerto = puerto;
                    }
                }

                try
                {
                    sp.PortName = name_puerto;
                    sp.BaudRate = 115200;
                    sp.Handshake = Handshake.None;
                    sp.DataBits = 8;
                    sp.Parity = Parity.None;
                    sp.StopBits = StopBits.One;

                    AbrirPuertoSerie();

                    tEnvioCaracter = new System.Windows.Forms.Timer();
                    PuntoDeVenta.tEnvioCaracter.Interval = 200;
                    PuntoDeVenta.tEnvioCaracter.Start();
                    tEnvioCaracter.Tick += new EventHandler(this.tEnvioCaracter_Tick);

                    //this.wRserial = new Thread(new ThreadStart(this.serialPortDataReceived));

                    tActualizarPeso = new System.Windows.Forms.Timer();
                    PuntoDeVenta.tActualizarPeso.Interval = 400;
                    PuntoDeVenta.tActualizarPeso.Start();
                    tActualizarPeso.Tick += new EventHandler(this.tActualizarPeso_Tick);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Verifique que la bascula este conectada");
                }
            }
            else
            {
                tsBtnBascula.BackColor = SystemColors.ControlLightLight;

                if (sp.IsOpen)
                {
                    PuntoDeVenta.tEnvioCaracter.Stop();
                    PuntoDeVenta.tActualizarPeso.Stop();
                    this.sp.Close();

                    //while (this.Work)
                    //{
                        Thread.Sleep(10);
                    //}
                }
            }
        }

        private void tActualizarPeso_Tick(object sender, EventArgs e)
        {
            this.sDataSerialBefore = "";
            this.sDataSerialBefore = this.sDataSerial;
            this.sDataSerial = "";
            tEnvioCaracter.Stop();
            tEnvioCaracter.Start();
            tActualizarPeso.Stop();
            tActualizarPeso.Start();

            //this.lbltest.Text = sDataSerialBefore;
            //DataGridViewCell celda_actual = dgv.CurrentCell;
            DataGridViewRow row = dgvProductos.CurrentRow;

            try
            {
                decimal total = Convert.ToDecimal(sDataSerialBefore) * Convert.ToDecimal(row.Cells["cPrecioUnitario"].Value);

                row.Cells["cCantidad"].Value = sDataSerialBefore;

                row.Cells["cTotal"].Value = $"{total:N2}";
            }
            catch (Exception) { }
        }

        private void tEnvioCaracter_Tick(object sender, EventArgs e)
        {
            //this.puertoSerie.Write(new byte[] { 13, 10 }, 0, 2); 
            //for (int i = 0; i < 1; i++)
            //{
            try
            {
                this.sp.Write("P");
            }

            catch (Exception) { }
            //}
        }

        private void serialPortDataReceived()
        {
            byte value = 0;
            sDataSerial = "";
            this.Work = true;

            while (this.Work)
            {
                try
                {
                    value = Convert.ToByte(this.sp.ReadByte());
                }
                catch (InvalidOperationException)
                {
                    this.Work = false;
                }
                catch (TimeoutException)
                {
                    this.Work = false;
                }
                catch (IOException)
                {
                    this.Work = false;
                }

                if (char.IsNumber(Convert.ToChar(value)) | value == 46)
                {
                    this.sDataSerial += Convert.ToChar(value);
                }
            }
        }

        public void AbrirPuertoSerie()
        {
            //if (sp.IsOpen)
            //{
            //    PuntoDeVenta.tEnvioCaracter.Stop();
            //    PuntoDeVenta.tActualizarPeso.Stop();
            //     this.sp.Close();

            //    while (this.Work)
            //    {
            //        Thread.Sleep(1000000000);
            //    }
            //}
            //else
            //{
            //if (string.IsNullOrEmpty(this.sp.PortName))
            //{
            //    MessageBox.Show("Seleccione un puerto para crear conexión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            //}
            //else
            //{
            try
            {
                this.sp.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("El puerto seleccionado " + this.sp.PortName + " no está disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            //}
            //}

            wRserial = new Thread(new ThreadStart(this.serialPortDataReceived));

            this.wRserial.Start();
            //Console.WriteLine("wRserial: Starting worker thread...");
            //while (!this.wRserial.IsAlive)
            //{ }
        }

        private void tsBtnConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta consulta = new FrmConsulta();

            consulta.Show();
        }

        private void tsBtnReimprimirTicket_Click(object sender, EventArgs e)
        {
            cargarTabla();
            ticketPrint = new TicketPrint();
            ticketPrint.imprimirTicket
                (
                    tableIdProductos, 
                    lTotal.Text, 
                    txtCodigo.Text, 
                    "",//nombre_cliente, 
                    ""//$"{simbolo_descuento}{descuento.ToString()}"
                );
        }

        private void dgvProductos_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
          //  dgvProductos.CurrentRow.Cells["cCantidad"].Value = "1";
        }

        private void PuntoDeVenta_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }  
}
