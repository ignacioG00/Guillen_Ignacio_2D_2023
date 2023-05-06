﻿namespace Vista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Heladera));
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listaCarnes)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.BackColor = System.Drawing.Color.Transparent;
            this.lb_Titulo.Font = new System.Drawing.Font("Showcard Gothic", 39.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_Titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lb_Titulo.Location = new System.Drawing.Point(241, 26);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(294, 66);
            this.lb_Titulo.TabIndex = 0;
            this.lb_Titulo.Text = "HELADERA";
            // 
            // btn_bondiola
            // 
            this.btn_bondiola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_bondiola.Location = new System.Drawing.Point(51, 213);
            this.btn_bondiola.Name = "btn_bondiola";
            this.btn_bondiola.Size = new System.Drawing.Size(69, 35);
            this.btn_bondiola.TabIndex = 1;
            this.btn_bondiola.Text = "Bondiola";
            this.btn_bondiola.UseVisualStyleBackColor = false;
            this.btn_bondiola.Click += new System.EventHandler(this.btn_bondiola_Click);
            // 
            // btn_vacio
            // 
            this.btn_vacio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_vacio.Location = new System.Drawing.Point(126, 213);
            this.btn_vacio.Name = "btn_vacio";
            this.btn_vacio.Size = new System.Drawing.Size(69, 35);
            this.btn_vacio.TabIndex = 2;
            this.btn_vacio.Text = "Vacio";
            this.btn_vacio.UseVisualStyleBackColor = false;
            this.btn_vacio.Click += new System.EventHandler(this.btn_vacio_Click);
            // 
            // btn_tiraAsado
            // 
            this.btn_tiraAsado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_tiraAsado.Location = new System.Drawing.Point(201, 213);
            this.btn_tiraAsado.Name = "btn_tiraAsado";
            this.btn_tiraAsado.Size = new System.Drawing.Size(69, 35);
            this.btn_tiraAsado.TabIndex = 3;
            this.btn_tiraAsado.Text = "Asado";
            this.btn_tiraAsado.UseVisualStyleBackColor = false;
            this.btn_tiraAsado.Click += new System.EventHandler(this.btn_tiraAsado_Click);
            // 
            // btn_chorizo
            // 
            this.btn_chorizo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_chorizo.Location = new System.Drawing.Point(276, 213);
            this.btn_chorizo.Name = "btn_chorizo";
            this.btn_chorizo.Size = new System.Drawing.Size(69, 35);
            this.btn_chorizo.TabIndex = 4;
            this.btn_chorizo.Text = "Chorizo";
            this.btn_chorizo.UseVisualStyleBackColor = false;
            this.btn_chorizo.Click += new System.EventHandler(this.btn_chorizo_Click);
            // 
            // btn_costillar
            // 
            this.btn_costillar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_costillar.Location = new System.Drawing.Point(351, 213);
            this.btn_costillar.Name = "btn_costillar";
            this.btn_costillar.Size = new System.Drawing.Size(69, 35);
            this.btn_costillar.TabIndex = 5;
            this.btn_costillar.Text = "Costillar";
            this.btn_costillar.UseVisualStyleBackColor = false;
            this.btn_costillar.Click += new System.EventHandler(this.btn_costillar_Click);
            // 
            // dgv_listaCarnes
            // 
            this.dgv_listaCarnes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listaCarnes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corteCarne,
            this.cantidad,
            this.precio});
            this.dgv_listaCarnes.Location = new System.Drawing.Point(51, 278);
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
            this.lb_reponer.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.lb_reponer.ForeColor = System.Drawing.Color.Blue;
            this.lb_reponer.Location = new System.Drawing.Point(49, 181);
            this.lb_reponer.Name = "lb_reponer";
            this.lb_reponer.Size = new System.Drawing.Size(146, 20);
            this.lb_reponer.TabIndex = 7;
            this.lb_reponer.Text = "REPONER CARNES";
            // 
            // Frm_Heladera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(768, 440);
            this.Controls.Add(this.lb_reponer);
            this.Controls.Add(this.dgv_listaCarnes);
            this.Controls.Add(this.btn_costillar);
            this.Controls.Add(this.btn_chorizo);
            this.Controls.Add(this.btn_tiraAsado);
            this.Controls.Add(this.btn_vacio);
            this.Controls.Add(this.btn_bondiola);
            this.Controls.Add(this.lb_Titulo);
            this.Name = "Frm_Heladera";
            this.Text = "Frm_Heladera";
            this.Load += new System.EventHandler(this.Frm_Heladera_Load);
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
    }
}