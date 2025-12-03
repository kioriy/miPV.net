using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace miPV
{
    class Caja
    {
        BD bd;
        Query query;
        DataSet obtenerDatos;

        decimal montoCorte;

        public Caja()
        {
            bd = new BD();
            query = new Query();
        }

        public string corte(string fecha)
        {
            obtenerDatos = new DataSet();
            obtenerDatos.Reset();

            bd.adaptador = bd.consultaAdaptador(query.corteCaja(fecha));
            bd.adaptador.Fill(obtenerDatos, "p");

            try
            {
                this.montoCorte = decimal.Parse(obtenerDatos.Tables["p"].Rows[0][0].ToString());

                return string.Format("{0:N2}", montoCorte);
            }
            catch (IndexOutOfRangeException)
            {
                return "0.0";
            }
            catch (FormatException)
            {
                return "0.0";
            }
        }
    }
}
