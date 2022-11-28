using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
    class Tiket
    {
        string razonSocial = "Equipo SRL";
        string nombreFantasia = "Burguer Six";
        string cuit = "23-54876988-7";
        string direccion = "Zavaleta 204";
        string inicioActvidad = "02/09/21";
        public int idTicket = 1;

        public Pedido_ pedido { get; set; }
        public Tiket ticket { get; set; }

        public string RazonSocial { get { return razonSocial; } /*set { razonSocial = value; } */}
        public string NombreFantasia { get { return nombreFantasia; } /*set { nombreFantasia = value; }*/ }
        public string Cuit { get { return cuit; } /*set { cuit = value; }*/ }
        public string Direccion { get { return direccion; } /*set { direccion = value; } */}
        public string InicioActividad { get { return inicioActvidad; } /*set { inicioActvidad = value; } */}

        public Tiket(Pedido_ pedi)
        {
            pedido = pedi;
        }
    }
}
