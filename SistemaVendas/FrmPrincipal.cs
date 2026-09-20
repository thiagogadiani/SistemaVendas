using System;
using System.Windows.Forms;

namespace SistemaVendas {
    public partial class FrmPrincipal : Form {
        public FrmPrincipal() {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e) {
            FrmProdutos produtos = new FrmProdutos();
            produtos.ShowDialog();
        }

        private void btnClientes_Click(object sender, EventArgs e) {
            FrmClientes clientes = new FrmClientes();
            clientes.ShowDialog();
        }

        private void btnVendas_Click(object sender, EventArgs e) {
            FrmVendas vendas = new FrmVendas();
            vendas.ShowDialog();
        }

        private void btnRelatorios_Click(object sender, EventArgs e) {
            FrmHistoricoVendas historico = new FrmHistoricoVendas();
            historico.ShowDialog();
        }

        private void btnRelatorios_Click_1(object sender, EventArgs e) {
            FrmHistoricoVendas historico = new FrmHistoricoVendas();
            historico.ShowDialog();
        }

        private void btnEstoque_Click(object sender, EventArgs e) {
            FrmEstoque estoque = new FrmEstoque();
            estoque.ShowDialog();
        }
    }
}