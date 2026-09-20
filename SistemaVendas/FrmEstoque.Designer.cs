namespace SistemaVendas {
    partial class FrmEstoque {
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
            dgvEstoque = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(299, 26);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(138, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "CONTROLE DE ESTOQUE";
            // 
            // dgvEstoque
            // 
            dgvEstoque.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstoque.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEstoque.Location = new Point(98, 58);
            dgvEstoque.Name = "dgvEstoque";
            dgvEstoque.Size = new Size(580, 305);
            dgvEstoque.TabIndex = 1;
            dgvEstoque.CellFormatting += dgvEstoque_CellFormatting;
            // 
            // FrmEstoque
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvEstoque);
            Controls.Add(lblTitulo);
            Name = "FrmEstoque";
            Text = "FrmEstoque";
            ((System.ComponentModel.ISupportInitialize)dgvEstoque).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dgvEstoque;
    }
}