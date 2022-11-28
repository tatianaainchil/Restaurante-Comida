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
    public partial class popupModificarItems : Form
    {
        public List<Pedido_> listaPedido = new List<Pedido_>();
        public List<PedidoDetalle> listPedidoDet = new List<PedidoDetalle>();
        int id;
        public popupModificarItems(List<PedidoDetalle> listDet_, int id_)
        {
            listPedidoDet.AddRange(listDet_);
            id = id_;
            InitializeComponent();
        }
        List<HamburgesaCarne> listaHc = new List<HamburgesaCarne>();
        List<HamburgesaPollo> listaHp = new List<HamburgesaPollo>();
        List<HamburgesaVegetariana> listaHv = new List<HamburgesaVegetariana>();
        List<Adicional> listaAdi = new List<Adicional>();
        List<Bebida> listaBebidas = new List<Bebida>();
        List<ListaDetalle> listDetalle = new List<ListaDetalle>();
        List<Alimento> listAli = new List<Alimento>();
        Adicional ad = new Adicional("", 0, "");
        Bebida bebida = new Bebida("", 0, "");
        Alimento ali = new Alimento();

        Cliente cli = new Cliente("", "", "", "", 0);
        private void popupModificarItems_Load(object sender, EventArgs e)
        {
            foreach (var det in listPedidoDet)
            {
                if (det.Id_Detalle==id)
                {
                    lblCliente.Text = cli.Nombre;
                    if (det.Alim.Tipo== "Papas fritas")
                    {
                        label4.Visible = true;
                        label3.Visible = true;
                        label5.Visible = false;
                        label6.Visible = false;
                        txtPrecio.Visible = true;
                        nudCantidad.Visible = true;
                        cmbTipo.Visible = false;
                        cmbIngredientes.Visible = false;
                        label7.Visible = true;
                        label7.Location = new Point(381, 151);
                        clbAdicionales.Visible = true;
                        clbAdicionales.Location = new Point(362, 181);
                        clbAderezos.Visible = true;
                        clbAderezos.Location = new Point(532, 181);
                        //Cargo adicionales
                        ad = new Adicional("Papas fritas", 100, "Papas Chicas");
                        listaAdi.Add(ad);
                        ad = new Adicional("Papas fritas", 180, "Papas Mediana");
                        listaAdi.Add(ad);
                        ad = new Adicional("Papas fritas", 250, "Papas Grandes");
                        listaAdi.Add(ad);
                        clbAdicionales.SelectedItem = det.Alim.Ingrediente;
                        txtPrecio.Text = Convert.ToString(det.Alim.Precio);
                        nudCantidad.Value = det.Cantidad;
                    }
                    else
                    {
                        cmbTipo.Text = det.Alim.Tipo;
                        cmbIngredientes.Text = det.Alim.Ingrediente;
                        txtPrecio.Text = Convert.ToString(det.Alim.Precio);
                        nudCantidad.Value = det.Cantidad;
                        if (det.Alim.Tipo == "Agua sin gas" || det.Alim.Tipo == "Agua con gas" || det.Alim.Tipo == "Pepsi" || det.Alim.Tipo == "Sprite")
                        {
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            txtPrecio.Visible = true;
                            nudCantidad.Visible = true;
                            cmbTipo.Visible = true;
                            cmbIngredientes.Visible = true;
                            label7.Visible = false;
                            clbAdicionales.Visible = false;
                            clbAderezos.Visible = false;
                            //Cargo bebidas
                            bebida = new Bebida("Agua sin gas", 150, "Agua Mineral");
                            listaBebidas.Add(bebida);
                            bebida = new Bebida("Agua con gas", 180, "Agua Saborizada con gas");
                            listaBebidas.Add(bebida);
                            bebida = new Bebida("Pepsi", 250, "Gaseosa");
                            listaBebidas.Add(bebida);
                            bebida = new Bebida("Sprite", 260, "Gaseosa");
                            listaBebidas.Add(bebida);
                            cmbTipo.DataSource = listaBebidas;
                            cmbTipo.DisplayMember = "Tipo";
                        }
                        if (det.Alim.Tipo == "Hamburgesa de Carne" || det.Alim.Tipo == "Hamburgesa de Pollo" || det.Alim.Tipo == "Hamburgesa Vegetariana")
                        {
                            label3.Visible = true;
                            label4.Visible = true;
                            label5.Visible = true;
                            label6.Visible = true;
                            txtPrecio.Visible = true;
                            nudCantidad.Visible = true;
                            cmbTipo.Visible = true;
                            cmbIngredientes.Visible = true;
                            label7.Visible = false;
                            clbAdicionales.Visible = false;
                            clbAderezos.Visible = false;
                            ali = new HamburgesaCarne("Hamburgesa de Carne", 0, "");
                            listAli.Add(ali);
                            ali = new HamburgesaCarne("Hamburgesa de Pollo", 0, "");
                            listAli.Add(ali);
                            ali = new HamburgesaCarne("Hamburgesa Vegetariana", 0, "");
                            listAli.Add(ali);

                            cmbTipo.DataSource = listAli;
                            cmbTipo.DisplayMember = "Tipo";
                        }
                    }
                    
                }
            }

        }
        private void clbAdicionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int inde = clbAdicionales.SelectedIndex;
            int inde2 = clbAdicionales.Items.Count;
            for (int x = 0; x < inde2; x++)
            {
                if (inde != x)
                {
                    clbAdicionales.SetItemCheckState(x, CheckState.Unchecked);
                }
            }
            txtPrecio.Text = Convert.ToString(listaAdi[clbAdicionales.SelectedIndex].Precio);
        }
        private void cmbIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAli.Count!=0)
            {
                if (cmbTipo.SelectedIndex == 0)
                {
                    txtPrecio.Text = Convert.ToString(listaHc[cmbIngredientes.SelectedIndex].Precio);
                }
                else if (cmbTipo.SelectedIndex == 1)
                {
                    txtPrecio.Text = Convert.ToString(listaHp[cmbIngredientes.SelectedIndex].Precio);
                }
                else if (cmbTipo.SelectedIndex == 2)
                {
                    txtPrecio.Text = Convert.ToString(listaHv[cmbIngredientes.SelectedIndex].Precio);
                }
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listAli.Count!=0)
            {
                //cmbIngredientes.Text = "";
                if (cmbTipo.SelectedIndex == 0) // si la habmurgesa es de carne
                {
                    var Hamburguesa = new HamburgesaCarne("medallon de carne", 900, "lechuga, tomate y carne");
                    listaHc.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaCarne("medallon de carne", 1500, "tomate,queso,cebolla y 2 medallones de  carne");
                    listaHc.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaCarne("medallon de carne", 1800, "panceta,queso y 3 medallones de  carne");
                    listaHc.Add(Hamburguesa);

                    cmbIngredientes.DataSource = listaHc;
                    cmbIngredientes.DisplayMember = "Ingrediente";
                }
                else if (cmbTipo.SelectedIndex == 1) // si la habmurgesa es de pollo)
                {
                    var Hamburguesa = new HamburgesaPollo("medallon de pollo", 1200, "Pechuga de pollo a la plancha, tomate, lechuga y mostaza");
                    listaHp.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaPollo("medallon de pollo", 1300, "filet de pollo rebozado, lechuga, tomate y mayonesa");
                    listaHp.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaPollo("medallon de pollo", 1000, "Medallon de pollo, cebolla caramelizada y tomate");
                    listaHp.Add(Hamburguesa);

                    cmbIngredientes.DataSource = listaHp;
                    cmbIngredientes.DisplayMember = "Ingrediente";
                }
                else if (cmbTipo.SelectedIndex == 2) // si la habmurgesa es vegeteariana
                {
                    var Hamburguesa = new HamburgesaVegetariana("medallon vegetariano", 850, "Hamburguesa de tofu con lechuga,tomate y ketchup");
                    listaHv.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaVegetariana("medallon vegetariano", 1100, "Hamburguesa de garbanzos y calabaza con tomate y champiñon");
                    listaHv.Add(Hamburguesa);
                    Hamburguesa = new HamburgesaVegetariana("medallon vegatariano", 900, "Hamburguesa de lentejas y arroz yamani con lechuga y tomate");
                    listaHv.Add(Hamburguesa);
                    cmbIngredientes.DataSource = listaHv;
                    cmbIngredientes.DisplayMember = "Ingrediente";
                }
                listaBebidas.Clear();
            }
            if (listaAdi.Count!=0)
            {
                if (cmbTipo.SelectedIndex >= 0)
                {
                    cmbIngredientes.Text = listaBebidas[cmbTipo.SelectedIndex].Ingrediente;
                    txtPrecio.Text = Convert.ToString(listaBebidas[cmbTipo.SelectedIndex].Precio);
                    listaAdi.Clear();
                }
            }
        }

        private void btnModificarItems_Click(object sender, EventArgs e)
        { 
            var ali = new Alimento();
            Pedido_ objPedido = new Pedido_(cli, listPedidoDet);
            PedidoDetalle items = new PedidoDetalle(0, ali);
            if (listAli.Count != 0)
            {
                ali.Tipo = cmbTipo.Text;
                ali.Ingrediente = cmbIngredientes.Text;
                ali.Precio = Convert.ToDouble(txtPrecio.Text);
                items.Cantidad = (int)nudCantidad.Value;
                items.Id_Detalle = id;
            }
            if (listaBebidas.Count != 0)
            {
                ali.Tipo = listaBebidas[cmbTipo.SelectedIndex].Tipo;
                ali.Ingrediente = listaBebidas[cmbTipo.SelectedIndex].Ingrediente;
                ali.Precio = listaBebidas[cmbTipo.SelectedIndex].Precio;
                items.Cantidad = (int)nudCantidad.Value;
                items.Id_Detalle = id;
            }
            if (listaAdi.Count != 0) // cargo la eleccion a la lista dependiendo que este cargando
            {
                ali.Tipo = listaAdi[clbAdicionales.SelectedIndex].Tipo;
                ali.Ingrediente = clbAdicionales.Text;
                ali.Precio = listaAdi[clbAdicionales.SelectedIndex].Precio;
                items.Cantidad = (int)nudCantidad.Value;
                items.Id_Detalle = id;
            }
            listPedidoDet = PedidoDetalle.Modificaritemspedido(listPedidoDet,id,items);
            frmDetallePedido detPed = new frmDetallePedido(listPedidoDet,Convert.ToInt32(lblIdPedido.Text),lblCliente.Text);
            detPed.dgvDetallePedido.DataSource = listPedidoDet;
            this.Close();
        }
    }
}
