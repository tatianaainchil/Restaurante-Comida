
namespace Tp_Integrador_BurgerSix
{
    partial class frmPrueba
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
            this.cmbTipoMedallon = new System.Windows.Forms.ComboBox();
            this.cmbIngredientes = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxBebidas = new System.Windows.Forms.ComboBox();
            this.clbAdicionales = new System.Windows.Forms.CheckedListBox();
            this.clbAderezos = new System.Windows.Forms.CheckBox();
            this.nudCantidadAdicional = new System.Windows.Forms.NumericUpDown();
            this.nudCantidadHambur = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCrearPedido = new System.Windows.Forms.Button();
            this.pnlComida = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdicional)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHambur)).BeginInit();
            this.pnlComida.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbTipoMedallon
            // 
            this.cmbTipoMedallon.AutoCompleteCustomSource.AddRange(new string[] {
            "Hamburguesa de carne",
            "Hamburguesa de pollo ",
            "Hamburguesa vegetariana"});
            this.cmbTipoMedallon.FormattingEnabled = true;
            this.cmbTipoMedallon.Items.AddRange(new object[] {
            "Hamburguesa de carne",
            "Hamburguesa de pollo",
            "Hamburguesa vegetariana"});
            this.cmbTipoMedallon.Location = new System.Drawing.Point(18, 43);
            this.cmbTipoMedallon.Name = "cmbTipoMedallon";
            this.cmbTipoMedallon.Size = new System.Drawing.Size(250, 21);
            this.cmbTipoMedallon.TabIndex = 36;
            // 
            // cmbIngredientes
            // 
            this.cmbIngredientes.FormattingEnabled = true;
            this.cmbIngredientes.Location = new System.Drawing.Point(281, 43);
            this.cmbIngredientes.Name = "cmbIngredientes";
            this.cmbIngredientes.Size = new System.Drawing.Size(250, 21);
            this.cmbIngredientes.TabIndex = 37;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(539, 43);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Comida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(357, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 39;
            this.label2.Text = "Ingredientes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(546, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 40;
            this.label3.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(371, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Cantidad";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(242, 260);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(88, 37);
            this.buttonAgregar.TabIndex = 42;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 134);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Bebidas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(239, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 45;
            this.label7.Text = "Adicionales";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Location = new System.Drawing.Point(1, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(634, 10);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // comboBoxBebidas
            // 
            this.comboBoxBebidas.FormattingEnabled = true;
            this.comboBoxBebidas.Items.AddRange(new object[] {
            "AGUA",
            "COLA",
            "LIMA"});
            this.comboBoxBebidas.Location = new System.Drawing.Point(32, 157);
            this.comboBoxBebidas.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBebidas.Name = "comboBoxBebidas";
            this.comboBoxBebidas.Size = new System.Drawing.Size(113, 21);
            this.comboBoxBebidas.TabIndex = 46;
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
            this.clbAdicionales.Location = new System.Drawing.Point(224, 157);
            this.clbAdicionales.Margin = new System.Windows.Forms.Padding(2);
            this.clbAdicionales.Name = "clbAdicionales";
            this.clbAdicionales.Size = new System.Drawing.Size(139, 58);
            this.clbAdicionales.TabIndex = 48;
            // 
            // clbAderezos
            // 
            this.clbAderezos.AutoSize = true;
            this.clbAderezos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbAderezos.Location = new System.Drawing.Point(415, 157);
            this.clbAderezos.Margin = new System.Windows.Forms.Padding(2);
            this.clbAderezos.Name = "clbAderezos";
            this.clbAderezos.Size = new System.Drawing.Size(87, 21);
            this.clbAderezos.TabIndex = 49;
            this.clbAderezos.Text = "Aderezos";
            this.clbAderezos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clbAderezos.UseVisualStyleBackColor = true;
            // 
            // nudCantidadAdicional
            // 
            this.nudCantidadAdicional.Location = new System.Drawing.Point(446, 207);
            this.nudCantidadAdicional.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidadAdicional.Name = "nudCantidadAdicional";
            this.nudCantidadAdicional.Size = new System.Drawing.Size(90, 20);
            this.nudCantidadAdicional.TabIndex = 52;
            // 
            // nudCantidadHambur
            // 
            this.nudCantidadHambur.Location = new System.Drawing.Point(446, 84);
            this.nudCantidadHambur.Margin = new System.Windows.Forms.Padding(2);
            this.nudCantidadHambur.Name = "nudCantidadHambur";
            this.nudCantidadHambur.Size = new System.Drawing.Size(90, 20);
            this.nudCantidadHambur.TabIndex = 50;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.LavenderBlush;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(28, 211);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "precio bebida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(371, 211);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 53;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.LavenderBlush;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(229, 233);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 20);
            this.label10.TabIndex = 54;
            this.label10.Text = "precio bebida";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.LavenderBlush;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(468, 180);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 20);
            this.label11.TabIndex = 55;
            this.label11.Text = "precio bebida";
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Location = new System.Drawing.Point(511, 260);
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(88, 52);
            this.btnCrearPedido.TabIndex = 56;
            this.btnCrearPedido.Text = "Crear Pedido";
            this.btnCrearPedido.UseVisualStyleBackColor = true;
            // 
            // pnlComida
            // 
            this.pnlComida.Controls.Add(this.btnCrearPedido);
            this.pnlComida.Controls.Add(this.label11);
            this.pnlComida.Controls.Add(this.label10);
            this.pnlComida.Controls.Add(this.label9);
            this.pnlComida.Controls.Add(this.label8);
            this.pnlComida.Controls.Add(this.nudCantidadHambur);
            this.pnlComida.Controls.Add(this.nudCantidadAdicional);
            this.pnlComida.Controls.Add(this.clbAderezos);
            this.pnlComida.Controls.Add(this.clbAdicionales);
            this.pnlComida.Controls.Add(this.comboBoxBebidas);
            this.pnlComida.Controls.Add(this.groupBox1);
            this.pnlComida.Controls.Add(this.label7);
            this.pnlComida.Controls.Add(this.label6);
            this.pnlComida.Controls.Add(this.buttonAgregar);
            this.pnlComida.Controls.Add(this.label4);
            this.pnlComida.Controls.Add(this.label3);
            this.pnlComida.Controls.Add(this.label2);
            this.pnlComida.Controls.Add(this.label1);
            this.pnlComida.Controls.Add(this.txtPrecio);
            this.pnlComida.Controls.Add(this.cmbIngredientes);
            this.pnlComida.Controls.Add(this.cmbTipoMedallon);
            this.pnlComida.Location = new System.Drawing.Point(12, 51);
            this.pnlComida.Name = "pnlComida";
            this.pnlComida.Size = new System.Drawing.Size(634, 320);
            this.pnlComida.TabIndex = 55;
            // 
            // frmPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlComida);
            this.Name = "frmPrueba";
            this.Text = "frmPrueba";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadAdicional)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadHambur)).EndInit();
            this.pnlComida.ResumeLayout(false);
            this.pnlComida.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbTipoMedallon;
        private System.Windows.Forms.ComboBox cmbIngredientes;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBebidas;
        private System.Windows.Forms.CheckedListBox clbAdicionales;
        private System.Windows.Forms.CheckBox clbAderezos;
        private System.Windows.Forms.NumericUpDown nudCantidadAdicional;
        private System.Windows.Forms.NumericUpDown nudCantidadHambur;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCrearPedido;
        private System.Windows.Forms.Panel pnlComida;
    }
}