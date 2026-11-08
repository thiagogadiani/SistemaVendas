using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace SistemaVendas {
    public partial class FrmVendas : Form {

        private List<ItemVenda> itens = new List<ItemVenda>();

        public FrmVendas() {
            InitializeComponent();
            TemaSistema.Aplicar(this);
        }

        private void label3_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void btnCancelar_Click(object sender, EventArgs e) {
            DialogResult resultado = MessageBox.Show(
                "Deseja realmente cancelar esta venda?",
                "Cancelar venda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes) {
                itens.Clear();

                dgvItensVenda.DataSource = null;
                dgvItensVenda.DataSource = itens;

                txtQuantidade.Clear();
                txtPreco.Clear();
                txtTotal.Clear();

                lblTotal.Text = "Total da venda: R$ 0,00";
            }
        }

        private void FrmVendas_Load(object sender, EventArgs e) {
            cmbCliente.DataSource = null;
            cmbCliente.DataSource = DadosSistema.Clientes;
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember = "Codigo";

            cmbProduto.DataSource = null;
            cmbProduto.DataSource = DadosSistema.Produtos;
            cmbProduto.DisplayMember = "Nome";
            cmbProduto.ValueMember = "Codigo";
        }

        private void cmbProduto_SelectedIndexChanged(object sender, EventArgs e) {

            if (cmbProduto.SelectedItem is Produto produto) {
                txtPreco.Text = produto.Preco.ToString("F2");
                txtTotal.Clear();
            }
        }

        private void txtQuantidade_TextChanged(object sender, EventArgs e) {

            if (cmbProduto.SelectedItem is Produto produto &&
    int.TryParse(txtQuantidade.Text, out int quantidade)) {
                decimal total = produto.Preco * quantidade;

                txtTotal.Text = total.ToString("F2");
            }
            else {
                txtTotal.Clear();

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e) {
            if (cmbProduto.SelectedItem is not Produto produto) {
                MessageBox.Show("Selecione um produto.");
                return;
            }

            if (!int.TryParse(txtQuantidade.Text, out int quantidade) || quantidade <= 0) {
                MessageBox.Show("Informe uma quantidade válida.");
                return;
            }

            ItemVenda item = new ItemVenda {
                CodigoProduto = produto.Codigo,
                Produto = produto.Nome,
                Quantidade = quantidade,
                Preco = produto.Preco,
                Total = produto.Preco * quantidade
            };

            itens.Add(item);

            dgvItensVenda.DataSource = null;
            dgvItensVenda.DataSource = itens;

            AtualizarTotalVenda();
        }

        private void AtualizarTotalVenda() {
            decimal total = 0;

            foreach (ItemVenda item in itens) {
                total += item.Total;
            }

            lblTotal.Text = $"Total da venda: {total:C}";
        }

        private void btnFinalizar_Click(object sender, EventArgs e) {
            if (cmbCliente.SelectedItem == null) {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            if (itens.Count == 0) {
                MessageBox.Show("Adicione pelo menos um produto à venda.");
                return;
            }

            // Primeiro verificamos se existe estoque suficiente
            foreach (ItemVenda item in itens) {
                Produto? produto = DadosSistema.Produtos
                    .FirstOrDefault(p => p.Codigo == item.CodigoProduto);

                if (produto == null) {
                    MessageBox.Show(
                        $"Produto '{item.Produto}' não foi encontrado."
                    );
                    return;
                }

                if (item.Quantidade > produto.Estoque) {
                    MessageBox.Show(
                        $"Estoque insuficiente para o produto '{produto.Nome}'.\n\n" +
                        $"Estoque disponível: {produto.Estoque}\n" +
                        $"Quantidade solicitada: {item.Quantidade}"
                    );

                    return;
                }
            }

            DialogResult resultado = MessageBox.Show(
                "Deseja realmente finalizar esta venda?",
                "Finalizar venda",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.No) {
                return;
            }

            // Baixa o estoque dos produtos vendidos
            foreach (ItemVenda item in itens) {
                Produto? produto = DadosSistema.Produtos
                    .FirstOrDefault(p => p.Codigo == item.CodigoProduto);

                if (produto != null) {
                    produto.Estoque -= item.Quantidade;
                }
            }

            // Cria o registro da venda
            Venda venda = new Venda {
                Codigo = DadosSistema.Vendas.Count + 1,
                Cliente = (Cliente)cmbCliente.SelectedItem,
                Data = DateTime.Now,
                Itens = new List<ItemVenda>(itens),
                Total = itens.Sum(item => item.Total)
            };

            // Salva a venda no sistema
            DadosSistema.Vendas.Add(venda);

            MessageBox.Show(
                "Venda finalizada com sucesso!",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // Limpa os itens da venda
            itens.Clear();

            dgvItensVenda.DataSource = null;
            dgvItensVenda.DataSource = itens;

            txtQuantidade.Clear();
            txtPreco.Clear();
            txtTotal.Clear();

            lblTotal.Text = "Total da venda: R$ 0,00";
        }

        private void dgvItensVenda_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
