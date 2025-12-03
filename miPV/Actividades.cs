using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    class Actividades
    {

        BD basedatos = new BD();
        //int entra = 0;

        public void insertar_actividad(string actividad,string nombre_usuario)
        {
            DateTime now = DateTime.Now;
            string insertar_actividad = "INSERT INTO ACTIVIDADES (nombre,fecha,hora,nombre_usuario) VALUES ('" + actividad + "','" + now.ToString("dd/MM/yyyy") + "','" + DateTime.Now.ToShortTimeString() + "','"+nombre_usuario+"')";
            basedatos.ejecutaComando(insertar_actividad);
        }

        public void mostrar_actividades(string nombre_usuario, DataGridView dataActividades)
        {
            string consultar_actividades = "SELECT * FROM ACTIVIDADES where nombre_usuario=" + nombre_usuario;

            basedatos.llenarDgv(dataActividades,consultar_actividades,"ACTIVIDADES");

        }
    }
}
