using System;
using System.Configuration;
using System.Drawing.Printing;

namespace miPV
{
    class ConfiguracionPvt
    {
        public void modificarConfiguracion(string llave, string valor)
        {
            //string miValor = ConfigurationManager.AppSettings["miParametro"];
            
            /*//Para añadir un parámetro nuevo al archivo de configuración:
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Add("miParametro", "Mi valor");
            config.Save(ConfigurationSaveMode.Modified);*/
           
            //Para modificar y persistir un parámetro de configuración:
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings[llave].Value = valor;
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        public static string ObtenerImpresoraPredeterminada()
        {
            try
            {
                for (int i = 0; i < PrinterSettings.InstalledPrinters.Count; i++)
                {
                    PrinterSettings a = new PrinterSettings();
                    a.PrinterName = PrinterSettings.InstalledPrinters[i].ToString();

                    if (a.IsDefaultPrinter)
                    {
                        return PrinterSettings.InstalledPrinters[i].ToString();
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool existeImpresora(string impresora)
        {
            foreach (String strPrinter in PrinterSettings.InstalledPrinters)
            {
                if (impresora == strPrinter)
                    return true;
            }
            return false;
        }

    }
}
