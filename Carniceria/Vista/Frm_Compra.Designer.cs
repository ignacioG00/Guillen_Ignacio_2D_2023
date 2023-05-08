namespace Vista
{
    partial class Frm_Compra
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
            label1 = new Label();
            lb_agregarCarnes = new Label();
            dgv_listaCarnes = new DataGridView();
            corteCarne = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            tb_kg = new TextBox();
            rtb_cuenta = new RichTextBox();
            label2 = new Label();
            clb_carnes = new CheckedListBox();
            lb_total = new Label();
            btn_anotarPedido = new Button();
            btn_anularCompra = new Button();
            cb_listaClientes = new ComboBox();
            lb_venderA = new Label();
            btn_realizarPago = new Button();
            btn_actualizarLista = new Button();
            cb_tipoPago = new ComboBox();
            label4 = new Label();
            tb_montoMax = new TextBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listaCarnes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(222, 9);
            label1.Name = "label1";
            label1.Size = new Size(190, 37);
            label1.TabIndex = 1;
            label1.Text = "FACTURACION";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lb_agregarCarnes
            // 
            lb_agregarCarnes.AutoSize = true;
            lb_agregarCarnes.BackColor = Color.Transparent;
            lb_agregarCarnes.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lb_agregarCarnes.ForeColor = SystemColors.ControlText;
            lb_agregarCarnes.Location = new Point(87, 57);
            lb_agregarCarnes.Name = "lb_agregarCarnes";
            lb_agregarCarnes.Size = new Size(84, 15);
            lb_agregarCarnes.TabIndex = 14;
            lb_agregarCarnes.Text = "ELEGIR CARNE";
            // 
            // dgv_listaCarnes
            // 
            dgv_listaCarnes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaCarnes.Columns.AddRange(new DataGridViewColumn[] { corteCarne, cantidad, precio });
            dgv_listaCarnes.Location = new Point(12, 288);
            dgv_listaCarnes.Name = "dgv_listaCarnes";
            dgv_listaCarnes.ReadOnly = true;
            dgv_listaCarnes.RowTemplate.Height = 25;
            dgv_listaCarnes.Size = new Size(369, 150);
            dgv_listaCarnes.TabIndex = 13;
            // 
            // corteCarne
            // 
            corteCarne.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            corteCarne.HeaderText = "Corte de Carne";
            corteCarne.Name = "corteCarne";
            corteCarne.ReadOnly = true;
            // 
            // cantidad
            // 
            cantidad.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cantidad.HeaderText = "Cantidad";
            cantidad.Name = "cantidad";
            cantidad.ReadOnly = true;
            cantidad.Width = 80;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.Name = "precio";
            precio.ReadOnly = true;
            // 
            // tb_kg
            // 
            tb_kg.Location = new Point(75, 202);
            tb_kg.Name = "tb_kg";
            tb_kg.Size = new Size(131, 23);
            tb_kg.TabIndex = 15;
            // 
            // rtb_cuenta
            // 
            rtb_cuenta.Location = new Point(496, 64);
            rtb_cuenta.Name = "rtb_cuenta";
            rtb_cuenta.ReadOnly = true;
            rtb_cuenta.Size = new Size(202, 300);
            rtb_cuenta.TabIndex = 16;
            rtb_cuenta.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(75, 184);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 17;
            label2.Text = "Cantidad (kg/gr) :";
            // 
            // clb_carnes
            // 
            clb_carnes.FormattingEnabled = true;
            clb_carnes.Items.AddRange(new object[] { "Bondiola", "Vacio", "Tira de Asado", "Chorizo", "Costillar" });
            clb_carnes.Location = new Point(87, 75);
            clb_carnes.Name = "clb_carnes";
            clb_carnes.Size = new Size(120, 94);
            clb_carnes.TabIndex = 18;
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Location = new Point(496, 46);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(41, 15);
            lb_total.TabIndex = 19;
            lb_total.Text = "Total : ";
            // 
            // btn_anotarPedido
            // 
            btn_anotarPedido.Location = new Point(513, 370);
            btn_anotarPedido.Name = "btn_anotarPedido";
            btn_anotarPedido.Size = new Size(120, 23);
            btn_anotarPedido.TabIndex = 20;
            btn_anotarPedido.Text = "AGREGAR PEDIDO";
            btn_anotarPedido.UseVisualStyleBackColor = true;
            btn_anotarPedido.Click += btn_anotarPedido_Click;
            // 
            // btn_anularCompra
            // 
            btn_anularCompra.Location = new Point(387, 370);
            btn_anularCompra.Name = "btn_anularCompra";
            btn_anularCompra.Size = new Size(120, 23);
            btn_anularCompra.TabIndex = 21;
            btn_anularCompra.Text = "ANULAR COMPRA";
            btn_anularCompra.UseVisualStyleBackColor = true;
            btn_anularCompra.Click += btn_anularCompra_Click;
            // 
            // cb_listaClientes
            // 
            cb_listaClientes.FormattingEnabled = true;
            cb_listaClientes.Location = new Point(260, 75);
            cb_listaClientes.Name = "cb_listaClientes";
            cb_listaClientes.Size = new Size(121, 23);
            cb_listaClientes.TabIndex = 22;
            // 
            // lb_venderA
            // 
            lb_venderA.AutoSize = true;
            lb_venderA.BackColor = Color.Transparent;
            lb_venderA.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            lb_venderA.ForeColor = SystemColors.ControlText;
            lb_venderA.Location = new Point(260, 57);
            lb_venderA.Name = "lb_venderA";
            lb_venderA.Size = new Size(58, 15);
            lb_venderA.TabIndex = 23;
            lb_venderA.Text = "Vender a :";
            // 
            // btn_realizarPago
            // 
            btn_realizarPago.Location = new Point(639, 370);
            btn_realizarPago.Name = "btn_realizarPago";
            btn_realizarPago.Size = new Size(120, 23);
            btn_realizarPago.TabIndex = 24;
            btn_realizarPago.Text = "REALIZAR PAGO";
            btn_realizarPago.UseVisualStyleBackColor = true;
            btn_realizarPago.Click += btn_realizarPago_Click;
            // 
            // btn_actualizarLista
            // 
            btn_actualizarLista.Location = new Point(12, 259);
            btn_actualizarLista.Name = "btn_actualizarLista";
            btn_actualizarLista.Size = new Size(129, 23);
            btn_actualizarLista.TabIndex = 25;
            btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            btn_actualizarLista.UseVisualStyleBackColor = true;
            btn_actualizarLista.Click += btn_actualizarLista_Click;
            // 
            // cb_tipoPago
            // 
            cb_tipoPago.FormattingEnabled = true;
            cb_tipoPago.Items.AddRange(new object[] { "Efectivo", "Credito", "Debito" });
            cb_tipoPago.Location = new Point(260, 146);
            cb_tipoPago.Name = "cb_tipoPago";
            cb_tipoPago.Size = new Size(121, 23);
            cb_tipoPago.TabIndex = 26;
            cb_tipoPago.SelectedIndexChanged += cb_tipoPago_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(260, 128);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 27;
            label4.Text = "Metodo de pago :";
            // 
            // tb_montoMax
            // 
            tb_montoMax.Location = new Point(260, 202);
            tb_montoMax.Name = "tb_montoMax";
            tb_montoMax.Size = new Size(121, 23);
            tb_montoMax.TabIndex = 28;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(260, 184);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 29;
            label5.Text = "Monto maximo :";
            // 
            // Frm_Compra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(tb_montoMax);
            Controls.Add(label4);
            Controls.Add(cb_tipoPago);
            Controls.Add(btn_actualizarLista);
            Controls.Add(btn_realizarPago);
            Controls.Add(lb_venderA);
            Controls.Add(cb_listaClientes);
            Controls.Add(btn_anularCompra);
            Controls.Add(btn_anotarPedido);
            Controls.Add(lb_total);
            Controls.Add(clb_carnes);
            Controls.Add(label2);
            Controls.Add(rtb_cuenta);
            Controls.Add(tb_kg);
            Controls.Add(lb_agregarCarnes);
            Controls.Add(dgv_listaCarnes);
            Controls.Add(label1);
            Name = "Frm_Compra";
            Text = "VENTAS";
            Load += Frm_Compra_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaCarnes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lb_agregarCarnes;
        private DataGridView dgv_listaCarnes;
        private DataGridViewTextBoxColumn corteCarne;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn precio;
        private TextBox tb_kg;
        private RichTextBox rtb_cuenta;
        private Label label2;
        private CheckedListBox clb_carnes;
        private Label label3;
        private Button btn_anotarPedido;
        private Button button1;
        private Button btn_anularCompra;
        private Label lb_total;
        private ComboBox cb_listaClientes;
        private Label lb_venderA;
        private Button btn_realizarPago;
        private Button btn_actualizarLista;
        private ComboBox cb_tipoPago;
        private Label label4;
        private TextBox tb_montoMax;
        private Label label5;
    }
}