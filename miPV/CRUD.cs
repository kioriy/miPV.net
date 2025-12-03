using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace miPV
{
    public abstract class CRUD : Query
    {
        WSpvt.PVT ws = new WSpvt.PVT();
 
        //public string result = "";
        public string json = ""; 
  
        public void execute(string table, string values, string action, string where)
        {
            try
            {
                ws.Timeout = 600000;
                json = ws.query(table, values, action, where);

                if (json != "[null]" & json != "" & json != "false")
                {
                    Mensaje.getMessage(messageResponse.actionSuccess.ToString());
                }
                else
                {
                    Mensaje.getMessage(messageResponse.actionFail.ToString());
                }
            }
            catch (System.Net.WebException)
            {
                Mensaje.getMessage(messageResponse.conectionFail.ToString());
            }
            catch (System.InvalidOperationException)
            {
                Mensaje.getMessage(messageResponse.allActionFail.ToString());
            }
        }

        public void execute()
        {

        }

        public List<T> list<T>()
        {
            if (json != "false")
            {
                return JsonConvert.DeserializeObject<List<T>>(json);
            }

            return null;
        }
    }
}
      