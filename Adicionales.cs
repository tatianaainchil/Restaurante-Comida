using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    class Adicionales
    {
        string Nombre;
        float precio;
        //PRUEBA
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
        public float Precio // Propiedad
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
        //hasta aca
        public Adicionales(string nom, float prec)
        {
            Nombre = nom;
            precio = prec;
        }
        public double calcularAdicional(int preante)// preante= precio de la bebida seleccionada
        {
            var precioAdici = precio + preante;
            return precioAdici;
        }
    }
}
