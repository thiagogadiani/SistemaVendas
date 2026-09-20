namespace SistemaVendas {
    partial class FrmDetalhesVenda {
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
            lblCodigo = new Label();
            lblCliente = new Label();
            lblData = new Label();
            lblTotal = new Label();
            dgvItens = new DataGridView();
            btnFechar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvItens).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(301, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(122, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "DETALHES DA VENDA";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(137, 45);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(52, 15);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "CÓDIGO";
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(137, 75);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(52, 15);
            lblCliente.TabIndex = 2;
            lblCliente.Text = "CLIENTE";
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Location = new Point(137, 101);
            lblData.Name = "lblData";
            lblData.Size = new Size(36, 15);
            lblData.TabIndex = 3;
            lblData.Text = "DATA";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(102, 406);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(127, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "Total da venda: R$ 0,00";
            // 
            // dgvItens
            // 
            dgvItens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItens.Location = new Point(93, 151);
            dgvItens.Name = "dgvItens";
            dgvItens.Size = new Size(628, 206);
            dgvItens.TabIndex = 5;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(543, 402);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(75, 23);
            btnFechar.TabIndex = 6;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // FrmDetalhesVenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFechar);
            Controls.Add(dgvItens);
            Controls.Add(lblTotal);
            Controls.Add(lblData);
            Controls.Add(lblCliente);
            Controls.Add(lblCodigo);
            Controls.Add(lblTitulo);
            Name = "FrmDetalhesVenda";
            Text = "FrmDetalhesVenda";
            ((System.ComponentModel.ISupportInitialize)dgvItens).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblCodigo;
        private Label lblCliente;
        private Label lblData;
        private Label lblTotal;
        private DataGridView dgvItens;
        private Button btnFechar;
    }
}