using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
   public class ListaDetalle
    {
        private PedidoDetalle d;

        public int Id_Detalle { get { return d.Id_Detalle; } }
        public int Cantidad { get { return d.Cantidad; } }
        public string Tipo { get { return d.Alim.Tipo; } }
        public string Ingrediente { get { return d.Alim.Ingrediente; } }
        public double Precio { get { return d.Alim.Precio; } }
        public double PrecSubTotal { get { return d.PrecSubTotal; } }
        public ListaDetalle(PedidoDetalle detalle)
        {
            d = detalle;
        }
        public static List<ListaDetalle> CargarList(List<PedidoDetalle> listOriginal)
        {
            List<ListaDetalle> listNva = new List<ListaDetalle>();
            foreach (PedidoDetalle e in listOriginal)
                listNva.Add(new ListaDetalle(e));

            return listNva;
        }
    }
}
