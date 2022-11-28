using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp_Integrador_BurgerSix
{
    public partial class frmInicioSesion : Form
    {
        public List<Usuario> usuarios = new List<Usuario>();
        public frmInicioSesion(List<Usuario> lista_usuarios) // recibo por parametro la lista de usuarios registrados
        {
            InitializeComponent();
            usuarios.AddRange(lista_usuarios); // agrego los datos recibidos por parametro la lista usuario
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(txtUsuario.Text.Trim()))
                {
                    throw new ApplicationException("Usuario / Contraseña sin valor");
                }
                if (String.IsNullOrEmpty(txtContraseña.Text.Trim()))
                {
                    throw new ApplicationException("Usuario / Contraseña sin valor");
                }
                else
                {
                    if (Usuario.ValidarUsuario(usuarios, txtUsuario.Text, txtContraseña.Text))
                    {
                        //abre frm cargar pedidos
                        List<Cliente> clientes = new List<Cliente>();
                        frmInicio inicio = new frmInicio(/*clientes*/); // esto hay que sacar. solo esta a modo de prueba de codigo
                        inicio.Show();
                    }
                }
                this.Close();
            }
            catch(Exception ex)
            {
                txtContraseña.Text = "";
                txtUsuario.Text = "";
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmInicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogueo log = new frmLogueo();
            log.Close();
        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
