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
            lb_Titulo = new Label();
            btn_bondiola = new Button();
            btn_vacio = new Button();
            btn_tiraAsado = new Button();
            btn_chorizo = new Button();
            btn_costillar = new Button();
            dgv_listaCarnes = new DataGridView();
            corteCarne = new DataGridViewTextBoxColumn();
            cantidad = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            lb_reponer = new Label();
            btn_actualizarLista = new Button();
            btn_fijarPrecioxKilo = new Button();
            tb_fijarPrecio = new TextBox();
            cb_listaCarnes = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_listaCarnes).BeginInit();
            SuspendLayout();
            // 
            // lb_Titulo
            // 
            lb_Titulo.AutoSize = true;
            lb_Titulo.BackColor = Color.Transparent;
            lb_Titulo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Titulo.ForeColor = Color.Black;
            lb_Titulo.Location = new Point(126, 9);
            lb_Titulo.Name = "lb_Titulo";
            lb_Titulo.Size = new Size(147, 37);
            lb_Titulo.TabIndex = 0;
            lb_Titulo.Text = "HELADERA";
            // 
            // btn_bondiola
            // 
            btn_bondiola.BackColor = Color.FromArgb(224, 224, 224);
            btn_bondiola.Location = new Point(14, 103);
            btn_bondiola.Name = "btn_bondiola";
            btn_bondiola.Size = new Size(73, 35);
            btn_bondiola.TabIndex = 1;
            btn_bondiola.Text = "Bondiola";
            btn_bondiola.UseVisualStyleBackColor = false;
            btn_bondiola.Click += btn_bondiola_Click;
            // 
            // btn_vacio
            // 
            btn_vacio.BackColor = Color.FromArgb(224, 224, 224);
            btn_vacio.Location = new Point(89, 103);
            btn_vacio.Name = "btn_vacio";
            btn_vacio.Size = new Size(73, 35);
            btn_vacio.TabIndex = 2;
            btn_vacio.Text = "Vacio";
            btn_vacio.UseVisualStyleBackColor = false;
            btn_vacio.Click += btn_vacio_Click;
            // 
            // btn_tiraAsado
            // 
            btn_tiraAsado.BackColor = Color.FromArgb(224, 224, 224);
            btn_tiraAsado.Location = new Point(164, 103);
            btn_tiraAsado.Name = "btn_tiraAsado";
            btn_tiraAsado.Size = new Size(73, 35);
            btn_tiraAsado.TabIndex = 3;
            btn_tiraAsado.Text = "Asado";
            btn_tiraAsado.UseVisualStyleBackColor = false;
            btn_tiraAsado.Click += btn_tiraAsado_Click;
            // 
            // btn_chorizo
            // 
            btn_chorizo.BackColor = Color.FromArgb(224, 224, 224);
            btn_chorizo.Location = new Point(239, 103);
            btn_chorizo.Name = "btn_chorizo";
            btn_chorizo.Size = new Size(73, 35);
            btn_chorizo.TabIndex = 4;
            btn_chorizo.Text = "Chorizo";
            btn_chorizo.UseVisualStyleBackColor = false;
            btn_chorizo.Click += btn_chorizo_Click;
            // 
            // btn_costillar
            // 
            btn_costillar.BackColor = Color.FromArgb(224, 224, 224);
            btn_costillar.Location = new Point(314, 103);
            btn_costillar.Name = "btn_costillar";
            btn_costillar.Size = new Size(73, 35);
            btn_costillar.TabIndex = 5;
            btn_costillar.Text = "Costillar";
            btn_costillar.UseVisualStyleBackColor = false;
            btn_costillar.Click += btn_costillar_Click;
            // 
            // dgv_listaCarnes
            // 
            dgv_listaCarnes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_listaCarnes.Columns.AddRange(new DataGridViewColumn[] { corteCarne, cantidad, precio });
            dgv_listaCarnes.Location = new Point(12, 173);
            dgv_listaCarnes.Name = "dgv_listaCarnes";
            dgv_listaCarnes.RowTemplate.Height = 25;
            dgv_listaCarnes.Size = new Size(369, 150);
            dgv_listaCarnes.TabIndex = 6;
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
            // lb_reponer
            // 
            lb_reponer.AutoSize = true;
            lb_reponer.BackColor = Color.Transparent;
            lb_reponer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_reponer.ForeColor = Color.Black;
            lb_reponer.Location = new Point(14, 79);
            lb_reponer.Name = "lb_reponer";
            lb_reponer.Size = new Size(142, 21);
            lb_reponer.TabIndex = 7;
            lb_reponer.Text = "REPONER CARNES";
            // 
            // btn_actualizarLista
            // 
            btn_actualizarLista.Location = new Point(12, 144);
            btn_actualizarLista.Name = "btn_actualizarLista";
            btn_actualizarLista.Size = new Size(129, 23);
            btn_actualizarLista.TabIndex = 22;
            btn_actualizarLista.Text = "ACTUALIZAR STOCK";
            btn_actualizarLista.UseVisualStyleBackColor = true;
            btn_actualizarLista.Click += btn_actualizarLista_Click;
            // 
            // btn_fijarPrecioxKilo
            // 
            btn_fijarPrecioxKilo.BackColor = Color.FromArgb(224, 224, 224);
            btn_fijarPrecioxKilo.Location = new Point(401, 260);
            btn_fijarPrecioxKilo.Name = "btn_fijarPrecioxKilo";
            btn_fijarPrecioxKilo.Size = new Size(160, 30);
            btn_fijarPrecioxKilo.TabIndex = 23;
            btn_fijarPrecioxKilo.Text = "FIJAR PRECIO POR KILO";
            btn_fijarPrecioxKilo.UseVisualStyleBackColor = false;
            btn_fijarPrecioxKilo.Click += btn_fijarPrecioxKilo_Click;
            // 
            // tb_fijarPrecio
            // 
            tb_fijarPrecio.Location = new Point(401, 231);
            tb_fijarPrecio.Name = "tb_fijarPrecio";
            tb_fijarPrecio.Size = new Size(160, 23);
            tb_fijarPrecio.TabIndex = 24;
            // 
            // cb_listaCarnes
            // 
            cb_listaCarnes.FormattingEnabled = true;
            cb_listaCarnes.Location = new Point(401, 181);
            cb_listaCarnes.Name = "cb_listaCarnes";
            cb_listaCarnes.Size = new Size(160, 23);
            cb_listaCarnes.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(401, 117);
            label2.Name = "label2";
            label2.Size = new Size(154, 21);
            label2.TabIndex = 26;
            label2.Text = "FIJAR PRECIO X KILO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(401, 157);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 27;
            label3.Text = "Lista de carnes:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(401, 207);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 28;
            label4.Text = "Precio x kg:";
            // 
            // Frm_Heladera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(790, 358);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cb_listaCarnes);
            Controls.Add(tb_fijarPrecio);
            Controls.Add(btn_fijarPrecioxKilo);
            Controls.Add(btn_actualizarLista);
            Controls.Add(lb_reponer);
            Controls.Add(dgv_listaCarnes);
            Controls.Add(btn_costillar);
            Controls.Add(btn_chorizo);
            Controls.Add(btn_tiraAsado);
            Controls.Add(btn_vacio);
            Controls.Add(btn_bondiola);
            Controls.Add(lb_Titulo);
            MaximizeBox = false;
            Name = "Frm_Heladera";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HELADERA";
            Load += Frm_Heladera_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_listaCarnes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}