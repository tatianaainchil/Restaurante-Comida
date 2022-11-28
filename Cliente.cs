using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
   public class Cliente: Persona
    {
        int id_Cliente;
        static int idGeneral;
        public long Telefono { get; set; }
        public int Id_Cliente { get => id_Cliente; }
        
        public Cliente(string nom, string ape, string m, string d, long tel) : base(nom, ape, m, d)
        {
            idGeneral++;
            id_Cliente = idGeneral;
            Telefono = tel;
        }
        public List<Cliente> RegistrarCliente(Cliente objCliente, List<Cliente> listaCliente)
        {
            try
            {
                if (String.IsNullOrEmpty(objCliente.Direccion.Trim())) //valido que el campo Direccion no este vacio
                {
                    throw new ApplicationException("Debe informar la dirección de la persona.");
                }
                if (objCliente.Telefono==0) // valido que el campo telefono no este vacio
                {
                    throw new ApplicationException("Debe informar el Telefono de la persona.");
                }
                if (String.IsNullOrEmpty(objCliente.Nombre.Trim())) // valido que el campo Nombre no este vacio
                {
                    throw new ApplicationException("Debe informar el Nombre de la persona.");
                }
                if (String.IsNullOrEmpty(objCliente.Apellido.Trim())) // valido que el campo Apellido no este vacio
                {
                    throw new ApplicationException("Debe informar el Apellido de la persona.");
                }

                objCliente.id_Cliente = Id_Cliente;
                listaCliente.Add(objCliente);

                return listaCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public Persona BuscarCliente(List<Cliente> cliente,Cliente cli, string nombre) // valido que un cliente este registrado
        {
            try
            {
                int cl = cliente.FindIndex(item => item.Nombre == nombre ); // busco por nombre
              
                if (cl>= 0)
                {
                    cli.id_Cliente = cliente[cl].id_Cliente;
                    cli.Nombre= cliente[cl].Nombre;
                    cli.Apellido= cliente[cl].Apellido;
                    cli.Direccion = cliente[cl].Direccion;
                    cli.Correo = cliente[cl].Correo;
                    cli.Telefono = cliente[cl].Telefono;
                }
                else
                {
                    throw new ApplicationException("Cliente no registrado");
                }
                return cli;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public static List<Cliente> ModificarDatos(List<Cliente> listaCliente, int id, long tel, string dire)
        {
            try
            {
                var cl = listaCliente.FindIndex(item => item.id_Cliente == id); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (cl >= 0)
                {
                    if (!String.IsNullOrEmpty(dire.Trim())) //compruebo que el parametro recibido no este vacio
                    {
                        listaCliente[cl].Direccion = dire;
                    }
                    if (tel > 0) //compruebo que el parametro recibido no este vacio
                    {
                        listaCliente[cl].Telefono = tel;
                    }
                }
                else
                {
                    throw new ApplicationException("No se encontraron los datos a modificar");
                }
                return listaCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static List<Cliente> EliminarCliente(List<Cliente> listaCliente, int id)
        {
            try
            {
                var cl = listaCliente.FindIndex(item => item.id_Cliente == id); // guardo el indice que tiene busqueda, mientras que coincida con los valores
                if (cl >= 0)
                {
                    listaCliente.RemoveAt(cl);
                }
                else
                {
                    throw new ApplicationException("No se encontraron los datos a modificar");
                }
                return listaCliente;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}
