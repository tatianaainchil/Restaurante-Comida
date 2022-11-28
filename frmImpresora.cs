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
    public partial class frmImpresora : Form
    {
        List<Tiket> TPedidos = new List<Tiket>();
        List<PedidoDetalle> listdetalle = new List<PedidoDetalle>();
        List<Cliente> Cliente = new List<Cliente>();
        public Cliente cliente = new Cliente("", "", "", "", 0);
        public List<Pedido_> listPedido = new List<Pedido_>();
        public int id_Pedido;
        public frmImpresora(List<Pedido_> listPedido_, int id)

        {
            listPedido.AddRange(listPedido_);
            id_Pedido = id;
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listPedido.Count != 0)
            {
                foreach (var ped in listPedido)
                {
                    if (ped.Nro_Pedido == id_Pedido)
                    {
                        var ticket = new Tiket(ped);
                        var impresora = new Impresora();
                        impresora.imprimir(ticket);
                    }
                }
            }
            this.Close();
        }

        private void frmImpresora_Load(object sender, EventArgs e)
        {
            if (listPedido.Count != 0)
            {
                foreach (var ped in listPedido)
                {
                    if (ped.Nro_Pedido == id_Pedido)
                    {
                        var ticket = new Tiket(ped);

                        textBox2.Text = ticket.RazonSocial;
                        textBox3.Text = ticket.Direccion;
                        textBox4.Text = ticket.InicioActividad;
                        textBox6.Text = ticket.Cuit;
                        label9.Text = ticket.pedido.cliente.Nombre;
                        textBox1.Text = Convert.ToString(ticket.pedido.Precio_Total);
                    }
                }
            }
        }
    }
}
