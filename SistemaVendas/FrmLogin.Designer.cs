namespace SistemaVendas {
    partial class FrmLogin {
        /// <summary>
        /// Variável necessária para o suporte ao Designer.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpa os recursos utilizados.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font(
                "Segoe UI",
                16F,
                System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point
            );
            this.lblTitulo.Location = new System.Drawing.Point(100, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 30);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SISTEMA DE VENDAS";

            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(80, 120);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário";

            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(80, 140);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(215, 23);
            this.txtUsuario.TabIndex = 2;

            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(80, 190);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(39, 15);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";

            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(80, 210);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(215, 23);
            this.txtSenha.TabIndex = 4;
            this.txtSenha.UseSystemPasswordChar = true;

            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(80, 260);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(80, 30);
            this.btnEntrar.TabIndex = 5;
            this.btnEntrar.Text = "ENTRAR";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);

            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 350);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login - Sistema de Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Button btnEntrar;
    }
}