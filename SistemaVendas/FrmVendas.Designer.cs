namespace SistemaVendas {
    partial class FrmVendas {
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
            lblCliente = new Label();
            lblProduto = new Label();
            lblQuantidade = new Label();
            lblPreco = new Label();
            lblTotal = new Label();
            cmbCliente = new ComboBox();
            cmbProduto = new ComboBox();
            txtPreco = new TextBox();
            txtQuantidade = new TextBox();
            txtTotal = new TextBox();
            btnAdicionar = new Button();
            btnFinalizar = new Button();
            btnCancelar = new Button();
            dgvItensVenda = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(318, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(80, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "NOVA VENDA";
            lblTitulo.Click += label1_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(119, 118);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(44, 15);
            lblCliente.TabIndex = 1;
            lblCliente.Text = "Cliente";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Location = new Point(119, 170);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(50, 15);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Produto";
            lblProduto.Click += label3_Click;
            // 
            // lblQuantidade
            // 
            lblQuantidade.AutoSize = true;
            lblQuantidade.Location = new Point(119, 227);
            lblQuantidade.Name = "lblQuantidade";
            lblQuantidade.Size = new Size(69, 15);
            lblQuantidade.TabIndex = 3;
            lblQuantidade.Text = "Quantidade";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(126, 268);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 4;
            lblPreco.Text = "Preço";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(79, 311);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(84, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "Total da venda";
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(169, 118);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 6;
            // 
            // cmbProduto
            // 
            cmbProduto.FormattingEnabled = true;
            cmbProduto.Location = new Point(169, 170);
            cmbProduto.Name = "cmbProduto";
            cmbProduto.Size = new Size(121, 23);
            cmbProduto.TabIndex = 7;
            cmbProduto.SelectedIndexChanged += cmbProduto_SelectedIndexChanged;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(190, 260);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 8;
            // 
            // txtQuantidade
            // 
            txtQuantidade.Location = new Point(190, 219);
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.Size = new Size(100, 23);
            txtQuantidade.TabIndex = 9;
            txtQuantidade.TextChanged += txtQuantidade_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(224, 303);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(100, 23);
            txtTotal.TabIndex = 10;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(126, 396);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(86, 23);
            btnAdicionar.TabIndex = 11;
            btnAdicionar.Text = "ADICIONAR";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnFinalizar
            // 
            btnFinalizar.Location = new Point(249, 396);
            btnFinalizar.Name = "btnFinalizar";
            btnFinalizar.Size = new Size(113, 23);
            btnFinalizar.TabIndex = 12;
            btnFinalizar.Text = "FINALIZAR VENDA";
            btnFinalizar.UseVisualStyleBackColor = true;
            btnFinalizar.Click += btnFinalizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(395, 396);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // dgvItensVenda
            // 
            dgvItensVenda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensVenda.Location = new Point(450, 118);
            dgvItensVenda.Name = "dgvItensVenda";
            dgvItensVenda.Size = new Size(240, 150);
            dgvItensVenda.TabIndex = 14;
            // 
            // FrmVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvItensVenda);
            Controls.Add(btnCancelar);
            Controls.Add(btnFinalizar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtTotal);
            Controls.Add(txtQuantidade);
            Controls.Add(txtPreco);
            Controls.Add(cmbProduto);
            Controls.Add(cmbCliente);
            Controls.Add(lblTotal);
            Controls.Add(lblPreco);
            Controls.Add(lblQuantidade);
            Controls.Add(lblProduto);
            Controls.Add(lblCliente);
            Controls.Add(lblTitulo);
            Name = "FrmVendas";
            Text = "FrmVendas";
            Load += FrmVendas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvItensVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCliente;
        private Label lblProduto;
        private Label lblQuantidade;
        private Label lblPreco;
        private Label lblTotal;
        private ComboBox cmbCliente;
        private ComboBox cmbProduto;
        private TextBox txtPreco;
        private TextBox txtQuantidade;
        private TextBox txtTotal;
        private Button btnAdicionar;
        private Button btnFinalizar;
        private Button btnCancelar;
        private DataGridView dgvItensVenda;
    }
}