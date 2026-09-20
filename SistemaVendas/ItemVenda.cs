using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaVendas {
    public class ItemVenda {
        public int CodigoProduto { get; set; }

        public string Produto { get; set; } = string.Empty;

        public int Quantidade { get; set; }

        public decimal Preco { get; set; }

        public decimal Total { get; set; }
    }
}
