using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tp_Integrador_BurgerSix
{
    public class PedidoDetalle
    {
        public int IdPedido;
        public int Id_Detalle;
        public static int idGeneral;
        public int Cantidad { get; set; }
        public double PrecSubTotal { get; set; }
        public Alimento Alim { get; set; }
        public PedidoDetalle(int cant,Alimento ali)
        {
            idGeneral++;
            Id_Detalle = idGeneral;
            Cantidad = cant;
            PrecSubTotal = ali.Precio * cant;
            Alim = ali;   
        }
        public List<PedidoDetalle> AgregarPedido(Alimento hamb, List<PedidoDetalle> listDetalle, PedidoDetalle det, int cant)
        {
            try
            {
                if (String.IsNullOrEmpty(hamb.Ingrediente)) //valido que el Id_Cliente no sea 0
                {
                    throw new ApplicationException("No hay elementos seleccionados.");
                }
                
                det.Alim = hamb;
                det.Cantidad = cant;
                det.PrecSubTotal = hamb.Precio* cant;

                listDetalle.Add(det);

                return listDetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
       public static List<PedidoDetalle> BuscarDetallePedido(List<PedidoDetalle> listaDetalle,List<Pedido_> listPed, int id)
        {
            try
            {
                List<PedidoDetalle> listaP = new List<PedidoDetalle>();
                var ld = listaP.FindIndex(item => item.IdPedido == id); // guardo el indice que tiene busqueda, mientras que coincida con los valores

                if (ld != 0)
                {
                    foreach (var det in listaDetalle)
                    {
                        listaP.Add(listaDetalle.Find(x => x.IdPedido == id));

                    }
                }

                else
                {
                    throw new ApplicationException("Pedido no encontrado");
                }
                
                return listaP;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<PedidoDetalle> Modificaritemspedido(List<PedidoDetalle> listadetalle,int idDetalle, PedidoDetalle items)
        {
            try
            {
                var cd = listadetalle.FindIndex(item => item.Id_Detalle == idDetalle); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (cd >= 0)
                {
                    if (!String.IsNullOrEmpty(items.Alim.Ingrediente.Trim())) //compruebo que el parametro recibido no este vacio
                    {
                        listadetalle[cd].Alim.Ingrediente = items.Alim.Ingrediente;
                    }
                    if (!String.IsNullOrEmpty(items.Alim.Tipo.Trim())) //compruebo que el parametro recibido no este vacio
                    {
                        listadetalle[cd].Alim.Tipo = items.Alim.Tipo;
                    }
                    if (items.Alim.Precio > 0) //compruebo que el parametro recibido no este vacio
                    {
                        listadetalle[cd].Alim.Precio= items.Alim.Precio;
                    }
                    if (items.Cantidad > 0) //compruebo que el parametro recibido no este vacio
                    {
                        listadetalle[cd].Cantidad = items.Cantidad;
                    }
                    listadetalle[cd].PrecSubTotal = listadetalle[cd].Alim.Precio * listadetalle[cd].Cantidad;
                }
                else
                {
                    throw new ApplicationException("No se encontraron los datos a modificar");
                }
                return listadetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<PedidoDetalle> EliminarItemDetalle(List<PedidoDetalle> listadetalle, int idDetalle)
        {
            try
            {
                var ld = listadetalle.FindIndex(item => item.Id_Detalle == idDetalle); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (ld >= 0)
                {
                    listadetalle.RemoveAt(ld);
                }
                else
                {
                    throw new ApplicationException("No se encontraron los datos a eliminar");
                }
                return listadetalle;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
