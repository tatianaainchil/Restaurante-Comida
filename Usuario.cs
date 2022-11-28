using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Integrador_BurgerSix
{
   public class Usuario : Persona 
    {
        int id_Usuario;
        static int idGeneral;
        string nombreUsuario;
        string password;

        public int Id_Usuario { get => id_Usuario; }
        public string NombreUsuario => $"{Nombre}{Apellido}".Trim(); // concateno el nombre y el apellido para generar el nombre de usuario y le saco los espacios vacios al principio y final de la variable en caso de que tenga
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }
        public Usuario(string nom, string ape, string m, string d, string pass) : base(nom, ape, m, d)
        {
            idGeneral++; 
            id_Usuario = idGeneral;
            password = pass;
        }
        public List<Usuario> RegistrarUsuarios(Usuario objUsuario, List<Usuario> listaUsuario/*string nom, string ape, string m, string d, string pass*/)
        {
            try
            {
                if (String.IsNullOrEmpty(objUsuario.Nombre.Trim())) //valido que el campo nombre no este vacio
                {
                    throw new ApplicationException("Debe informar el Nombre de la persona que desea registrar");
                }
                if (String.IsNullOrEmpty(objUsuario.Apellido.Trim())) // valido que el campo apellido no este vacio
                {
                    throw new ApplicationException("Debe informar el Apellido de la persona que desea registrar");
                }
                if (String.IsNullOrEmpty(objUsuario.Password.Trim())) // valido qu ela password no este vacia
                {
                    throw new ApplicationException("Debe ingresar una password valida");
                }
                objUsuario.id_Usuario = Id_Usuario;
                objUsuario.nombreUsuario = NombreUsuario;
                listaUsuario.Add(objUsuario);

                return listaUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public static bool ValidarUsuario(List<Usuario> usuarios, string usuario, string pass)
        {
            try
            {
                var us = usuarios.Find(item => item.nombreUsuario == usuario && item.password == pass);
                if (us == null)
                {
                    throw new ApplicationException("Usuario/password incorrecto");
                }
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

    }
}
