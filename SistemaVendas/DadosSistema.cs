using System.Collections.Generic;

namespace SistemaVendas {
    public static class DadosSistema {
        public static List<Cliente> Clientes { get; set; } = new List<Cliente>();

        public static List<Produto> Produtos { get; set; } = new List<Produto>();

        public static List<Venda> Vendas { get; set; } = new List<Venda>();

    }
}