using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miPV
{
    public static class Mensaje
    {
        public static string result { get; set; }
        public static bool result_bool { get; set; }
        //public string origen { get; set; }

        static List<string> lista_mensajes = new List<string>()
        {
            "FALLO conexion con el servidor revisa tu conexión a internet",//0
            "Accion realizada correctamente :-)",//1
            "FALLO al realizar acción solicitada, intenta de nuevo",//2
            
            //"!!EXITO¡¡ al cargar la consulta",
            //"No se encontro ningun registro",
            "Todos los campos son requeridos",//3
            "La respuesta no genero ningun resultado \n\n ACCION: CONTACTAR A SISTEMAS",//4
            //"La respuesta no genero ningun resultado \n ACCION: CONTACTAR A SISTEMAS"
        };

        static List<string> list_responseMessage = new List<string>()
        {
            "Presione 'Aceptar' para confirmar acción",
            "Registro ",
            "Remover cliente de la venta"
        };

        public static string getMessage(string indice)
        {
            switch (indice)
            {
                case "conectionFail":
                    result = lista_mensajes[0];
                    result_bool = false;
                    return result;

                case "actionSuccess":
                    result = $"{lista_mensajes[1]}";
                    result_bool = true;
                    return result;

                case "actionFail":
                    result = $"{lista_mensajes[2]}";
                    result_bool = false;
                    return result;

                case "fieldsRequired":
                    result = $"{lista_mensajes[3]}";
                    result_bool = false;
                    return result;

                case "allActionFail":
                    result = $"{lista_mensajes[4]}";
                    result_bool = false;
                    return result;

                default:
                    return "";
            }
        }

        public static void resultEmpty()
        {
            result = "";
        }

        public static DialogResult responseMessage(string caption)
        {
            //mensaje = "Presione 'Aceptar' para confirmar acción";
            //caption = "Registro venta";
            MessageBoxButtons botones = MessageBoxButtons.OKCancel;
            //DialogResult resultado;

            return MessageBox.Show(result, $"{caption}", botones);
        }
    }
}
