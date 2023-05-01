namespace Forms
{
    partial class Frm_Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_login = new System.Windows.Forms.Button();
            this.tb_usuario = new System.Windows.Forms.TextBox();
            this.tb_contra = new System.Windows.Forms.TextBox();
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_contra = new System.Windows.Forms.Label();
            this.btn_autocompletar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(501, 156);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "ENTRAR";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // tb_usuario
            // 
            this.tb_usuario.Location = new System.Drawing.Point(301, 125);
            this.tb_usuario.Name = "tb_usuario";
            this.tb_usuario.Size = new System.Drawing.Size(158, 20);
            this.tb_usuario.TabIndex = 1;
            // 
            // tb_contra
            // 
            this.tb_contra.Location = new System.Drawing.Point(301, 196);
            this.tb_contra.Name = "tb_contra";
            this.tb_contra.Size = new System.Drawing.Size(158, 20);
            this.tb_contra.TabIndex = 2;
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.Location = new System.Drawing.Point(298, 109);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(35, 13);
            this.lb_usuario.TabIndex = 3;
            this.lb_usuario.Text = "label1";
            // 
            // lb_contra
            // 
            this.lb_contra.AutoSize = true;
            this.lb_contra.Location = new System.Drawing.Point(298, 180);
            this.lb_contra.Name = "lb_contra";
            this.lb_contra.Size = new System.Drawing.Size(35, 13);
            this.lb_contra.TabIndex = 4;
            this.lb_contra.Text = "label2";
            // 
            // btn_autocompletar
            // 
            this.btn_autocompletar.Location = new System.Drawing.Point(501, 288);
            this.btn_autocompletar.Name = "btn_autocompletar";
            this.btn_autocompletar.Size = new System.Drawing.Size(132, 37);
            this.btn_autocompletar.TabIndex = 5;
            this.btn_autocompletar.Text = "AUTOCOMPLETAR";
            this.btn_autocompletar.UseVisualStyleBackColor = true;
            // 
            // Frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_autocompletar);
            this.Controls.Add(this.lb_contra);
            this.Controls.Add(this.lb_usuario);
            this.Controls.Add(this.tb_contra);
            this.Controls.Add(this.tb_usuario);
            this.Controls.Add(this.btn_login);
            this.Name = "Frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CARNICERIA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.TextBox tb_usuario;
        private System.Windows.Forms.TextBox tb_contra;
        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_contra;
        private System.Windows.Forms.Button btn_autocompletar;
    }
}

