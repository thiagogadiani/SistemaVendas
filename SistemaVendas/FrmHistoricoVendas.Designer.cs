namespace SistemaVendas {
    partial class FrmHistoricoVendas {
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
            dgvVendas = new DataGridView();
            btnFechar = new Button();
            btnDetalhes = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvVendas).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(295, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(131, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "HISTÓRICO DE VENDAS";
            // 
            // dgvVendas
            // 
            dgvVendas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVendas.Location = new Point(98, 51);
            dgvVendas.Name = "dgvVendas";
            dgvVendas.Size = new Size(548, 304);
            dgvVendas.TabIndex = 1;
            dgvVendas.CellContentClick += dgvVendas_CellContentClick;
            dgvVendas.CellDoubleClick += dgvVendas_CellDoubleClick;
            // 
            // btnFechar
            // 
            btnFechar.Location = new Point(470, 377);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(104, 30);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "FECHAR";
            btnFechar.UseVisualStyleBackColor = true;
            // 
            // btnDetalhes
            // 
            btnDetalhes.Location = new Point(185, 384);
            btnDetalhes.Name = "btnDetalhes";
            btnDetalhes.Size = new Size(114, 23);
            btnDetalhes.TabIndex = 3;
            btnDetalhes.Text = "VER DETALHES";
            btnDetalhes.UseVisualStyleBackColor = true;
            btnDetalhes.Click += btnDetalhes_Click;
            // 
            // FrmHistoricoVendas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDetalhes);
            Controls.Add(btnFechar);
            Controls.Add(dgvVendas);
            Controls.Add(lblTitulo);
            Name = "FrmHistoricoVendas";
            Text = "FrmHistoricoVendas";
            ((System.ComponentModel.ISupportInitialize)dgvVendas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvVendas;
        private Button btnFechar;
        private Button btnDetalhes;
    }
}