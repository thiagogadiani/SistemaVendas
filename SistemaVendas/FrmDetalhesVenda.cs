using System;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmDetalhesVenda : Form {
        private Venda venda;

        public FrmDetalhesVenda(Venda vendaSelecionada) {
            InitializeComponent();

            venda = vendaSelecionada;

            CarregarDados();
        }

        private void CarregarDados() {
            lblCodigo.Text = $"Código: {venda.Codigo}";

            lblCliente.Text = $"Cliente: {venda.Cliente?.Nome ?? "Não informado"}";

            lblData.Text = $"Data: {venda.Data:dd/MM/yyyy HH:mm}";

            lblTotal.Text = $"Total da venda: {venda.Total:C}";

            dgvItens.DataSource = null;
            dgvItens.DataSource = venda.Itens;

            dgvItens.Columns["CodigoProduto"].HeaderText = "Código";
            dgvItens.Columns["Produto"].HeaderText = "Produto";
            dgvItens.Columns["Quantidade"].HeaderText = "Quantidade";
            dgvItens.Columns["Preco"].HeaderText = "Preço";
            dgvItens.Columns["Total"].HeaderText = "Total";
            dgvItens.Columns["Preco"].DefaultCellStyle.Format = "C2";
            dgvItens.Columns["Total"].DefaultCellStyle.Format = "C2";

            dgvItens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}