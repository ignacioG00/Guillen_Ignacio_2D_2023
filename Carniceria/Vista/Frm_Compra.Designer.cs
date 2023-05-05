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
            this.btn_costillar = new System.Windows.Forms.Button();
            this.btn_chorizo = new System.Windows.Forms.Button();
            this.btn_tiraAsado = new System.Windows.Forms.Button();
            this.btn_vacio = new System.Windows.Forms.Button();
            this.btn_bondiola = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(300, 9);
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
            this.lb_agregarCarnes.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_agregarCarnes.ForeColor = System.Drawing.Color.Blue;
            this.lb_agregarCarnes.Location = new System.Drawing.Point(45, 98);
            this.lb_agregarCarnes.Name = "lb_agregarCarnes";
            this.lb_agregarCarnes.Size = new System.Drawing.Size(134, 20);
            this.lb_agregarCarnes.TabIndex = 14;
            this.lb_agregarCarnes.Text = "ESCOGER CARNE";
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(47, 195);
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
            // btn_costillar
            // 
            this.btn_costillar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_costillar.Location = new System.Drawing.Point(347, 130);
            this.btn_costillar.Name = "btn_costillar";
            this.btn_costillar.Size = new System.Drawing.Size(69, 35);
            this.btn_costillar.TabIndex = 12;
            this.btn_costillar.Text = "Costillar";
            this.btn_costillar.UseVisualStyleBackColor = false;
            // 
            // btn_chorizo
            // 
            this.btn_chorizo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_chorizo.Location = new System.Drawing.Point(272, 130);
            this.btn_chorizo.Name = "btn_chorizo";
            this.btn_chorizo.Size = new System.Drawing.Size(69, 35);
            this.btn_chorizo.TabIndex = 11;
            this.btn_chorizo.Text = "Chorizo";
            this.btn_chorizo.UseVisualStyleBackColor = false;
            // 
            // btn_tiraAsado
            // 
            this.btn_tiraAsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_tiraAsado.Location = new System.Drawing.Point(197, 130);
            this.btn_tiraAsado.Name = "btn_tiraAsado";
            this.btn_tiraAsado.Size = new System.Drawing.Size(69, 35);
            this.btn_tiraAsado.TabIndex = 10;
            this.btn_tiraAsado.Text = "Asado";
            this.btn_tiraAsado.UseVisualStyleBackColor = false;
            // 
            // btn_vacio
            // 
            this.btn_vacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_vacio.Location = new System.Drawing.Point(122, 130);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(69, 35);
            this.btn_vacio.TabIndex = 9;
            this.btn_vacio.Text = "Vacio";
            this.btn_vacio.UseVisualStyleBackColor = false;
            // 
            // btn_bondiola
            // 
            this.btn_bondiola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_bondiola.Location = new System.Drawing.Point(47, 130);
            this.btn_bondiola.Name = "btn_bondiola";
            this.btn_bondiola.Size = new System.Drawing.Size(69, 35);
            this.btn_bondiola.TabIndex = 8;
            this.btn_bondiola.Text = "Bondiola";
            this.btn_bondiola.UseVisualStyleBackColor = false;
            // 
            // Frm_Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lb_agregarCarnes);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.btn_costillar);
            this.Controls.Add(this.btn_chorizo);
            this.Controls.Add(this.btn_tiraAsado);
            this.Controls.Add(this.btn_vacio);
            this.Controls.Add(this.btn_bondiola);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Compra";
            this.Text = "Frm_Compra";
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
        private Button btn_costillar;
        private Button btn_chorizo;
        private Button btn_tiraAsado;
        private Button btn_vacio;
        private Button btn_bondiola;
    }
}