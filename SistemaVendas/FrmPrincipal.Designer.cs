namespace SistemaVendas {
    partial class FrmPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblTitulo = new Label();
            btnProdutos = new Button();
            btnClientes = new Button();
            btnVenda = new Button();
            btnEstoque = new Button();
            btnRelatorios = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(275, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(118, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE VENDAS";
            // 
            // btnProdutos
            // 
            btnProdutos.Location = new Point(131, 126);
            btnProdutos.Name = "btnProdutos";
            btnProdutos.Size = new Size(75, 23);
            btnProdutos.TabIndex = 1;
            btnProdutos.Text = "Produtos";
            btnProdutos.UseVisualStyleBackColor = true;
            btnProdutos.Click += btnProdutos_Click;
            // 
            // btnClientes
            // 
            btnClientes.Location = new Point(131, 232);
            btnClientes.Name = "btnClientes";
            btnClientes.Size = new Size(75, 23);
            btnClientes.TabIndex = 2;
            btnClientes.Text = "Clientes";
            btnClientes.UseVisualStyleBackColor = true;
            btnClientes.Click += btnClientes_Click;
            // 
            // btnVenda
            // 
            btnVenda.Location = new Point(303, 126);
            btnVenda.Name = "btnVenda";
            btnVenda.Size = new Size(75, 23);
            btnVenda.TabIndex = 3;
            btnVenda.Text = "Vendas";
            btnVenda.UseVisualStyleBackColor = true;
            btnVenda.Click += btnVendas_Click;
            // 
            // btnEstoque
            // 
            btnEstoque.Location = new Point(303, 230);
            btnEstoque.Name = "btnEstoque";
            btnEstoque.Size = new Size(75, 23);
            btnEstoque.TabIndex = 4;
            btnEstoque.Text = "Estoque";
            btnEstoque.UseVisualStyleBackColor = true;
            btnEstoque.Click += btnEstoque_Click;
            // 
            // btnRelatorios
            // 
            btnRelatorios.Location = new Point(456, 126);
            btnRelatorios.Name = "btnRelatorios";
            btnRelatorios.Size = new Size(75, 23);
            btnRelatorios.TabIndex = 5;
            btnRelatorios.Text = "Relatórios";
            btnRelatorios.UseVisualStyleBackColor = true;
            btnRelatorios.Click += btnRelatorios_Click_1;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(456, 232);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(btnRelatorios);
            Controls.Add(btnEstoque);
            Controls.Add(btnVenda);
            Controls.Add(btnClientes);
            Controls.Add(btnProdutos);
            Controls.Add(lblTitulo);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnProdutos;
        private Button btnClientes;
        private Button btnVenda;
        private Button btnEstoque;
        private Button btnRelatorios;
        private Button btnSair;
    }
}