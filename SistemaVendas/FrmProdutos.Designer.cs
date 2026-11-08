namespace SistemaVendas {
    partial class FrmProdutos {
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
            lblCodigo = new Label();
            lblNome = new Label();
            lblPreco = new Label();
            lblEstoque = new Label();
            lblCategoria = new Label();
            txtCodigo = new TextBox();
            txtNome = new TextBox();
            txtPreco = new TextBox();
            txtEstoque = new TextBox();
            cmbCategoria = new ComboBox();
            btnCadastrar = new Button();
            btnEditar = new Button();
            btnExcluir = new Button();
            btnLimpar = new Button();
            lblTitulo = new Label();
            dgvProdutos = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).BeginInit();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(130, 100);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(46, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(130, 145);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblPreco
            // 
            lblPreco.AutoSize = true;
            lblPreco.Location = new Point(130, 187);
            lblPreco.Name = "lblPreco";
            lblPreco.Size = new Size(37, 15);
            lblPreco.TabIndex = 2;
            lblPreco.Text = "Preço";
            // 
            // lblEstoque
            // 
            lblEstoque.AutoSize = true;
            lblEstoque.Location = new Point(130, 243);
            lblEstoque.Name = "lblEstoque";
            lblEstoque.Size = new Size(49, 15);
            lblEstoque.TabIndex = 3;
            lblEstoque.Text = "Estoque";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(130, 304);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(58, 15);
            lblCategoria.TabIndex = 4;
            lblCategoria.Text = "Categoria";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(206, 100);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.ReadOnly = true;
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 5;
            txtCodigo.TextChanged += txtCodigo_TextChanged;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(206, 142);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(100, 23);
            txtNome.TabIndex = 6;
            // 
            // txtPreco
            // 
            txtPreco.Location = new Point(206, 187);
            txtPreco.Name = "txtPreco";
            txtPreco.Size = new Size(100, 23);
            txtPreco.TabIndex = 7;
            // 
            // txtEstoque
            // 
            txtEstoque.Location = new Point(206, 235);
            txtEstoque.Name = "txtEstoque";
            txtEstoque.Size = new Size(100, 23);
            txtEstoque.TabIndex = 8;
            // 
            // cmbCategoria
            // 
            cmbCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Informática", "Eletrônicos", "Móveis", "Roupas", "Alimentos", "Outros" });
            cmbCategoria.Location = new Point(206, 296);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(121, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(113, 394);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(218, 394);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(323, 394);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 12;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(419, 394);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 13;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(286, 19);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(148, 15);
            lblTitulo.TabIndex = 14;
            lblTitulo.Text = "CADASTRO DE PRODUTOS";
            // 
            // dgvProdutos
            // 
            dgvProdutos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProdutos.Location = new Point(347, 82);
            dgvProdutos.Name = "dgvProdutos";
            dgvProdutos.Size = new Size(441, 262);
            dgvProdutos.TabIndex = 15;
            dgvProdutos.CellClick += dgvProdutos_CellClick;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProdutos);
            Controls.Add(lblTitulo);
            Controls.Add(btnLimpar);
            Controls.Add(btnExcluir);
            Controls.Add(btnEditar);
            Controls.Add(btnCadastrar);
            Controls.Add(cmbCategoria);
            Controls.Add(txtEstoque);
            Controls.Add(txtPreco);
            Controls.Add(txtNome);
            Controls.Add(txtCodigo);
            Controls.Add(lblCategoria);
            Controls.Add(lblEstoque);
            Controls.Add(lblPreco);
            Controls.Add(lblNome);
            Controls.Add(lblCodigo);
            Name = "FrmProdutos";
            Text = "FrmProdutos";
            ((System.ComponentModel.ISupportInitialize)dgvProdutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNome;
        private Label lblPreco;
        private Label lblEstoque;
        private Label lblCategoria;
        private TextBox txtCodigo;
        private TextBox txtNome;
        private TextBox txtPreco;
        private TextBox txtEstoque;
        private ComboBox cmbCategoria;
        private Button btnCadastrar;
        private Button btnEditar;
        private Button btnExcluir;
        private Button btnLimpar;
        private Label lblTitulo;
        private DataGridView dgvProdutos;
    }
}