using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    public partial class FrmProducto : Form
    {
        #region variables
        //BD bd;
        
        Producto producto = new Producto();
        Producto producto_update = new Producto();
        //UnidadList unidad = new UnidadList();
        Proveedor proveedor = new Proveedor();
        Actividades actividad = new Actividades();
        Producto producto_actulizar_lista1 = new Producto();
        ComboBox cb_reload1 = new ComboBox();
        //string idProducto;
        //string codigo;
        //string descripcion;
        //string cantidad;
        //string precioCosto;
        //string precioVenta;
        int auxiliar_id_producto;
        int entra = 0;
        #endregion

        #region constructor
        public FrmProducto(ref Producto producto_actulizar_lista, ref ComboBox cb_reload)
        {
            this.producto_actulizar_lista1 = producto_actulizar_lista;
            this.cb_reload1 = cb_reload;
            InitializeComponent();
            inicializarVariables();
            //unidad.loadComboBox(cbUnidad);
            producto.loadComboBox(cbCodigo, true,ref entra);
            proveedor.loadComboBox(cbProveedor);
            //bd.llenarCombobox(cbCodigo, query.llenarComboBox("codigo", "PRODUCTO"),"codigo", "PRODUCTO", ref entra);
        }
        #endregion

        #region botones

        #region agregar Producto
        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateForm.empty(this))
            {
                cargarVariables();
                //producto.insert();

                if (producto.insert())//()Mensaje.result_bool)//producto.insertarProducto(codigo, descripcion, cantidad, precioCosto, precioVenta))
                {
                    //limpiarRegistro();
                    string index = cbCodigo.Text;
                    producto.loadComboBox(cbCodigo, true, ref entra);// bd.llenarCombobox(cbCodigo, query.llenarComboBox("codigo", "PRODUCTO"), "codigo", "PRODUCTO", ref entra);
                    cbCodigo.SelectedIndex = cbCodigo.FindString(index);
                    crearNotificacion("Producto registrado", Color.Green);
                    //check de registro de producto
                    //actividad.insertar_actividad("Registro producto", "Persona X");
                } 
            }
            else
            {
                crearNotificacion("Llenar todos los datos", Color.Red);
            }
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            cargarVariables();

            if (compararDatos())
            {
                //cargarVariables();

                //producto.update($"{producto_update.id_producto}");//producto.actualizarProducto(codigo, descripcion, cantidad, precioCosto, precioVenta, idProducto);

                if (producto.update($"{producto_update.id_producto}"))
                {
                    crearNotificacion("Producto actualizado", Color.Green);
                    //limpiarRegistro();
                    //cmdAgregarProducto.Visible = true;
                    //cmdActualizar.Visible = false;
                    producto.loadComboBox(cbCodigo, true, ref entra);// bd.llenarCombobox(cbCodigo, query.llenarComboBox("codigo", "PRODUCTO"),"codigo", "PRODUCTO", ref entra);
                }
            }
            else
            {
                crearNotificacion("No hay cambios por aplicar", Color.Orange);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear.clearForm(this);
            crearNotificacion("Notificaciones:", Color.Red);
            cmdAgregarProducto.Visible = true;
            cmdActualizar.Visible = false;

        }
        #endregion

        #endregion

        #region eventos comboBox
        private void cbCodigo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entra == 0)
            {
                if (cbCodigo.Text != "") 
                {
                    //crearNotificacion("Notificaciones:", Color.Red);
                    cargarVariablesDeClase();
                    auxiliar_id_producto = producto_update.id_producto;
                    cmdAgregarProducto.Visible = false;
                    cmdActualizar.Visible = true;
                }
            }
        }
        #endregion

        #region metodos formulario

        #region cargarVariables()
        public void cargarVariables()
        {
            producto.codigo = cbCodigo.Text;
            producto.unidad = cbUnidad.Text.ToLower();
            producto.precio_venta = txtPrecioVenta.Text;
            producto.precio_costo = txtPrecioCosto.Text;
            producto.descripcion = txtDescripcion.Text;
            producto.cantidad = txtCantidad.Text;
            producto.fk_id_proveedor = proveedor.idProveedor(cbProveedor.Text);
        }

        public void cargarVariablesDeClase()
        {
            //producto.cargarProducto(cbCodigo.Text);
            producto_update = producto.list().Find(x => x.codigo == cbCodigo.Text );
            //idProducto = producto.id_producto;
            txtDescripcion.Text = producto_update.descripcion;
            txtCantidad.Text = producto_update.cantidad;
            cbUnidad.Text = producto_update.unidad.ToLower();
            txtPrecioCosto.Text = producto_update.precio_costo;
            txtPrecioVenta.Text = producto_update.precio_venta;
            cbProveedor.Text = proveedor.list().Find(x => x.id_proveedor == producto_update.fk_id_proveedor).nombre;
        }

        public bool compararDatos()
        {
            if (producto_update.codigo == producto.codigo & 
                producto_update.descripcion == producto.descripcion & 
                producto_update.cantidad == producto.cantidad & 
                producto_update.precio_costo == producto.precio_costo & 
                producto_update.precio_venta == producto.precio_venta & 
                producto_update.unidad == producto.unidad)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region validarDatos() ->
        /*public bool validarDatos()
        {
            if (cbCodigo.Text == "")
            {
                return false;
            }
            else if (txtDescripcion.Text == "")
            {
                return false;
            }
            else if (txtCantidad.Text == "")
            {
                return false;
            }
            else if (txtPrecioCosto.Text == "")
            {
                return false;
            }
            else if (txtPrecioVenta.Text == "")
            {
                return false;
            }   
            return true;
        }*/
        #endregion

        #region inicializarVariables() -> instancia todos los objetos usados en el formulario
        public void inicializarVariables()
        {
            //tableIdProductos = new DataTable();
            producto = new Producto();
            //bd = new BD();
            //query = new Query();
            //dgv = new GestionDGV(dgvProductos);
            //venta = new Venta();
            //detalleVenta = new DetalleVenta(tableIdProductos);
            //ticketPrint = new TicketPrint();

        }
        #endregion

        #region crearNotificacion() -> crea los mesajes de notificacion
        public void crearNotificacion(string mensaje, Color color)
        {
            lNotificaciones.ForeColor = color;
            lNotificaciones.Text = mensaje;
        }
        #endregion

        #region limpiarNotificacion() -> limpia el label lNotificaciones
        public void limpiarNotificaciones()
        {
            crearNotificacion("Notificaciones:", Color.Red);
        }
        #endregion

        #region limpiarRegistro() -> limpia todos los registros despues de la venta;
        public void limpiarRegistro()
        {
            cbCodigo.Text = "";
            txtDescripcion.Text = "";
            //txtCantidad.Text = "";
            txtPrecioCosto.Text = "";
            txtPrecioVenta.Text = "";
        }
        #endregion

        #endregion

        private void FrmProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            producto_actulizar_lista1.loadComboBox(cb_reload1, false, ref entra);
        }
    }
}
