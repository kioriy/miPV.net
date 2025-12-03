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
    public partial class FormActividad : Form
    {
        Actividades actividades = new Actividades();
        BD basedatos = new BD();
        string usuario = "";
        string query_comboBox = "SELECT nombre FROM USUARIO";
        int entrar = 0;

        public FormActividad()
        {
            InitializeComponent();
            basedatos.llenarCombobox(comboBoxUsuario, query_comboBox, "nombre", "USUARIO", ref entrar);
            comboBoxUsuario.SelectedIndex = -1;
            //actividades.mostrar_actividades()
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(entrar == 0)
            {
                GridViewActividades.ClearSelection();
                usuario = comboBoxUsuario.GetItemText(comboBoxUsuario.SelectedItem);
                string query_DataActividades = "SELECT * FROM ACTIVIDADES WHERE nombre_usuario = '" + usuario + "'";
                basedatos.llenarDgv(GridViewActividades,query_DataActividades, "ACTIVIDADES");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GridViewActividades.ClearSelection();
            string fecha = DateTime.Value.ToString("dd/MM/yyyy");
            string query_DateTime = "SELECT * FROM ACTIVIDADES WHERE nombre_usuario = '" + usuario + "' AND fecha = '" + fecha + "'";
            basedatos.llenarDgv(GridViewActividades, query_DateTime, "ACTIVIDADES");
        }
    }
}
