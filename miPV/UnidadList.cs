using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace miPV
{
    class UnidadList : CRUD
    {
        #region atributos
        //public List<Producto> listaIdProducto;
        public string id_unidad { get; set; }
        public string unidad { get; set; }
        //private string respuesta = "";

        public string table { get; set; }
        #endregion

        #region constructores
        public UnidadList()
        {
            table = UNIDAD_LIST;
        }
        #endregion

        #region metodos


        public void insert()
        {
            execute(table, values(), action.insert.ToString(), "");
        }

        public void update(string where)
        {
            execute(table, values(), action.update.ToString(), where);
        }

        public void query(string valuesString, string where)
        {
            execute(table, $"{valuesString}", action.query.ToString(), where);
        }

        public void buscarProducto(DataGridView dgv, string descripcion, string tabla)
        {
            //bd.llenarDgv(dgv, query.buscarProducto(descripcion), tabla);
        }

        #endregion

        #region METODOS INTERFACE
        public void loadComboBox(ComboBox cb)
        {
            cb.Items.Clear();

            query("1", $"{WHERE} ?");

            //deserializeJson();

            /*cb.DataSource = user_list.Select(user => user.nombre).ToList();

            cb.SelectedIndex = -1;*/

            foreach (var unidad in list<UnidadList>())
            {
                cb.Items.Add(unidad.unidad);
            }
        }
        #endregion

        #region VALUES
        public string values()
        {
            return
            $"{unidad.ToUpper().Trim()}";
        }
        #endregion
    }
}
