using System;
using LibPrintTicket;
using System.Data;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;

namespace miPV
{
    class TicketPrint
    {
        Ticket ticket;

        public TicketPrint()
        {
            ticket = new Ticket();
        }

        private void AgregarLogo()
        {
            string logoPath = @"C:\Mac\Home\Downloads\extra_logo.jpg";
            try
            {
                if (File.Exists(logoPath))
                {
                    using (Image logo = Image.FromFile(logoPath))
                    {
                        // Redimensionar la imagen si es necesario
                        int maxWidth = 250; // Ajusta según el ancho de tu impresora
                        int newWidth = logo.Width;
                        int newHeight = logo.Height;

                        if (logo.Width > maxWidth)
                        {
                            float ratio = (float)maxWidth / logo.Width;
                            newWidth = maxWidth;
                            newHeight = (int)(logo.Height * ratio);
                        }

                        using (Bitmap resizedLogo = new Bitmap(logo, newWidth, newHeight))
                        {
                            ticket.HeaderImage = resizedLogo;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar el logo: {ex.Message}");
            }
        }


        public void imprimirTicket(DataTable tablaIdProductos, string total, string id_venta, string cliente, string descuento)
        {
            ticket.FontSize = 6;

            // Encabezado del negocio
            // AddHeaderLine("Tiendas Extra SA de CV");
            //ticket.AddHeaderLine("Regimen General de Personas Morales");
            //ticket.AddHeaderLine("TEX9302097F3");
            //ticket.AddHeaderLine("Suc 964-Extra, Av. Camino Mozárabe 1491");
            //ticket.AddHeaderLine("Coyula, 45410 Coyula, Jal.");
            //ticket.head = @"\\\\Mac\\Home\\Downloads\\extra_logo.jpg";

            //AgregarLogo();

            // Información de la sucursal
            ticket.AddHeaderLine("Tiendas Extra SA de CV");
            ticket.AddHeaderLine("Regimen General de Personas Morales");
            ticket.AddHeaderLine("TEX9302097F3");
            ticket.AddHeaderLine("Suc 964-Extra, Av. Camino Mozárabe 1491");
            ticket.AddHeaderLine("Coyula, 45410 Coyula, Jal.");

            // Información de la transacción
            ticket.AddHeaderLine("--------------------------------");
            ticket.AddHeaderLine($"CAJA #1     23/10/2024 19:35");
            ticket.AddHeaderLine($"REFERENCIA 27003497589017202411200002675970");

            // Separador
            ticket.AddHeaderLine("--------------------------------");

            // Encabezado de productos
            //ticket.AddItem("DESCRIPCION", "", "IMPORTE");
            ticket.AddHeaderLine("--------------------------------");

            // Detalle de productos
            
            ticket.AddItem("MONTO", "               :", "13,299.00");
            ticket.AddItem("COMISION DE SERVICIO", ":", "12.93");
            ticket.AddItem("IVA DE COMISION", "     :", "2.07");
            ticket.AddItem("TOTAL COMISION", "      :", "15.00");
            ticket.AddItem("PAGO TOTAL", "          :", "13,314.00");


            // Separador
            ticket.AddHeaderLine("--------------------------------");

            // Totales con formato de moneda mexicana
            ticket.AddTotal("SUBTOTAL", "13,299.00");
            ticket.AddTotal("COMISION", string.Format("$ {0:N2}", 15.00));
            ticket.AddTotal("TOTAL", "13,314.00");

            // Separador
            ticket.AddHeaderLine("--------------------------------");

            // Tipo de operación
            ticket.AddFooterLine("PAGO DE SERVICIO");
            ticket.AddFooterLine("EFECTIVO");
            ticket.AddFooterLine("PAY ULATAM");

            // Información adicional
            ticket.AddFooterLine("--------------------------------");
            ticket.AddFooterLine("AUTORIZACION : 605044");
            ticket.AddFooterLine("FOLIO DE VENTA: 244044");
            ticket.AddFooterLine("ATENDIDO POR : VIAUNAA84121B0");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("LA OPERACION SE HACE POR CUENTA Y");
            ticket.AddFooterLine("ORDEN DE PAY ULATAM");

            // Información de contacto
            ticket.AddFooterLine("");
            ticket.AddFooterLine("Atenderemos sus comentarios");
            ticket.AddFooterLine("--5267-9800--");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("Unidad Especializada de Atencion a");
            ticket.AddFooterLine("Usuarios: TEL: 81226 73446");
            ticket.AddFooterLine("");
            ticket.AddFooterLine("UNE de Atencion Telefonica CONDUSEF");
            ticket.AddFooterLine("TEL: 800 999 8080");
            ticket.AddFooterLine("WWW.condusef.gob.mx");
            ticket.AddFooterLine("CONTIGO DIA Y NOCHE www.extra.com.mx");

            try
            {
                ticket.PrintTicket("POS58 Printer");
            }
            catch(Exception)
            {
                
            }
        }
    }
}
