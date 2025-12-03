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
    public partial class FrmCliente : Form
    {
        Cliente cliente = new Cliente();
        Cliente cliente_update = new Cliente();

        int entra = 0;
        int auxiliar_id_cliente;

        public FrmCliente()
        {
            InitializeComponent();
            cliente.loadComboBox(cbNombre);
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateForm.empty(this))
            {
                cargarVariables();
                //cliente.insert();

                if (cliente.insert())//cliente.insertarProducto(nombre, direccion, estado, precioCosto, precioVenta))
                {
                    //limpiarRegistro();
                    string index = cbNombre.Text;
                    cliente.loadComboBox(cbNombre);// bd.llenarCombobox(cbNombre, query.llenarComboBox("nombre", "PRODUCTO"), "nombre", "PRODUCTO", ref entra);
                    cbNombre.SelectedIndex = cbNombre.FindString(index);
                    crearNotificacion("Cliente registrado", Color.Green);
                    //check de registro de cliente
                    //actividad.insertar_actividad("Registro cliente", "Persona X");
                }
            }
            else
            {
                crearNotificacion("Llenar todos los datos", Color.Red);
            }
        }

        private void cbNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entra == 0)
            {
                if (cbNombre.Text != "")
                {
                    //crearNotificacion("Notificaciones:", Color.Red);
                    cargarVariablesDeClase();
                    auxiliar_id_cliente = cliente_update.id_cliente;
                    cmdAgregarProducto.Visible = false;
                    cmdActualizar.Visible = true;
                }
            }  
        }

        private void cmdActualizar_Click(object sender, EventArgs e)
        {
            cargarVariables();

            if (compararDatos())
            {
                //cargarVariables();

                //cliente.update($"{cliente.WHERE} {cliente.id_cliente_a} {cliente.igual} {cliente_update.id_cliente}");//producto.actualizarProducto(codigo, descripcion, cantidad, precioCosto, precioVenta, idProducto);
                //cliente.update($"{cliente_update.id_cliente}");

                if (cliente.update($"{cliente_update.id_cliente}"))
                {
                    crearNotificacion("Producto actualizado", Color.Green);
                    //limpiarRegistro();
                    //cmdAgregarProducto.Visible = true;
                    //cmdActualizar.Visible = false;
                    cliente.loadComboBox(cbNombre);// bd.llenarCombobox(cbCodigo, query.llenarComboBox("codigo", "PRODUCTO"),"codigo", "PRODUCTO", ref entra);
                }
            }
            else
            {
                crearNotificacion("No hay cambios por aplicar", Color.Orange);
            }
        }

        #region metodos formulario

        #region cargarVariables()
        public void cargarVariables()
        {
            cliente.nombre = cbNombre.Text;
            cliente.rfc = txtRfc.Text.ToLower();
            cliente.telefono = txtTelefono.Text;
            cliente.correo = txtCorreo.Text;
            cliente.ciudad = txtCiudad.Text;
            cliente.direccion = txtDireccion.Text;
            cliente.estado = txtEstado.Text;
            cliente.ciudad = txtCiudad.Text; //proveedor.idProveedor(cbProveedor.Text);
        }

        public void cargarVariablesDeClase()
        {
            //cliente.cargarProducto(cbNombre.Text);
            cliente_update = cliente.list().Find(x => x.nombre == cbNombre.Text);
            //idProducto = cliente.id_producto;
            txtDireccion.Text = cliente_update.direccion;
            txtCiudad.Text = cliente_update.ciudad;
            txtEstado.Text = cliente_update.estado;
            txtRfc.Text = cliente_update.rfc.ToLower();
            txtCorreo.Text = cliente_update.correo;
            txtTelefono.Text = cliente_update.telefono;
            //cbProveedor.Text = proveedor.list<Proveedor>().Find(x => x.id_proveedor == cliente_update.ciudad).nombre;
        }

        public bool compararDatos()
        {
            if (cliente_update.nombre == cliente.nombre & 
                cliente_update.direccion == cliente.direccion &
                cliente_update.ciudad == cliente.ciudad &
                cliente_update.estado == cliente.estado &
                cliente_update.correo == cliente.correo &
                cliente_update.telefono == cliente.telefono)
            {
                return false;
            }
            return true;
        }
        #endregion

        #region validarDatos() ->
        /*public bool validarDatos()
        {
            if (cbNombre.Text == "")
            {
                return false;
            }
            else if (txtDireccion.Text == "")
            {
                return false;
            }
            else if (txtEstado.Text == "")
            {
                return false;
            }
            else if (txtCorreo.Text == "")
            {
                return false;
            }
            else if (txtTelefono.Text == "")
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
            //cliente = new Producto();
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
            cbNombre.Text = "";
            txtDireccion.Text = "";
            //txtEstado.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            //cmdAgregarProducto.Visible = true;
            //cmdActualizar.Visible = false;
        }
        #endregion

        #endregion

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear.clearForm(this);
            cmdAgregarProducto.Visible = true;
            cmdActualizar.Visible = false;
        }
    }
}
