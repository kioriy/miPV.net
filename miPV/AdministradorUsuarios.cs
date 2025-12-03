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
    public partial class AdministradorUsuarios : Form
    {
        Usuario usuario = new Usuario();
        int entra = 0;
        BD bd = new BD();

        public AdministradorUsuarios()
        {
            InitializeComponent();
            usuario.llenarComboboxUsuario(Cbusuario, ref entra);
            Cbusuario.SelectedIndex = -1;
        }

        private void btmodificar_Click(object sender, EventArgs e)
        {

            if (usuario.actualizar(txnombre.Text, txcontraseña.Text, txRoll.Text, lb_Idcajero.Text))
            {
                MessageBox.Show("Se actualizo la informacion");
            }

        }

        /// <summary>
        /// Al presionar enter en el combobox se cargaran los datos en los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_Enter(object sender, EventArgs e)
        {
            //usuario.cargar(Cbusuario.Text);
            //txId_usuario.Text = usuario.Id_usuario;
            //txnombre.Text = usuario.Nombre;
            //txcontraseña.Text = usuario.Contraseña;

        }

        private void cbusuario_TextChanged(object sender, EventArgs e)
        {
            if (entra == 0)
            {
                string nombre = Cbusuario.Text;
                if (usuario.cargar(nombre))
                {
                    lbid.Visible = true;
                    lb_Idcajero.Text = usuario.Id_usuario;
                    txnombre.Text = usuario.Nombre;
                    txcontraseña.Text = usuario.Contraseña;
                    txRoll.Text = usuario.Roll;
                }
            }
        }

    }
}
