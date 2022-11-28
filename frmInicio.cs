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
    public partial class frmInicio : Form
    {
        public List<Cliente> listaCliente = new List<Cliente>();
        Cliente cli = new Cliente("", "", "", "", 0);
     
        public frmInicio(/*List<Cliente> listClientes*/)
        { 
            InitializeComponent();
            //frmModificarCliente modifCliente = new frmModificarCliente(/*listaCliente*/);
            //modifCliente.dgvClientes.DataSource = listaCliente;
            //int i = listaCliente.Count();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente_ cliente = new frmCliente_();
            cliente.dgvClientes.DataSource = listaCliente;
            cliente.Show();
            
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArmarPedido_ pedido_ = new frmArmarPedido_(cli,listaCliente);
            pedido_.Show();
        }
    }
}
