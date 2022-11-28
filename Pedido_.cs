using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    public class Pedido_
    {
        public int nro_pedido;
        public static int idGeneral = 0000;
        public double Precio_Total { get; set; }
        public Cliente cliente { get; set; }
        public List<PedidoDetalle> detalle { get; set; }
        public int Nro_Pedido { get => nro_pedido; }
        public DateTime Fecha { get; set; }
        public Pedido_(Cliente cli, List<PedidoDetalle> listdetalle)
        {
            idGeneral++;
            nro_pedido = idGeneral;
            cliente = cli;
            detalle = listdetalle;
        }

        public List<Pedido_> AgregarPedido(Cliente cli, List<PedidoDetalle> det, List<Pedido_> listPedio, Pedido_ objPedido)
        {
            try
            {
                if (cli.Id_Cliente <= 0) //valido que el Id_Cliente no sea 0
                {
                    throw new ApplicationException("Debe informar un cliente valido.");
                }
                if (det.Count == 0)
                {
                    throw new ApplicationException("Para generar el pedido debe haber al menos un items.");
                }
                double Total = 0;
                objPedido.cliente = cli;
                objPedido.detalle = det;
                objPedido.Fecha = DateTime.Now;
                foreach (var d in det)
                {
                    if (d.IdPedido == 0)
                    {
                        d.IdPedido = nro_pedido;
                        Total = Total + d.PrecSubTotal;
                    }
                }
                objPedido.Precio_Total = Total;
                listPedio.Add(objPedido);

                return listPedio;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static (Pedido_, List<PedidoDetalle>) BuscarPedido(List<Pedido_> listaPedido, int id, Pedido_ objP/*, List<PedidoDetalle> listadet*/)
        {
            try
            {
                List<ListaDetalle> detPedi = new List<ListaDetalle>();
                List<PedidoDetalle> newdetPedi = new List<PedidoDetalle>();
                var lp = listaPedido.FindIndex(item => item.Nro_Pedido == id); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (lp >= 0)
                {
                    objP = listaPedido[lp];
                    var consulDetalleXid =
                    from det in listaPedido[lp].detalle
                    where det.IdPedido == id
                    select det;
                    foreach (var i in consulDetalleXid)
                    {
                        newdetPedi.Add(i);
                    }
                    //detPedi = ListaDetalle.CargarList(newdetPedi);
                }
                else
                {
                    throw new ApplicationException("Pedido no encontrado");
                }
                return (objP, newdetPedi);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<Pedido_> EliminarPedido(List<Pedido_> listaPedido, int id)
        {
            try
            {
                var lp = listaPedido.FindIndex(item => item.nro_pedido == id); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (lp >= 0)
                {
                    listaPedido.RemoveAt(lp);
                }

                else
                {
                    throw new ApplicationException("No se encontraron los datos a eliminar");
                }
                return listaPedido;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            /*Cantidad de pedidos vendidos*/
            //public static bool BuscarCliente(List<Cliente> cliente, string nombre, string dire) // valido que un cliente este registrado
            //{
            //    try
            //    {
            //        var cl = cliente.Find(item => item.Nombre == nombre && item.Direccion == dire); // busco por nombre y direccion
            //        if (cl == null)
            //        {
            //            throw new ApplicationException("Cliente no registrado");
            //        }
            //        return true;
            //    }
            //    catch (Exception ex)
            //    {
            //        throw ex;
            //    }
            //}


            //}

            //CrearPedido
            //ModificarPedido


        }
    }
}
