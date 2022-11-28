
namespace Tp_Integrador_BurgerSix
{
    partial class frmArmarPedido_
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArmarPedido_));
            this.pnlizquierda = new System.Windows.Forms.Panel();
            this.btnBebidas = new System.Windows.Forms.Button();
            this.btnPapasFritas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHambuegesa = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlAriba = new System.Windows.Forms.Panel();
            this.btnNuevoPedido = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlabajo = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnlcentro = new System.Windows.Forms.Panel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvModificarPedido = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblEleccionPedido = new System.Windows.Forms.Label();
            this.clbAdicionales = new System.Windows.Forms.CheckedListBox();
            this.clbAderezos = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.imgFondo = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pnlizquierda.SuspendLayout();
            this.pnlAriba.SuspendLayout();
            this.pnlabajo.SuspendLayout();
            this.pnlcentro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPedido)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlizquierda
            // 
            this.pnlizquierda.BackColor = System.Drawing.Color.Maroon;
            this.pnlizquierda.Controls.Add(this.btnBebidas);
            this.pnlizquierda.Controls.Add(this.btnPapasFritas);
            this.pnlizquierda.Controls.Add(this.groupBox1);
            this.pnlizquierda.Controls.Add(this.btnHambuegesa);
            this.pnlizquierda.Controls.Add(this.label2);
            this.pnlizquierda.Controls.Add(this.label1);
            this.pnlizquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlizquierda.Location = new System.Drawing.Point(0, 0);
            this.pnlizquierda.Name = "pnlizquierda";
            this.pnlizquierda.Size = new System.Drawing.Size(186, 493);
            this.pnlizquierda.TabIndex = 0;
            // 
            // btnBebidas
            // 
            this.btnBebidas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBebidas.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBebidas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBebidas.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.refresco;
            this.btnBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBebidas.Location = new System.Drawing.Point(5, 299);
            this.btnBebidas.Name = "btnBebidas";
            this.btnBebidas.Size = new System.Drawing.Size(175, 67);
            this.btnBebidas.TabIndex = 3;
            this.btnBebidas.Text = "Bebidas";
            this.btnBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBebidas.UseVisualStyleBackColor = true;
            this.btnBebidas.Click += new System.EventHandler(this.btnBebidas_Click);
            // 
            // btnPapasFritas
            // 
            this.btnPapasFritas.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnPapasFritas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapasFritas.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapasFritas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPapasFritas.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.icons8_papas_fritas_80;
            this.btnPapasFritas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPapasFritas.Location = new System.Drawing.Point(5, 192);
            this.btnPapasFritas.Name = "btnPapasFritas";
            this.btnPapasFritas.Size = new System.Drawing.Size(175, 101);
            this.btnPapasFritas.TabIndex = 2;
            this.btnPapasFritas.Text = "Papas Fritas";
            this.btnPapasFritas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPapasFritas.UseVisualStyleBackColor = true;
            this.btnPapasFritas.Click += new System.EventHandler(this.btnPapasFritas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(-3, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(189, 10);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnHambuegesa
            // 
            this.btnHambuegesa.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnHambuegesa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHambuegesa.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHambuegesa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHambuegesa.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.hamburguesa__2_;
            this.btnHambuegesa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHambuegesa.Location = new System.Drawing.Point(5, 108);
            this.btnHambuegesa.Name = "btnHambuegesa";
            this.btnHambuegesa.Size = new System.Drawing.Size(175, 92);
            this.btnHambuegesa.TabIndex = 0;
            this.btnHambuegesa.Text = "Hamburgesa";
            this.btnHambuegesa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHambuegesa.UseVisualStyleBackColor = true;
            this.btnHambuegesa.Click += new System.EventHandler(this.btnHambuegesa_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(70, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "SIX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(37, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Burger";
            // 
            // pnlAriba
            // 
            this.pnlAriba.BackColor = System.Drawing.Color.Coral;
            this.pnlAriba.Controls.Add(this.btnNuevoPedido);
            this.pnlAriba.Controls.Add(this.lblCliente);
            this.pnlAriba.Controls.Add(this.label12);
            this.pnlAriba.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlAriba.Location = new System.Drawing.Point(186, 0);
            this.pnlAriba.Name = "pnlAriba";
            this.pnlAriba.Size = new System.Drawing.Size(695, 64);
            this.pnlAriba.TabIndex = 1;
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.BackColor = System.Drawing.Color.Coral;
            this.btnNuevoPedido.FlatAppearance.BorderSize = 2;
            this.btnNuevoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPedido.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnNuevoPedido.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.hamburguesa__1_1;
            this.btnNuevoPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPedido.Location = new System.Drawing.Point(427, 9);
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(146, 46);
            this.btnNuevoPedido.TabIndex = 4;
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoPedido.UseVisualStyleBackColor = false;
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblCliente.Location = new System.Drawing.Point(579, 34);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(101, 24);
            this.lblCliente.TabIndex = 44;
            this.lblCliente.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(579, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 24);
            this.label12.TabIndex = 43;
            this.label12.Text = "Cliente";
            // 
            // pnlabajo
            // 
            this.pnlabajo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlabajo.Controls.Add(this.lblTotal);
            this.pnlabajo.Controls.Add(this.btnPagar);
            this.pnlabajo.Controls.Add(this.btnAgregar);
            this.pnlabajo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlabajo.Location = new System.Drawing.Point(186, 429);
            this.pnlabajo.Name = "pnlabajo";
            this.pnlabajo.Size = new System.Drawing.Size(695, 64);
            this.pnlabajo.TabIndex = 2;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Felix Titling", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(51, 19);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 2;
            // 
            // btnPagar
            // 
            this.btnPagar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPagar.FlatAppearance.BorderSize = 2;
            this.btnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPagar.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnPagar.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.pagar;
            this.btnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPagar.Location = new System.Drawing.Point(364, 11);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(146, 46);
            this.btnPagar.TabIndex = 1;
            this.btnPagar.Text = "Cerrar Pedido";
            this.btnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPagar.UseVisualStyleBackColor = false;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAgregar.FlatAppearance.BorderSize = 2;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Rockwell", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnAgregar.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.carro_de_la_compra__1_;
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(525, 11);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(146, 46);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar Items";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnlcentro
            // 
            this.pnlcentro.Controls.Add(this.tabControl1);
            this.pnlcentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlcentro.Location = new System.Drawing.Point(186, 64);
            this.pnlcentro.Name = "pnlcentro";
            this.pnlcentro.Size = new System.Drawing.Size(695, 365);
            this.pnlcentro.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage1.Controls.Add(this.dgvModificarPedido);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(687, 339);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Modificar Pedido";
            // 
            // dgvModificarPedido
            // 
            this.dgvModificarPedido.AllowUserToDeleteRows = false;
            this.dgvModificarPedido.AllowUserToOrderColumns = true;
            this.dgvModificarPedido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvModificarPedido.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvModificarPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModificarPedido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModificarPedido.Location = new System.Drawing.Point(3, 3);
            this.dgvModificarPedido.Name = "dgvModificarPedido";
            this.dgvModificarPedido.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvModificarPedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvModificarPedido.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvModificarPedido.Size = new System.Drawing.Size(681, 333);
            this.dgvModificarPedido.TabIndex = 0;
            this.dgvModificarPedido.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModificarPedido_CellDoubleClick);
            this.dgvModificarPedido.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvModificarPedido_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.imgFondo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.clbAderezos);
            this.tabPage2.Controls.Add(this.clbAdicionales);
            this.tabPage2.Controls.Add(this.lblEleccionPedido);
            this.tabPage2.Controls.Add(this.nudCantidad);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPrecio);
            this.tabPage2.Controls.Add(this.cmbIngredientes);
            this.tabPage2.Controls.Add(this.cmbTipo);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(687, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Alimentos";
            // 
            // cmbTipo
            // 
            this.cmbTipo.AutoCompleteCustomSource.AddRange(new string[] {
            "Hamburguesa de carne",
            "Hamburguesa de pollo ",
            "Hamburguesa vegetariana"});
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(22, 125);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(250, 24);
            this.cmbTipo.TabIndex = 69;
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(285, 125);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(291, 24);
            this.cmbIngredientes.TabIndex = 70;
            this.cmbIngredientes.SelectedIndexChanged += new System.EventHandler(this.cmbIngredientes_SelectedIndexChanged);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(589, 125);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 22);
            this.txtPrecio.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "Comida";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(382, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 16);
            this.label5.TabIndex = 72;
            this.label5.Text = "Ingredientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 73;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 74;
            this.label4.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(552, 207);
            this.nudCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(90, 22);
            this.nudCantidad.TabIndex = 77;
            // 
            // lblEleccionPedido
            // 
            this.lblEleccionPedido.AutoSize = true;
            this.lblEleccionPedido.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Italic);
            this.lblEleccionPedido.Location = new System.Drawing.Point(232, 43);
            this.lblEleccionPedido.Name = "lblEleccionPedido";
            this.lblEleccionPedido.Size = new System.Drawing.Size(20, 28);
            this.lblEleccionPedido.TabIndex = 78;
            this.lblEleccionPedido.Text = "1";
            // 
            // clbAdicionales
            // 
            this.clbAdicionales.BackColor = System.Drawing.SystemColors.Menu;
            this.clbAdicionales.CheckOnClick = true;
            this.clbAdicionales.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAdicionales.FormattingEnabled = true;
            this.clbAdicionales.Items.AddRange(new object[] {
            "PapasChicas",
            "PapasMedianas",
            "PapasGrandes"});
            this.clbAdicionales.Location = new System.Drawing.Point(174, 202);
            this.clbAdicionales.Margin = new System.Windows.Forms.Padding(2);
            this.clbAdicionales.Name = "clbAdicionales";
            this.clbAdicionales.Size = new System.Drawing.Size(139, 58);
            this.clbAdicionales.TabIndex = 79;
            this.clbAdicionales.SelectedIndexChanged += new System.EventHandler(this.clbAdicionales_SelectedIndexChanged);
            // 
            // clbAderezos
            // 
            this.clbAderezos.AutoSize = true;
            this.clbAderezos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAderezos.Location = new System.Drawing.Point(344, 202);
            this.clbAderezos.Margin = new System.Windows.Forms.Padding(2);
            this.clbAderezos.Name = "clbAderezos";
            this.clbAderezos.Size = new System.Drawing.Size(87, 21);
            this.clbAderezos.TabIndex = 80;
            this.clbAderezos.Text = "Aderezos";
            this.clbAderezos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clbAderezos.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(193, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Papas Fritas";
            // 
            // imgFondo
            // 
            this.imgFondo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgFondo.Image = global::Tp_Integrador_BurgerSix.Properties.Resources.picasion_com_144d74b7c734c4afca770e692711a767;
            this.imgFondo.Location = new System.Drawing.Point(3, 3);
            this.imgFondo.Name = "imgFondo";
            this.imgFondo.Size = new System.Drawing.Size(681, 333);
            this.imgFondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgFondo.TabIndex = 82;
            this.imgFondo.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 365);
            this.tabControl1.TabIndex = 69;
            // 
            // frmArmarPedido_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 493);
            this.Controls.Add(this.pnlcentro);
            this.Controls.Add(this.pnlabajo);
            this.Controls.Add(this.pnlAriba);
            this.Controls.Add(this.pnlizquierda);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmArmarPedido_";
            this.Text = "Armar Pedido";
            this.Load += new System.EventHandler(this.frmArmarPedido__Load);
            this.pnlizquierda.ResumeLayout(false);
            this.pnlizquierda.PerformLayout();
            this.pnlAriba.ResumeLayout(false);
            this.pnlAriba.PerformLayout();
            this.pnlabajo.ResumeLayout(false);
            this.pnlabajo.PerformLayout();
            this.pnlcentro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModificarPedido)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFondo)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlizquierda;
        private System.Windows.Forms.Panel pnlAriba;
        private System.Windows.Forms.Panel pnlabajo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHambuegesa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlcentro;
        private System.Windows.Forms.Button btnBebidas;
        private System.Windows.Forms.Button btnPapasFritas;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button btnNuevoPedido;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox imgFondo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox clbAderezos;
        private System.Windows.Forms.CheckedListBox clbAdicionales;
        private System.Windows.Forms.Label lblEleccionPedido;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvModificarPedido;
    }
}