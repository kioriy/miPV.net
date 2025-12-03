using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
//using Mono.Data.Sqlite;
//using Mono.Data;
using System.Configuration;
using System.Linq;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace miPV
{
    public class BD : Query
    {
        #region variables

        string parametrosConexion = ConfigurationManager.ConnectionStrings["db"].ConnectionString;
        public SQLiteConnection conexionBD; // SQLiteConnection conexionBD;
        public SQLiteCommand queryCommand; // SQLiteCommand queryCommand;
        public SQLiteDataAdapter adaptador; //SQLiteDataAdapter adaptador;
        public DataSet obtenerDatos;
        public string json;

        #endregion

        #region Abrir y cerrar conexion

        public bool conexionAbrir()
        {
            conexionBD = new SQLiteConnection(parametrosConexion); // SQLiteConnection(parametrosConexion);
            ConnectionState estadoConexion;
            try
            {
                conexionBD.Open();
                estadoConexion = conexionBD.State;
                return true;
            }
            catch (SQLiteException)//SQLiteException)
            {
                return false;
            }
        }

        public void conexionCerrar()
        {
            if (conexionBD.State == ConnectionState.Open)
            {
                conexionBD.Close();
            }
        }

        #endregion

        #region metodos
        public bool insertar(string sqliteInsertar)
        {
            int filasafectadas = 0;
            conexionAbrir();

            queryCommand = new SQLiteCommand (sqliteInsertar, conexionBD);// SQLiteCommand(sqliteInsertar, conexionBD);

            filasafectadas = queryCommand.ExecuteNonQuery();

            conexionCerrar();

            if (filasafectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region consulta

        public DataSet consulta(string queryConsulta, string tabla)
        {
            conexionAbrir();

            obtenerDatos = new DataSet();
            obtenerDatos.Reset();

            adaptador = new SQLiteDataAdapter(queryConsulta, conexionBD);//SQLiteDataAdapter(queryConsulta, conexionBD);

            adaptador.Fill(obtenerDatos, tabla);

            conexionCerrar();

            //var empList = obtenerDatos.Tables[0].AsEnumerable().Select(dataRow => new Producto { descripcion = dataRow.Field<string>("Name") }).ToList();

            //json = JsonConvert.SerializeObject(obtenerDatos);//, Formatting.Indented);

            return obtenerDatos;
        }

        //public List<DataRow> consulta<T>(string queryConsulta, string tabla)
        //{
        //    conexionAbrir();

        //    obtenerDatos = new DataSet();
        //    obtenerDatos.Reset();

        //    adaptador = new SQLiteDataAdapter(queryConsulta, conexionBD);

        //    adaptador.Fill(obtenerDatos, tabla);

        //    conexionCerrar();

        //    //var empList = obtenerDatos.Tables[0].AsEnumerable().Select(dataRow => new Producto { descripcion = dataRow.Field<string>("Name") }).ToList();

        //    json = JsonConvert.SerializeObject(obtenerDatos);

        //    //List<DataRow> lista = obtenerDatos.Tables[0].AsEnumerable().ToList();

        //    return lista; //ToList<T>(); //btenerDatos;
        //}

        #endregion

        #region abrir conexion a la base de datos

        public bool abrirConexion()
        {
            conexionBD = new SQLiteConnection(parametrosConexion);// SQLiteConnection(parametrosConexion);
            ConnectionState estadoConexion;

            try
            {
                conexionBD.Open();
                estadoConexion = conexionBD.State;
                return true;
            }
            catch (SQLiteException)//SQLiteException)
            {
                return false;
            }
        }

        #endregion

        #region cerrar conexion a la base de datos

        private void cerrarConexion()
        {
            if (conexionBD.State == ConnectionState.Open)
            {
                conexionBD.Close();
            }
        }

        #endregion

        #region ejecuta la instruccion sql insertar y update

        public bool ejecutaComando(string query)
        {
            int filasAfectadas = 0;
            abrirConexion();

            queryCommand = new SQLiteCommand(query, conexionBD);//SQLiteCommand(query, conexionBD);
            filasAfectadas = queryCommand.ExecuteNonQuery();
            cerrarConexion();

            if (filasAfectadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion

        #region Adaptador -> carga los datos de una consulta

        public SQLiteDataAdapter consultaAdaptador(string query)
        {
            abrirConexion();
            adaptador = new SQLiteDataAdapter(query, conexionBD);//SQLiteDataAdapter(query, conexionBD);
            cerrarConexion();
            return adaptador;
        }

        #endregion

        #region llena un comboBox con una consulta sql

        public void llenarCombobox(ComboBox llenarComBox, string query, string columna,
            string tabla, ref int entra)
        {
            obtenerDatos = new DataSet();
            obtenerDatos.Reset();
            adaptador = consultaAdaptador(query);
            adaptador.Fill(obtenerDatos, tabla);
            entra = 1;
            llenarComBox.DataSource = obtenerDatos.Tables[tabla];
            llenarComBox.DisplayMember = columna;
            llenarComBox.SelectedIndex = -1;
            entra = 0;
        }

        #endregion

        #region llena un listBox con una consulta sql

        public void llenarListBox(System.Windows.Forms.ListBox llenarListBox, string query, string columna,
            string tabla, ref int entra)
        {
            obtenerDatos = new DataSet();
            obtenerDatos.Reset();
            adaptador = consultaAdaptador(query);
            adaptador.Fill(obtenerDatos, tabla);
            entra = 1;
            llenarListBox.DataSource = obtenerDatos.Tables[tabla];
            llenarListBox.DisplayMember = columna;
            llenarListBox.SelectedIndex = -1;
            entra = 0;
        }

        #endregion

        #region llena un dataGridView con una consulta sql

        public void llenarDgv(System.Windows.Forms.DataGridView dgvLlenar, string query, string tabla)
        {
            obtenerDatos = new DataSet();
            obtenerDatos.Reset();

            adaptador = consultaAdaptador(query);
            adaptador.Fill(obtenerDatos, tabla);

            dgvLlenar.DataSource = obtenerDatos.Tables[0];
        }

        #endregion

        //public List<T> list<T>()
        //{
        //    if (json != "false")
        //    {
        //        return JsonConvert.DeserializeObject<List<T>>(json);
        //    }

        //    return null;
        //}

        #endregion
    }
}