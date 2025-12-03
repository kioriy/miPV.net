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
    public partial class FrmProveedor : Form
    {
        Proveedor proveedor = new Proveedor();
        Proveedor proveedor_update = new Proveedor();

        string auxiliar_id_proveedor = "";

        public FrmProveedor()
        {
            InitializeComponent();
            proveedor.loadComboBox(cbProveedor);
        }

        private void cmdAgregarProducto_Click(object sender, EventArgs e)
        {
            if (!ValidateForm.empty(this))
            {
                cargarVariables();
                proveedor.insert();

                if (Mensaje.result_bool)
                {
                    //limpiarRegistro();
                    string index = cbProveedor.Text;
                    proveedor.loadComboBox(cbProveedor);
                    cbProveedor.SelectedIndex = cbProveedor.FindString(index);
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

                proveedor.update($"{proveedor_update.id_proveedor}");

                if (Mensaje.result_bool)
                {
                    crearNotificacion("Producto actualizado", Color.Green);
                    //limpiarRegistro();
                    //cmdAgregarProducto.Visible = true;
                    //cmdActualizar.Visible = false;
                    proveedor.loadComboBox(cbProveedor);
                }
            }
            else
            {
                crearNotificacion("No hay cambios por aplicar", Color.Orange);
            }
        }

        private void cbProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (entra == 0)
            //{
            if (cbProveedor.Text != "")
            {
                //crearNotificacion("Notificaciones:", Color.Red);
                cargarVariablesDeClase();
                auxiliar_id_proveedor = proveedor_update.id_proveedor.ToString();
                cmdAgregarProducto.Visible = false;
                cmdActualizar.Visible = true;
            }
            //}
        }

        public void cargarVariables()
        {
            proveedor.nombre = cbProveedor.Text.ToUpper();
            proveedor.direccion = txtDireccion.Text.ToUpper();
            proveedor.telefono = txtTelefono.Text;
        }

        public void cargarVariablesDeClase()
        {
            //producto.cargarProducto(cbCodigo.Text);
            proveedor_update = proveedor.list().Find(x => x.nombre == cbProveedor.Text);
            //idProducto = producto.id_producto;
            cbProveedor.Text = proveedor_update.nombre.ToUpper();
            txtDireccion.Text = proveedor_update.direccion.ToUpper();
            txtTelefono.Text = proveedor_update.telefono;
        }

        public void crearNotificacion(string mensaje, Color color)
        {
            lNotificaciones.ForeColor = color;
            lNotificaciones.Text = mensaje;
        }

        public bool compararDatos()
        {
            if (proveedor_update.nombre == proveedor.nombre && proveedor_update.direccion == proveedor.direccion && proveedor_update.telefono == proveedor.telefono)
            {
                return false;
            }
            return true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear.clearForm(this);
        }
    }
}
