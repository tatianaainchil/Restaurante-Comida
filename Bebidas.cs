using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    class Bebidas
    {
        string Nombre;
        double precio;
        public string nombre // Propiedad
        {
            get
            {
                return Nombre;
            }
            set
            {
                Nombre = value;
            }
        }
        public double Precio // Propiedad
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }
        public Bebidas(string nom, float prec)
        {
            Nombre = nom;
            precio = prec;
        }
        public double calcularAdicional(int preHambur)
        {
            var precioAdici = precio + preHambur;
            return precioAdici;
        }
    }
}
