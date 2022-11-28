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
    public partial class frmDetallePedido : Form
    {
        public List<PedidoDetalle> detalle_ = new List<PedidoDetalle>();
        public Cliente Cli = new Cliente("", "", "", "", 0);
        public int idPedido;
        public string NomCli;
        public frmDetallePedido(List<PedidoDetalle> detalle, int idPedido_, string NomCliente_/*, Pedido_ objped*/)
        {
            detalle_.AddRange(detalle);
            idPedido = idPedido_;
            NomCli = NomCliente_;

            InitializeComponent();
            dgvDetallePedido.DataSource = null;
            dgvDetallePedido.DataSource = detalle_;
        }
        Alimento ali = new Alimento();
        private void dgvDetallePedido_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                var index = dgvDetallePedido.CurrentRow.Index;
            if (e.KeyCode == Keys.Delete)
            {
                int id= (int)dgvDetallePedido.Rows[index].Cells["Id_Detalle"].Value;
                detalle_ = PedidoDetalle.EliminarItemDetalle(detalle_, id);
                    List<ListaDetalle> listDet = new List<ListaDetalle>();
                    listDet = ListaDetalle.CargarList(detalle_);

                    dgvDetallePedido.DataSource = null;
                    dgvDetallePedido.DataSource = listDet;
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDetallePedido_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = dgvDetallePedido.CurrentRow.Index;
                PedidoDetalle det = new PedidoDetalle(0, ali);
                int id = (int)dgvDetallePedido.Rows[index].Cells["Id_Detalle"].Value;
                popupModificarItems modificarItems = new popupModificarItems(detalle_,id);
                modificarItems.lblCliente.Text = NomCli;
                modificarItems.lblIdPedido.Text = Convert.ToString(idPedido);
                modificarItems.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

            //si funciona llamar a la carga de producto para modificar el item
        }
    }
}
