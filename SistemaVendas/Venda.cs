using System;
using System.Collections.Generic;

namespace SistemaVendas {
    public class Venda {
        public int Codigo { get; set; }

        public Cliente? Cliente { get; set; }

        public DateTime Data { get; set; }

        public List<ItemVenda> Itens { get; set; } = new List<ItemVenda>();

        public decimal Total { get; set; }
    }
}