using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    class EncabezadoPedido
    {
        private Pedido_ p;
        public int Nro_Pedido { get { return p.Nro_Pedido; } }
        public DateTime Fecha { get { return p.Fecha; } }
        public string Nombre { get { return p.cliente.Nombre; } }
        public string Apellido { get { return p.cliente.Apellido; } }
        public string Direccion { get { return p.cliente.Direccion; } }
        public double Precio_Total { get { return p.Precio_Total; } }
        public List<PedidoDetalle> detalle { get { return p.detalle; } }
        public EncabezadoPedido(Pedido_ pedido)
        {
            p = pedido;
        }
        public static List<EncabezadoPedido> CargarListPedido(List<Pedido_> listOriginal)
        {
            List<EncabezadoPedido> listNva = new List<EncabezadoPedido>();
            foreach (Pedido_ e in listOriginal)
                listNva.Add(new EncabezadoPedido(e));

            return listNva;
        }
    }
}
