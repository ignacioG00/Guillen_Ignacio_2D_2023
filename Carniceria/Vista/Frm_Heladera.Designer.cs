namespace Vista
{
    partial class Frm_Heladera
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
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.btn_bondiola = new System.Windows.Forms.Button();
            this.btn_vacio = new System.Windows.Forms.Button();
            this.btn_tiraAsado = new System.Windows.Forms.Button();
            this.btn_chorizo = new System.Windows.Forms.Button();
            this.btn_costillar = new System.Windows.Forms.Button();
            this.dgv_listaCarnes = new System.Windows.Forms.DataGridView();
            this.corteCarne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb_reponer = new System.Windows.Forms.Label();
            this.btn_actualizarLista = new System.Windows.Forms.Button();
            this.btn_fijarPrecioxKilo = new System.Windows.Forms.Button();
            this.tb_fijarPrecio = new System.Windows.Forms.TextBox();
            this.cb_listaCarnes = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_irACompras = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_Titulo.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.Black;
            this.lb_Titulo.Location = new System.Drawing.Point(126, 9);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(147, 37);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "HELADERA";
            // 
            // btn_bondiola
            // 
            this.btn_bondiola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_bondiola.Location = new System.Drawing.Point(14, 103);
            this.btn_bondiola.Name = "btn_bondiola";
            this.btn_bondiola.Size = new System.Drawing.Size(73, 35);
            this.btn_bondiola.TabIndex = 1;
            this.btn_bondiola.Text = "Bondiola";
            this.btn_bondiola.UseVisualStyleBackColor = false;
            // 
            // btn_vacio
            // 
            this.btn_vacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_vacio.Location = new System.Drawing.Point(89, 103);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(73, 35);
            this.btn_vacio.TabIndex = 2;
            this.btn_vacio.Text = "Vacio";
            this.btn_vacio.UseVisualStyleBackColor = false;
            // 
            // btn_tiraAsado
            // 
            this.btn_tiraAsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_tiraAsado.Location = new System.Drawing.Point(164, 103);
            this.btn_tiraAsado.Name = "btn_tiraAsado";
            this.btn_tiraAsado.Size = new System.Drawing.Size(73, 35);
            this.btn_tiraAsado.TabIndex = 3;
            this.btn_tiraAsado.Text = "Asado";
            this.btn_tiraAsado.UseVisualStyleBackColor = false;
            // 
            // btn_chorizo
            // 
            this.btn_chorizo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_chorizo.Location = new System.Drawing.Point(239, 103);
            this.btn_chorizo.Name = "btn_chorizo";
            this.btn_chorizo.Size = new System.Drawing.Size(73, 35);
            this.btn_chorizo.TabIndex = 4;
            this.btn_chorizo.Text = "Chorizo";
            this.btn_chorizo.UseVisualStyleBackColor = false;
            // 
            // btn_costillar
            // 
            this.btn_costillar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_costillar.Location = new System.Drawing.Point(314, 103);
            this.btn_costillar.Name = "btn_costillar";
            this.btn_costillar.Size = new System.Drawing.Size(73, 35);
            this.btn_costillar.TabIndex = 5;
            this.btn_costillar.Text = "Costillar";
            this.btn_costillar.UseVisualStyleBackColor = false;
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(12, 173);
            this.dgv_listaCarnes.Name = "dgv_listaCarnes";
            this.dgv_listaCarnes.RowTemplate.Height = 25;
            this.dgv_listaCarnes.Size = new System.Drawing.Size(369, 150);
            this.dgv_listaCarnes.TabIndex = 6;
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
            // lb_reponer
            // 
            this.lb_reponer.AutoSize = true;
            this.lb_reponer.BackColor = System.Drawing.Color.Transparent;
            this.lb_reponer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_reponer.ForeColor = System.Drawing.Color.Black;
            this.lb_reponer.Location = new System.Drawing.Point(14, 67);
            this.lb_reponer.Name = "lb_reponer";
            this.lb_reponer.Size = new System.Drawing.Size(142, 21);
            this.lb_reponer.TabIndex = 7;
            this.lb_reponer.Text = "REPONER CARNES";
            // 
            // btn_actualizarLista
            // 
            this.btn_actualizarLista.Location = new System.Drawing.Point(12, 144);
            this.btn_actualizarLista.Name = "btn_actualizarLista";
            this.btn_actualizarLista.Size = new System.Drawing.Size(129, 23);
            this.btn_actualizarLista.TabIndex = 22;
            this.btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            this.btn_actualizarLista.UseVisualStyleBackColor = true;
            // 
            // btn_fijarPrecioxKilo
            // 
            this.btn_fijarPrecioxKilo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_fijarPrecioxKilo.Location = new System.Drawing.Point(401, 260);
            this.btn_fijarPrecioxKilo.Name = "btn_fijarPrecioxKilo";
            this.btn_fijarPrecioxKilo.Size = new System.Drawing.Size(160, 30);
            this.btn_fijarPrecioxKilo.TabIndex = 23;
            this.btn_fijarPrecioxKilo.Text = "FIJAR PRECIO POR KILO";
            this.btn_fijarPrecioxKilo.UseVisualStyleBackColor = false;
            // 
            // tb_fijarPrecio
            // 
            this.tb_fijarPrecio.Location = new System.Drawing.Point(401, 207);
            this.tb_fijarPrecio.Name = "tb_fijarPrecio";
            this.tb_fijarPrecio.Size = new System.Drawing.Size(160, 23);
            this.tb_fijarPrecio.TabIndex = 24;
            // 
            // cb_listaCarnes
            // 
            this.cb_listaCarnes.FormattingEnabled = true;
            this.cb_listaCarnes.Location = new System.Drawing.Point(401, 157);
            this.cb_listaCarnes.Name = "cb_listaCarnes";
            this.cb_listaCarnes.Size = new System.Drawing.Size(160, 23);
            this.cb_listaCarnes.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(401, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 21);
            this.label2.TabIndex = 26;
            this.label2.Text = "FIJAR PRECIO X KILO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(401, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "Lista de carnes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(401, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 21);
            this.label4.TabIndex = 28;
            this.label4.Text = "Precio x kg:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(585, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 21);
            this.label5.TabIndex = 29;
            this.label5.Text = "FIJAR PRODUCTO";
            // 
            // btn_irACompras
            // 
            this.btn_irACompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_irACompras.Location = new System.Drawing.Point(597, 17);
            this.btn_irACompras.Name = "btn_irACompras";
            this.btn_irACompras.Size = new System.Drawing.Size(142, 35);
            this.btn_irACompras.TabIndex = 30;
            this.btn_irACompras.Text = "VENDER CARNE";
            this.btn_irACompras.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.Location = new System.Drawing.Point(585, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 30);
            this.button1.TabIndex = 31;
            this.button1.Text = "AÑADIR NUEVO PRODUCTO";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Frm_Heladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(790, 358);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_irACompras);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_listaCarnes);
            this.Controls.Add(this.tb_fijarPrecio);
            this.Controls.Add(this.btn_fijarPrecioxKilo);
            this.Controls.Add(this.btn_actualizarLista);
            this.Controls.Add(this.lb_reponer);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.btn_costillar);
            this.Controls.Add(this.btn_chorizo);
            this.Controls.Add(this.btn_tiraAsado);
            this.Controls.Add(this.btn_vacio);
            this.Controls.Add(this.btn_bondiola);
            this.Controls.Add(this.lb_Titulo);
            this.MaximizeBox = false;
            this.Name = "Frm_Heladera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HELADERA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Frm_Heladera_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btn_asado;
        private Button btn_vacio;
        private Button btn_tiraAsado;
        private Button btn_choripan;
        private Button btn_costillar;
        private DataGridView dgv_listaCarnes;
        private DataGridViewTextBoxColumn cantidad;
        private DataGridViewTextBoxColumn corteCarne;
        private DataGridViewTextBoxColumn precio;
        private Button btn_bondiola;
        private Label lb_Titulo;
        private Button btn_chorizo;
        private Label lb_reponer;
        private Button btn_actualizarLista;
        private Button btn_fijarPrecioxKilo;
        private TextBox tb_fijarPrecio;
        private ComboBox cb_listaCarnes;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btn_irACompras;
        private Button button1;
    }
}