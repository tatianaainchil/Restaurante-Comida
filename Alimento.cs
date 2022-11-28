using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    public class Alimento
    {
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public string Ingrediente { get; set; }
        //public Alimento(string ti, double pre, string ing)
        //{
        //    Tipo = ti;
        //    Precio = pre;
        //    Ingrediente = ing;
        //}
    }
    public class HamburgesaPollo : Alimento
    {
            public HamburgesaPollo(string ti, double pre, string ing)/*:base(ti,pre,ing)*/
            {
                Tipo = ti;
                Precio = pre;
                Ingrediente = ing;
            }

        }
        public class HamburgesaCarne : Alimento
        {
            public HamburgesaCarne(string ti, double pre, string ing) /*: base(ti, pre, ing)*/
        {
                Tipo = ti;
                Precio = pre;
                Ingrediente = ing;
            }

        }
        public class HamburgesaVegetariana : Alimento
        {
            public HamburgesaVegetariana(string ti, double pre, string ing) /*: base(ti, pre, ing)*/
        {
                Tipo = ti;
                Precio = pre;
                Ingrediente = ing;
            }

        }
    public class Adicional : Alimento
    {
        public Adicional(string ti, double pre, string ing) /*: base(ti, pre, ing)*/
        {
            Tipo = ti;
            Precio = pre;
            Ingrediente = ing;
        }

    }
    public class Bebida : Alimento
    {
        public Bebida(string ti, double pre, string ing) /*: base(ti, pre, ing)*/
        {
            Tipo = ti;
            Precio = pre;
            Ingrediente = ing;
        }

    }

    //public class Alimento
    //{
    //    public string Tipo { get; set; }
    //    public double Precio { get; set; }
    //    public string Ingrediente { get; set; }
    //}
}
   

