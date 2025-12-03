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
    public partial class frmInicioSession : Form
    {
        bool nuevoUsuario = false;

        public frmInicioSession()
        {
            InitializeComponent();
        }

        public bool validarPassword()
        {
            string contraseña = txtContraseña1.Text;
            string verificarContraseña = txtContraseña2.Text;

            if (contraseña != "" && verificarContraseña != "")
            {
                if(string.Compare(contraseña, verificarContraseña) == 0)
                {
                    return true;
                }
            }
            return false;
        }

        private bool validarContraseñaAdministrador()
        {
            return false;
        }

        private void lNuevoUsuario_Click(object sender, EventArgs e)
        {
            this.txtContraseña2.Visible = true;
            this.labelContraseña2.Visible = true;
            this.labelAdmin.Visible = true;
            this.txtContraseñaAdmin.Visible = true;
            this.cbRol.Visible = true;
            lRol.Visible = true;
            liniciar.Visible = true;

            lNuevoUsuario.Visible = false;
            lRegistrar.Visible = false;


            btnIniciarSession.Location = new Point(221, 421);

            nuevoUsuario = true;
        }

        private void btnIniciarSession_Click(object sender, EventArgs e)
        {
            IniciarSesion();
            //string nombreUsuario = txtUsuario.Text;
            //string contraseña = "charly1985";
            //string rol = cbRol.Text;

            //Usuario usuario = new Usuario() {Nombre = nombreUsuario, Contraseña = contraseña };

            //if (nombreUsuario != "" && contraseña != "")
            //{
            //    if (validarPassword())
            //    {
            //        if (nuevoUsuario)
            //        {
            //            if (!usuario.cargar(nombreUsuario))
            //            {
            //                usuario.insertarUsuario();
            //                usuario.cargar(nombreUsuario);

            //                PuntoDeVenta formularioPrincipal = new PuntoDeVenta();

            //                this.Hide();
            //            }
            //            else
            //            {
            //                MessageBox.Show("El usuario ya existe, elija otro nombre de usuario");

            //                txtUsuario.Focus();
            //            }
            //        }
            //        else
            //        {
            //            usuario.cargar(nombreUsuario);

            //            PuntoDeVenta formularioPrincipal = new PuntoDeVenta();

            //            this.Hide();
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Las contraseñas no coinciden favor de verificar");
            //    }
            //}
        }

        public void IniciarSesion()
        {
            string contraseña = "jpatitito";
            string usuario = cbUsuario.Text;

            PuntoDeVenta PuntoDeVenta;

            if (usuario == "CAJERO")
            {
                PuntoDeVenta = new PuntoDeVenta(false);
                PuntoDeVenta.Show();
                this.Hide();
            }
            else
            {
                if (txtContraseña1.Text == contraseña)
                {
                    PuntoDeVenta = new PuntoDeVenta(true);
                    PuntoDeVenta.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Acceso no autorizado, verifica contraseña");
                }
            }
        }

        private void verificarUsuario()
        {

           
          
          
        }

        private void liniciar_Click(object sender, EventArgs e)
        {
            this.txtContraseña2.Visible = false;
            this.labelContraseña2.Visible = false;
            this.labelAdmin.Visible = false;
            this.txtContraseñaAdmin.Visible = false;
            this.cbRol.Visible = false;
            lRol.Visible = false;
            liniciar.Visible = false;
            lNuevoUsuario.Visible = true;
            lRegistrar.Visible = true;

            btnIniciarSession.Location = new Point(222, 263);

            nuevoUsuario = false;
        }
    }
}
