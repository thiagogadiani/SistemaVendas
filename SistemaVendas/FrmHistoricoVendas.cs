using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmHistoricoVendas : Form {
        public FrmHistoricoVendas() {
            InitializeComponent();

            CarregarVendas();
        }

        private void CarregarVendas() {
            var vendas = DadosSistema.Vendas.Select(v => new {
                Codigo = v.Codigo,
                Cliente = v.Cliente?.Nome ?? "Não informado",
                Data = v.Data.ToString("dd/MM/yyyy HH:mm"),
                Total = v.Total.ToString("C")
            }).ToList();

            dgvVendas.DataSource = vendas;
        }

        private void btnFechar_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void dgvVendas_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }

        private void dgvVendas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;

            int codigo = Convert.ToInt32(
                dgvVendas.Rows[e.RowIndex].Cells["Codigo"].Value
            );

            Venda? venda = DadosSistema.Vendas
                .FirstOrDefault(v => v.Codigo == codigo);

            if (venda == null) {
                MessageBox.Show("Venda não encontrada.");
                return;
            }

            FrmDetalhesVenda detalhes = new FrmDetalhesVenda(venda);

            detalhes.ShowDialog();
        }

        private void btnDetalhes_Click(object sender, EventArgs e) {
            if (dgvVendas.CurrentRow == null) {
                MessageBox.Show("Selecione uma venda.");
                return;
            }

            int codigo = Convert.ToInt32(
                dgvVendas.CurrentRow.Cells["Codigo"].Value
            );

            Venda? venda = DadosSistema.Vendas
                .FirstOrDefault(v => v.Codigo == codigo);

            if (venda == null) {
                MessageBox.Show("Venda não encontrada.");
                return;
            }

            FrmDetalhesVenda detalhes = new FrmDetalhesVenda(venda);

            detalhes.ShowDialog();
        }
    }
}