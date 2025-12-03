using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    class Usuario : BD
    {
        private string id_usuario = "";
        private string nombre = "";
        private string contraseña = "";
        private string roll = "";

        private string tabla = "";

        Actividades actividades = new Actividades();

        #region Constructor
        public Usuario()
        {
            tabla = "USUARIO";
        }
        #endregion

        #region SET & GET
        public string Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return contraseña;
            }

            set
            {
                contraseña = value;
            }
        }

        public string Tabla
        {
            get
            {
                return tabla;
            }

            set
            {
                tabla = value;
            }
        }

        public string Roll
        {
            get
            {
                return roll;
            }

            set
            {
                roll = value;
            }
        }
        #endregion

        #region Metodos
        public bool cargar(string nombre)
        {
            string condicion = $"WHERE nombre = '{nombre}'";
            try
            {
            obtenerDatos = consulta(queryConsulta("`id_usuario`,`nombre`,`contraseña`,`roll`", tabla, condicion), tabla);

            this.id_usuario = obtenerDatos.Tables[tabla].Rows[0][0].ToString().Trim();
            this.Nombre = obtenerDatos.Tables[tabla].Rows[0][1].ToString().Trim();
            this.Contraseña = obtenerDatos.Tables[tabla].Rows[0][2].ToString().Trim();
            this.Roll = obtenerDatos.Tables[tabla].Rows[0][3].ToString().Trim();
            return true;
            }
            catch (Exception e)
            {
                MessageBox.Show("No se pudo cargar la informacion\nError: ", e.ToString());
                return false;
            }

        }

        public bool insertarUsuario()
        {
            //Check de actividad insertar usuario
            actividades.insertar_actividad("Agrego un usuario", "Persona X");
            return insertar(insertarUsuario(Nombre, Contraseña, Roll));
        }

        public bool actualizar(string nombre, string contraseña, string roll, string id)
        {
            return insertar(actualizarUsuario(nombre, contraseña, roll, id));
        }

        public void llenarComboboxUsuario(ComboBox cb, ref int entra)
        {
            llenarCombobox(cb,queryConsulta("nombre", Tabla,""),"nombre",Tabla,ref entra);
        }
        #endregion
    }
}
