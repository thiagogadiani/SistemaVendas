using System;
using System.Linq;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmEstoque : Form {
        public FrmEstoque() {
            InitializeComponent();

            CarregarEstoque();
        }

        private void CarregarEstoque() {
            var estoque = DadosSistema.Produtos.Select(p => new
            {
                Codigo = p.Codigo,
                Produto = p.Nome,
                Categoria = p.Categoria,
                Estoque = p.Estoque,
                Situacao = p.Estoque == 0
                    ? "Sem estoque"
                    : p.Estoque <= 5
                        ? "Estoque baixo"
                        : "Normal"
            }).ToList();

            dgvEstoque.DataSource = estoque;
        }

        private void dgvEstoque_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e) {

            if (e.RowIndex < 0)
                return;

            if (dgvEstoque.Rows[e.RowIndex].Cells["Estoque"].Value == null)
                return;

            int estoque = Convert.ToInt32(
                dgvEstoque.Rows[e.RowIndex].Cells["Estoque"].Value
            );

            if (estoque <= 5) {
                dgvEstoque.Rows[e.RowIndex].DefaultCellStyle.Font =
                    new Font(dgvEstoque.Font, FontStyle.Bold);
            }

        }
    }
}