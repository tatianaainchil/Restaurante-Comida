using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    class Impresora
    {
        public void imprimir(Tiket ticket)
        {
            try
            {
                var pathArchivo = "C:\\ticket\\";
                var nomArchivo = pathArchivo + "Ticket" + ticket.idTicket + ".txt";
                var archivo = new StreamWriter(nomArchivo);
                // aca van los datos
                archivo.WriteLine(ticket.pedido.cliente.Apellido + ", " + ticket.pedido.cliente.Nombre);
                archivo.WriteLine(ticket.pedido.cliente.Direccion);
                archivo.WriteLine("**********************************************************");
                archivo.WriteLine(ticket.NombreFantasia);
                archivo.WriteLine("________________COMPRA____________________");
                archivo.WriteLine("Razon Social:" + " " + ticket.RazonSocial);
                archivo.WriteLine("Direccion: " + " " + ticket.Direccion);
                archivo.WriteLine("Inc.Act:" + " " + ticket.InicioActividad);
                archivo.WriteLine("CUIT: " + " " + ticket.Cuit);
                archivo.WriteLine("Fecha : " + ticket.pedido.Fecha + "                         " + "Ticket Nº" + ticket.idTicket);
                //aca va la compra
                archivo.WriteLine("**********************************************************");
                foreach (var det in ticket.pedido.detalle)
                {
                    archivo.WriteLine(det.Alim.Ingrediente +" => "+ det.Alim.Tipo + " => Precio $ " + det.Alim.Precio + " => Cantidad: " 
                        + det.Cantidad + " => Sub Total $" + det.PrecSubTotal);
                }

                archivo.WriteLine("Total :  $" + ticket.pedido.Precio_Total);
                archivo.WriteLine("**********************************************************");
                // aca el final
                archivo.WriteLine("Gracias por su compra");
                archivo.WriteLine("Lo esperamos nuevamente");

                archivo.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
