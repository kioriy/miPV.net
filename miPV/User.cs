using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace miPV
{
    public class User : CRUD
    {
        public int id_user { get; set; }
        public string nombre { get; set; }
        public string password { get; set; }
        public NivelAcceso nivel_acceso { get; set; }
        public string administracion { get; set; }
        public string fecha_creacion { get; set; }
        public string fk_empleado { get; set; }

        private string table = "";

        //public List<User> user_list { get; set; }

        public User()
        {
            table = USUARIO;
        }

        #region METODOS
        public void insert()
        {
            execute(table, values(), action.insert.ToString(), "");
        }

        

        public override int GetHashCode()
        {
            return list<User>().Find(x => x.nombre == this.nombre).id_user;
        }

        /*public User Initialize(User user)
        {
            if (user_list != null)
            {
                return user = user_list[0];
            }
            else
            {
                return null;
            }
        }*/

        /*public void deserializeJson()
        {
            user_list = JsonConvert.DeserializeObject<List<User>>(json);
        }*/

        /*public int idUser(string nombre)
        {
            User user = list<User>().Find(x => x.nombre == nombre);

            return user.id_user;
        }*/

        /*public void login()
        {
            if (nivel_acceso == NivelAcceso.ADMINISTRADOR | nivel_acceso == NivelAcceso.SISTEMAS | nivel_acceso == NivelAcceso.SUPERVISOR)
            {
                FrmVentaLote frmVentaLote = new FrmVentaLote(this);
                frmVentaLote.Show();
            }
            if (nivel_acceso == NivelAcceso.CAJERO)
            {
                FrmPago frmPago = new FrmPago(this);
                frmPago.Show();
            }
        }*/
        #endregion

        #region METODOS INTERFACE
        public void loadComboBox(ComboBox cb)
        {
            //query("1", $"{WHERE} ?");

            //deserializeJson();

            /*cb.DataSource = user_list.Select(user => user.nombre).ToList();

            cb.SelectedIndex = -1;*/

            foreach (var user in list<User>())
            {
                cb.Items.Add(user.nombre.ToUpper());
            }
        }
        #endregion

        #region VALUES
        public string values()
        {
            return
            $"{nombre.ToLower().Trim()}{cc}" +
            $"{password.ToLower().Trim()}{cc}" +
            $"{nivel_acceso}{cc}" +
            $"{administracion.ToUpper().Trim()}{cc}" +
            $"{fecha_creacion.ToUpper().Trim()}{cc}" +
            $"{fk_empleado.ToUpper().Trim()}";
        }
        #endregion
    }
}
