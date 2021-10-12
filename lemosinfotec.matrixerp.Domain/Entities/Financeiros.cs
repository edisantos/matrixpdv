using System;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Financeiros
    {
        public int Id { get; set; }
        public DateTime DataVendas { get; set; }
        public string Operador { get; set; }
        public string ProdutoNome { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal ValorRecebido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorUnit { get; set; }
        public decimal Peso { get; set; }
        public string TipoPagamento { get; set; }
        public string Mes { get; set; }
    }
}
