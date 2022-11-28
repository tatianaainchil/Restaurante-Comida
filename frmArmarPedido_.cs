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
    public partial class frmArmarPedido_ : Form
    {
        public Cliente Cli = new Cliente("", "", "", "", 0);
        public List<Cliente> listCliente = new List<Cliente>();
        public frmArmarPedido_(Cliente Cli_, List<Cliente> listCliente_)
        {
            Cli = Cli_;
            listCliente = listCliente_;
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

        List<Pedido_> listaPedido = new List<Pedido_>();
        public List<PedidoDetalle> listPedidoDet = new List<PedidoDetalle>();
        bool btnhambur = false;
        bool btnbebida = false;
        bool btnadici = false;

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                double totalPedido = 0;
                double precio;
                int cantidad;
                double totalprec;
                PedidoDetalle PedidoDet = new PedidoDetalle(0, ali);
                // valido que carge una hamburgesa si o si
                if (lblEleccionPedido.Text == "Elige tu hamburgesa" && nudCantidad.Value == 0)
                {
                    throw new ApplicationException("Debe agregar al menos 1 Hamburgesa la lista de pedidos");
                }
                if (btnhambur)
              // cargo la eleccion a la lista dependiendo que este cargando
                {
                    precio = double.Parse(txtPrecio.Text);
                    cantidad = Convert.ToInt16(nudCantidad.Value);
                    totalprec = cantidad * precio; // valor total de la hamburgesa
                    //cargo el precio total que va llevando hasta el momento
                    if (string.IsNullOrEmpty(lblTotal.Text))
                    {
                        totalPedido = totalPedido + totalprec + 0;
                    }
                    else
                    {
                        totalPedido = totalPedido + totalprec + double.Parse(lblTotal.Text);
                    }
                    lblTotal.Text = Convert.ToString(totalPedido);
                    //agrego un item al detalle pedido
                    var ali = new Alimento();
                    ali.Tipo = cmbTipo.Text;
                    ali.Ingrediente = cmbIngredientes.Text;
                    ali.Precio = precio;
                    listPedidoDet = PedidoDet.AgregarPedido(ali, listPedidoDet, PedidoDet, cantidad);
                }
                if (btnbebida)
                { // cargo la eleccion a la lista dependiendo que este cargando
                    precio = double.Parse(txtPrecio.Text);
                    cantidad = Convert.ToInt16(nudCantidad.Value);
                    totalprec = cantidad * precio;

                    var ali = new Alimento();
                    ali.Tipo = listaBebidas[cmbTipo.SelectedIndex].Tipo;
                    ali.Ingrediente = listaBebidas[cmbTipo.SelectedIndex].Ingrediente;
                    ali.Precio = listaBebidas[cmbTipo.SelectedIndex].Precio;

                    listPedidoDet = PedidoDet.AgregarPedido(ali, listPedidoDet, PedidoDet, cantidad);

                    if (string.IsNullOrEmpty(lblTotal.Text))
                    {
                        totalPedido = totalPedido + totalprec + 0;
                    }
                    else
                    {
                        totalPedido = totalPedido + totalprec + double.Parse(lblTotal.Text);
                    }
                    lblTotal.Text = Convert.ToString(totalPedido);
                }
                if (btnadici) // cargo la eleccion a la lista dependiendo que este cargando
                {
                    precio = double.Parse(txtPrecio.Text);
                    cantidad = Convert.ToInt16(nudCantidad.Value);
                    totalprec = cantidad * precio;

                    var ali = new Alimento();
                    ali.Tipo = listaAdi[clbAdicionales.SelectedIndex].Tipo;
                    ali.Ingrediente = clbAdicionales.Text;
                    ali.Precio = listaAdi[clbAdicionales.SelectedIndex].Precio;

                    listPedidoDet = PedidoDet.AgregarPedido(ali, listPedidoDet, PedidoDet, cantidad);

                    //cargo el precio total que va llevando hasta el momento
                    if (string.IsNullOrEmpty(lblTotal.Text))
                    {
                        totalPedido = totalPedido + totalprec + 0;
                    }
                    else
                    {
                        totalPedido = totalPedido + totalprec + double.Parse(lblTotal.Text);
                    }
                    lblTotal.Text = Convert.ToString(totalPedido);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPapasFritas_Click(object sender, EventArgs e)
        {
            btnadici = true;
            btnhambur = false;
            btnbebida = false;
            // una vez seleccionada la bebida, reutilizo el form y cargo las papas fritas
            lblEleccionPedido.Text = "Elige el adicional";
            txtPrecio.Text = "";
            cmbIngredientes.DataSource = null;
            cmbTipo.DataSource = null;
            nudCantidad.Value = 0;
            listaBebidas.Clear();
            listAli.Clear();
            listaHc.Clear();
            listaHp.Clear();
            listaHv.Clear();

            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            imgFondo.Visible = false;
            txtPrecio.Visible = true;
            nudCantidad.Visible = true;
            cmbTipo.Visible = false;
            cmbIngredientes.Visible = false;
            label7.Visible = true;
            label7.Location = new Point(202, 97);
            clbAdicionales.Visible = true;
            clbAdicionales.Location = new Point(182, 115);
            clbAderezos.Visible = true;
            clbAderezos.Location = new Point(352, 136);

            //Cargo adicionales
            ad = new Adicional("Papas fritas", 100, "Papas Chicas");
            listaAdi.Add(ad);
            ad = new Adicional("Papas fritas", 180, "Papas Mediana");
            listaAdi.Add(ad);
            ad = new Adicional("Papas fritas", 250, "Papas Grandes");
            listaAdi.Add(ad);
        }

        private void btnBebidas_Click(object sender, EventArgs e)
        {
            btnbebida = true;
            btnhambur = false;
            btnadici = false;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            imgFondo.Visible = false;
            txtPrecio.Visible = true;
            nudCantidad.Visible = true;
            cmbTipo.Visible = true;
            cmbIngredientes.Visible = true;
            label7.Visible = false;
            clbAdicionales.Visible = false;
            clbAderezos.Visible = false;
            // una vez seleccionada la hamburgesa, reutilizo el form y cargo las bebidas
            lblEleccionPedido.Text = "Elige la bebida";
            txtPrecio.Text = "";
            cmbIngredientes.DataSource = null;
            cmbTipo.DataSource = null;
            nudCantidad.Value = 0;
            listaAdi.Clear();
            listAli.Clear();
            listaHc.Clear();
            listaHp.Clear();
            listaHv.Clear();
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

        private void btnHambuegesa_Click(object sender, EventArgs e)
        {
            try
            {
                btnhambur = true;
                btnadici = false;
                btnbebida = false;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                imgFondo.Visible = false;
                txtPrecio.Visible = true;
                nudCantidad.Visible = true;
                cmbTipo.Visible = true;
                cmbIngredientes.Visible = true;
                label7.Visible = false;
                clbAdicionales.Visible = false;
                clbAderezos.Visible = false;

                listaAdi.Clear();
                listaBebidas.Clear();


                lblEleccionPedido.Text = "Elige tu hamburgesa";

                ali = new HamburgesaCarne("Hamburgesa de Carne", 0, "");
                listAli.Add(ali);
                ali = new HamburgesaCarne("Hamburgesa de Pollo", 0, "");
                listAli.Add(ali);
                ali = new HamburgesaCarne("Hamburgesa Vegetariana", 0, "");
                listAli.Add(ali);

                cmbTipo.DataSource = listAli;
                cmbTipo.DisplayMember = "Tipo";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void clbAdicionales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                if (listPedidoDet.Count >= 0)
                {
                    List<EncabezadoPedido> listaEncabezadoPedido = new List<EncabezadoPedido>();
                    Pedido_ objPedido = new Pedido_(Cli, listPedidoDet);
                    listaPedido = objPedido.AgregarPedido(Cli, listPedidoDet, listaPedido, objPedido);
                    listaEncabezadoPedido = EncabezadoPedido.CargarListPedido(listaPedido);
                    dgvModificarPedido.DataSource = null;
                    dgvModificarPedido.DataSource = listaEncabezadoPedido;
                    Form frmArmarPedido_ = new frmImpresora(listaPedido, objPedido.nro_pedido);
                    frmArmarPedido_.ShowDialog();

                    MostrarImagen();
                    lblTotal.Text = "0";
                    // agregar imprimir
                }
                else
                {
                    throw new ApplicationException("Debe agregar al menos 1 item al pedido");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void cmbIngredientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblEleccionPedido.Text == "Elige tu hamburgesa")
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
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lblEleccionPedido.Text == "Elige tu hamburgesa")
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
                if (lblEleccionPedido.Text == "Elige la bebida")
                {
                    if (cmbTipo.SelectedIndex >= 0)
                    {
                        cmbIngredientes.Text = listaBebidas[cmbTipo.SelectedIndex].Ingrediente;
                        txtPrecio.Text = Convert.ToString(listaBebidas[cmbTipo.SelectedIndex].Precio);
                        listaAdi.Clear();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmArmarPedido__Load(object sender, EventArgs e)
        {
            lblEleccionPedido.Text = "Carga de Detalle del Pedido";
            lblCliente.Text = Cli.Nombre;
            MostrarImagen();

        }
        void MostrarImagen()
        {
            imgFondo.Visible = true;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            txtPrecio.Visible = false;
            nudCantidad.Visible = false;
            cmbTipo.Visible = false;
            cmbIngredientes.Visible = false;
            label7.Visible = false;
            clbAdicionales.Visible = false;
            clbAderezos.Visible = false;
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            frmCliente_ cli = new frmCliente_();
            cli.dgvClientes.DataSource = listCliente;
            cli.Show();
        }

        private void dgvModificarPedido_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                var index = dgvModificarPedido.CurrentRow.Index;
                if (e.KeyCode == Keys.Delete)
                {
                    List<EncabezadoPedido> listaEncabezadoPedido = new List<EncabezadoPedido>();
                    int id = (int)dgvModificarPedido.Rows[index].Cells["Nro_Pedido"].Value;
                    listaPedido = Pedido_.EliminarPedido(listaPedido, id);
                    listaEncabezadoPedido = EncabezadoPedido.CargarListPedido(listaPedido);
                    dgvModificarPedido.DataSource = null;
                    dgvModificarPedido.DataSource = listaEncabezadoPedido;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvModificarPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var index = dgvModificarPedido.CurrentRow.Index;
                int id = Convert.ToInt32(dgvModificarPedido.Rows[index].Cells["Nro_Pedido"].Value);
                Pedido_ objPedido = new Pedido_(Cli, listPedidoDet);
                List<ListaDetalle> listDet = new List<ListaDetalle>();
                (objPedido, listPedidoDet) = Pedido_.BuscarPedido(listaPedido, id, objPedido);
                listDet = ListaDetalle.CargarList(listPedidoDet);
                frmDetallePedido detalle = new frmDetallePedido(listPedidoDet, id, Cli.Nombre);// lista original
                detalle.dgvDetallePedido.DataSource = null;
                detalle.dgvDetallePedido.DataSource = listDet; // lista separada(sin objeto para cargar la grila)
                detalle.lblCliente.Text = listaPedido[index].cliente.Nombre;
                detalle.lblId_Pedido.Text = Convert.ToString(listaPedido[index].Nro_Pedido);
                detalle.lblFecha.Text = Convert.ToString(listaPedido[index].Fecha);
                detalle.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
