namespace Vista
{
    partial class Frm_Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_login = new Button();
            btn_autoVendedor = new Button();
            label1 = new Label();
            label2 = new Label();
            tb_usuario = new TextBox();
            tb_contra = new TextBox();
            btn_autoCliente = new Button();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(406, 180);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(122, 40);
            btn_login.TabIndex = 0;
            btn_login.Text = "LOGIN";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_autoVendedor
            // 
            btn_autoVendedor.Location = new Point(201, 296);
            btn_autoVendedor.Name = "btn_autoVendedor";
            btn_autoVendedor.Size = new Size(122, 40);
            btn_autoVendedor.TabIndex = 1;
            btn_autoVendedor.Text = "AUTO. VENDEDOR";
            btn_autoVendedor.UseVisualStyleBackColor = true;
            btn_autoVendedor.Click += btn_autoVendedor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 119);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 220);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            // 
            // tb_usuario
            // 
            tb_usuario.BackColor = SystemColors.InactiveCaption;
            tb_usuario.Location = new Point(178, 137);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.Size = new Size(180, 23);
            tb_usuario.TabIndex = 4;
            // 
            // tb_contra
            // 
            tb_contra.BackColor = SystemColors.InactiveCaption;
            tb_contra.Location = new Point(178, 238);
            tb_contra.Name = "tb_contra";
            tb_contra.PasswordChar = '*';
            tb_contra.Size = new Size(180, 23);
            tb_contra.TabIndex = 5;
            // 
            // btn_autoCliente
            // 
            btn_autoCliente.Location = new Point(389, 296);
            btn_autoCliente.Name = "btn_autoCliente";
            btn_autoCliente.Size = new Size(122, 40);
            btn_autoCliente.TabIndex = 6;
            btn_autoCliente.Text = "AUTO. VENDEDOR";
            btn_autoCliente.UseVisualStyleBackColor = true;
            btn_autoCliente.Click += btn_autoCliente_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_autoCliente);
            Controls.Add(tb_contra);
            Controls.Add(tb_usuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_autoVendedor);
            Controls.Add(btn_login);
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CARNICERIA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_autoVendedor;
        private Label label1;
        private Label label2;
        private TextBox tb_usuario;
        private TextBox tb_contra;
        private Button btn_autoCliente;
    }
}