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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_agregarCarnes = new System.Windows.Forms.Label();
            this.dgv_listaCarnes = new System.Windows.Forms.DataGridView();
            this.corteCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tb_kg = new System.Windows.Forms.TextBox();
            this.rtb_cuenta = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.clb_carnes = new System.Windows.Forms.CheckedListBox();
            this.lb_total = new System.Windows.Forms.Label();
            this.btn_anotarPedido = new System.Windows.Forms.Button();
            this.btn_anularCompra = new System.Windows.Forms.Button();
            this.cb_listaUsuarios = new System.Windows.Forms.ComboBox();
            this.lb_venderA = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_actualizarLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "FACTURACION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_agregarCarnes
            // 
            this.lb_agregarCarnes.AutoSize = true;
            this.lb_agregarCarnes.BackColor = System.Drawing.Color.Transparent;
            this.lb_agregarCarnes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_agregarCarnes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_agregarCarnes.Location = new System.Drawing.Point(87, 57);
            this.lb_agregarCarnes.Name = "lb_agregarCarnes";
            this.lb_agregarCarnes.Size = new System.Drawing.Size(84, 15);
            this.lb_agregarCarnes.TabIndex = 14;
            this.lb_agregarCarnes.Text = "ELEGIR CARNE";
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(12, 288);
            this.dgv_listaCarnes.Name = "dgv_listaCarnes";
            this.dgv_listaCarnes.RowTemplate.Height = 25;
            this.dgv_listaCarnes.Size = new System.Drawing.Size(369, 150);
            this.dgv_listaCarnes.TabIndex = 13;
            // 
            // corteCarne
            // 
            this.corteCarne.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.corteCarne.HeaderText = "Corte de Carne";
            this.corteCarne.Name = "corteCarne";
            this.corteCarne.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 80;
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // tb_kg
            // 
            this.tb_kg.Location = new System.Drawing.Point(87, 202);
            this.tb_kg.Name = "tb_kg";
            this.tb_kg.Size = new System.Drawing.Size(131, 23);
            this.tb_kg.TabIndex = 15;
            // 
            // rtb_cuenta
            // 
            this.rtb_cuenta.Location = new System.Drawing.Point(496, 64);
            this.rtb_cuenta.Name = "rtb_cuenta";
            this.rtb_cuenta.Size = new System.Drawing.Size(202, 300);
            this.rtb_cuenta.TabIndex = 16;
            this.rtb_cuenta.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 15);
            this.label2.TabIndex = 17;
            this.label2.Text = "Cantidad (kg) gramos en \",\": ";
            // 
            // clb_carnes
            // 
            this.clb_carnes.FormattingEnabled = true;
            this.clb_carnes.Items.AddRange(new object[] {
            "Bondiola",
            "Vacio",
            "Tira de Asado",
            "Chorizo",
            "Costillar"});
            this.clb_carnes.Location = new System.Drawing.Point(87, 75);
            this.clb_carnes.Name = "clb_carnes";
            this.clb_carnes.Size = new System.Drawing.Size(120, 94);
            this.clb_carnes.TabIndex = 18;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Location = new System.Drawing.Point(496, 46);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(41, 15);
            this.lb_total.TabIndex = 19;
            this.lb_total.Text = "Total : ";
            // 
            // btn_anotarPedido
            // 
            this.btn_anotarPedido.Location = new System.Drawing.Point(513, 370);
            this.btn_anotarPedido.Name = "btn_anotarPedido";
            this.btn_anotarPedido.Size = new System.Drawing.Size(120, 23);
            this.btn_anotarPedido.TabIndex = 20;
            this.btn_anotarPedido.Text = "REALIZAR COMPRA";
            this.btn_anotarPedido.UseVisualStyleBackColor = true;
            this.btn_anotarPedido.Click += new System.EventHandler(this.btn_anotarPedido_Click);
            // 
            // btn_anularCompra
            // 
            this.btn_anularCompra.Location = new System.Drawing.Point(387, 370);
            this.btn_anularCompra.Name = "btn_anularCompra";
            this.btn_anularCompra.Size = new System.Drawing.Size(120, 23);
            this.btn_anularCompra.TabIndex = 21;
            this.btn_anularCompra.Text = "LIMPIAR FACTURAS";
            this.btn_anularCompra.UseVisualStyleBackColor = true;
            this.btn_anularCompra.Click += new System.EventHandler(this.btn_anularCompra_Click);
            // 
            // cb_listaUsuarios
            // 
            this.cb_listaUsuarios.FormattingEnabled = true;
            this.cb_listaUsuarios.Location = new System.Drawing.Point(260, 75);
            this.cb_listaUsuarios.Name = "cb_listaUsuarios";
            this.cb_listaUsuarios.Size = new System.Drawing.Size(121, 23);
            this.cb_listaUsuarios.TabIndex = 22;
            // 
            // lb_venderA
            // 
            this.lb_venderA.AutoSize = true;
            this.lb_venderA.BackColor = System.Drawing.Color.Transparent;
            this.lb_venderA.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_venderA.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_venderA.Location = new System.Drawing.Point(260, 57);
            this.lb_venderA.Name = "lb_venderA";
            this.lb_venderA.Size = new System.Drawing.Size(58, 15);
            this.lb_venderA.TabIndex = 23;
            this.lb_venderA.Text = "Vender a :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "REALIZAR PAGO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_actualizarLista
            // 
            this.btn_actualizarLista.Location = new System.Drawing.Point(12, 259);
            this.btn_actualizarLista.Name = "btn_actualizarLista";
            this.btn_actualizarLista.Size = new System.Drawing.Size(129, 23);
            this.btn_actualizarLista.TabIndex = 25;
            this.btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            this.btn_actualizarLista.UseVisualStyleBackColor = true;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_actualizarLista);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lb_venderA);
            this.Controls.Add(this.cb_listaUsuarios);
            this.Controls.Add(this.btn_anularCompra);
            this.Controls.Add(this.btn_anotarPedido);
            this.Controls.Add(this.lb_total);
            this.Controls.Add(this.clb_carnes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtb_cuenta);
            this.Controls.Add(this.tb_kg);
            this.Controls.Add(this.lb_agregarCarnes);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Compra";
            this.Text = "Frm_Compra";
            this.Load += new System.EventHandler(this.Frm_Compra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private ComboBox cb_listaUsuarios;
        private Label lb_venderA;
        private Button button2;
        private Button btn_actualizarLista;
    }
}