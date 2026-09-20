using System.Collections.Generic;
using System.Linq;

namespace SistemaVendas {
    public partial class FrmProdutos : Form {
        private List<Produto> produtos => DadosSistema.Produtos;

        public FrmProdutos() {
            InitializeComponent();

            dgvProdutos.DataSource = produtos;

            txtCodigo.Text = GerarProximoCodigo().ToString();
        }
        private int GerarProximoCodigo() {
            if (produtos.Count == 0)
                return 1;

            return produtos.Max(p => p.Codigo) + 1;
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (!int.TryParse(txtCodigo.Text, out int codigo)) {
                MessageBox.Show("Informe um código válido.");
                return;
            }

            if (produtos.Any(p => p.Codigo == codigo)) {
                MessageBox.Show("Já existe um produto com esse código.");
                return;
            }


            if (string.IsNullOrWhiteSpace(txtNome.Text)) {
                MessageBox.Show("Informe o nome do produto.");
                return;
            }

            if (cmbCategoria.SelectedIndex == -1) {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }

            if (!decimal.TryParse(txtPreco.Text, out decimal preco)) {
                MessageBox.Show("Informe um preço válido.");
                return;
            }

            if (!int.TryParse(txtEstoque.Text, out int estoque)) {
                MessageBox.Show("Informe um estoque válido.");
                return;
            }

            Produto produto = new Produto {
                Codigo = codigo,
                Nome = txtNome.Text,
                Preco = preco,
                Estoque = estoque,
                Categoria = cmbCategoria.Text
            };

            produtos.Add(produto);

            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;

            MessageBox.Show(
                $"Produto cadastrado!\n\n" +
                $"Código: {produto.Codigo}\n" +
                $"Nome: {produto.Nome}\n" +
                $"Preço: {produto.Preco:C}\n" +
                $"Estoque: {produto.Estoque}\n" +
                $"Categoria: {produto.Categoria}"

            );
            txtCodigo.Text = GerarProximoCodigo().ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e) {
            txtNome.Clear();
            txtPreco.Clear();
            txtEstoque.Clear();
            cmbCategoria.SelectedIndex = -1;

            txtCodigo.Text = GerarProximoCodigo().ToString();
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0)
                return;

            Produto produto = (Produto)dgvProdutos.Rows[e.RowIndex].DataBoundItem;

            txtCodigo.Text = produto.Codigo.ToString();
            txtNome.Text = produto.Nome;
            txtPreco.Text = produto.Preco.ToString();
            txtEstoque.Text = produto.Estoque.ToString();
            cmbCategoria.Text = produto.Categoria;
        }

        private void btnEditar_Click(object sender, EventArgs e) {
            if (dgvProdutos.CurrentRow == null) {
                MessageBox.Show("Selecione um produto para editar.");
                return;
            }

            Produto produto = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

            // Validar código
            if (!int.TryParse(txtCodigo.Text, out int codigo)) {
                MessageBox.Show("Informe um código válido.");
                return;
            }

            // Verificar se o código já pertence a OUTRO produto
            bool codigoDuplicado = produtos.Any(p =>
                p.Codigo == codigo && p != produto
            );

            if (codigoDuplicado) {
                MessageBox.Show("Já existe outro produto com esse código.");
                return;
            }

            // Validar nome
            if (string.IsNullOrWhiteSpace(txtNome.Text)) {
                MessageBox.Show("Informe o nome do produto.");
                return;
            }

            // Validar categoria
            if (cmbCategoria.SelectedIndex == -1) {
                MessageBox.Show("Selecione uma categoria.");
                return;
            }

            // Validar preço
            if (!decimal.TryParse(txtPreco.Text, out decimal preco)) {
                MessageBox.Show("Informe um preço válido.");
                return;
            }

            // Validar estoque
            if (!int.TryParse(txtEstoque.Text, out int estoque)) {
                MessageBox.Show("Informe um estoque válido.");
                return;
            }

            // Alterar o produto
            produto.Codigo = codigo;
            produto.Nome = txtNome.Text;
            produto.Preco = preco;
            produto.Estoque = estoque;
            produto.Categoria = cmbCategoria.Text;

            // Atualizar tabela
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = produtos;

            MessageBox.Show("Produto alterado com sucesso!");
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            if (dgvProdutos.CurrentRow == null) {
                MessageBox.Show("Selecione um produto para excluir.");
                return;
            }

            Produto produto = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

            DialogResult resultado = MessageBox.Show(
                $"Deseja realmente excluir o produto '{produto.Nome}'?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes) {
                produtos.Remove(produto);

                dgvProdutos.DataSource = null;
                dgvProdutos.DataSource = produtos;

                MessageBox.Show("Produto excluído com sucesso!");
            }

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e) {

        }
    }
}