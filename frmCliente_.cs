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
    public partial class frmCliente_ : Form
    {
        public frmCliente_()
        {
            InitializeComponent();
        }
        public List<Cliente> ListaCliente = new List<Cliente>();
        
        int Fila = 0;
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) // solo permite que se ingrese numeros 
            {
                e.Handled = true;
            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "CARGAR CLIENTES";
            pbImagenCliente.Image = Tp_Integrador_BurgerSix.Properties.Resources.Agregar_persona;

            if (ListaCliente.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.Visible = true;
            }
            Habilitartxt();
            Limpiartxt();
            gbDatos.Visible = true;
            //gbGrillaClientes.Visible = true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (lblTitulo.Text == "CARGAR CLIENTES")
            {
                try
                {
                    Cliente objCli = new Cliente("", "", "", "", 0) // cargo el objeto cliente con todos los valores de los texbox
                    {
                        Apellido = txtApellido.Text,
                        Nombre = txtNombre.Text,
                        Direccion = txtDireccion.Text,
                        Correo = txtEmail.Text,
                        Telefono = long.Parse(txtTelefono.Text)
                    };
                    ListaCliente = objCli.RegistrarCliente(objCli, ListaCliente);
                    Limpiartxt();
                    gbDatos.Visible = true;
                    //gbGrillaClientes.Visible = true;
                    dgvClientes.Visible = true;
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = ListaCliente;
                    MessageBox.Show("Cliente : " + objCli.Nombre + " Registrado con Exito", "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    List<Cliente> clientes = ListaCliente;
                    frmArmarPedido_ pedidos = new frmArmarPedido_(objCli, clientes);
                    // llamar a cargar pedido

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            if (lblTitulo.Text == "MODIFICAR CLIENTES")
            {
                try
                {
                    if (string.IsNullOrEmpty(txtDireccion.Text))
                    {
                        txtDireccion.Focus();
                        throw new ApplicationException("No puede dejar valores vacios");
                    }
                    if ((string.IsNullOrEmpty(txtTelefono.Text)))
                    {
                        txtTelefono.Focus();
                        throw new ApplicationException("No puede dejar valores vacios");
                    }
                    else
                    {
                        var tel = long.Parse(txtTelefono.Text);
                        var id = int.Parse(lblID.Text);
                        Cliente.ModificarDatos(ListaCliente, id, tel, txtDireccion.Text);
                        dgvClientes.DataSource = null;
                        dgvClientes.DataSource = ListaCliente;
                        MessageBox.Show("Cliente : " + txtNombre.Text + " Modificado con Exito", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            if (lblTitulo.Text == "ELIMINAR CLIENTES")
            {
                try
                {
                    var id = int.Parse(lblID.Text);
                    Cliente.EliminarCliente(ListaCliente, id);
                    dgvClientes.DataSource = null;
                    dgvClientes.DataSource = ListaCliente;
                    Limpiartxt();
                    MessageBox.Show("Cliente : " + txtNombre.Text + " Eliminado con Exito", "Modificacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
    

        private void btnMidificarCliente_Click(object sender, EventArgs e)
        {
            Habilitartxt();
            Limpiartxt();
            lblTitulo.Text = "MODIFICAR CLIENTES";
            pbImagenCliente.Image = Tp_Integrador_BurgerSix.Properties.Resources.Modificar_persona;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;


            if (ListaCliente.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.DataSource = ListaCliente;
                dgvClientes.Visible = true;
            }
            
            gbDatos.Visible = true;
           // gbGrillaClientes.Visible = true;
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (lblTitulo.Text == "MODIFICAR CLIENTES" || lblTitulo.Text == "ELIMINAR CLIENTES")
            {
                Fila = dgvClientes.CurrentRow.Index;
                txtNombre.Text = dgvClientes.Rows[Fila].Cells["Nombre"].Value.ToString();
                txtApellido.Text = dgvClientes.Rows[Fila].Cells["Apellido"].Value.ToString();
                txtEmail.Text = dgvClientes.Rows[Fila].Cells["Correo"].Value.ToString();
                txtTelefono.Text = dgvClientes.Rows[Fila].Cells["Telefono"].Value.ToString();
                txtDireccion.Text = dgvClientes.Rows[Fila].Cells["Direccion"].Value.ToString();
                lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
            }

        }
        void Limpiartxt() // limpio todos los texbox cuando se registra un usuario
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
        }
        void Habilitartxt()
        {
            txtApellido.Enabled = true;
            txtNombre.Enabled = true;
            txtEmail.Enabled = true;
            txtDireccion.Enabled = true;
            txtTelefono.Enabled = true;
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            lblTitulo.Text = "ELIMINAR CLIENTES";
            Limpiartxt();
            pbImagenCliente.Image = Tp_Integrador_BurgerSix.Properties.Resources.Eliminar_persona;
            txtApellido.Enabled = false;
            txtNombre.Enabled = false;
            txtEmail.Enabled = false;
            txtDireccion.Enabled = false;
            txtTelefono.Enabled = false;
           
            if (ListaCliente.Count == 0)
            {
                dgvClientes.Visible = false;
            }
            else
            {
                dgvClientes.DataSource = ListaCliente;
                dgvClientes.Visible = true;
            }
            gbDatos.Visible = true;
            //gbGrillaClientes.Visible = true;
        }

        private void dgvClientes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Cliente cli_ = new Cliente("", "", "", "", 0);
            Fila = dgvClientes.CurrentRow.Index;
            cli_.Nombre = dgvClientes.Rows[Fila].Cells["Nombre"].Value.ToString();
            cli_.Apellido = dgvClientes.Rows[Fila].Cells["Apellido"].Value.ToString();
            cli_.Correo = dgvClientes.Rows[Fila].Cells["Correo"].Value.ToString();
            cli_.Telefono = (long)dgvClientes.Rows[Fila].Cells["Telefono"].Value;
            cli_.Direccion = dgvClientes.Rows[Fila].Cells["Direccion"].Value.ToString();
            lblID.Text = dgvClientes.Rows[Fila].Cells["ID_Cliente"].Value.ToString();
            frmArmarPedido_ pedido_ = new frmArmarPedido_(cli_,ListaCliente);
            pedido_.Cli = cli_; // paso los valores de la lista cliente a el frmInicio
            pedido_.Show();
            this.Hide();
        }
    }
}
