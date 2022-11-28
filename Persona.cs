using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
   public class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public Persona (string nom, string ape, string mail, string dire)
        {
            Nombre = nom;
            Apellido = ape;
            Correo = mail;
            Direccion = dire;
        }
    }
}
