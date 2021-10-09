using System;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime DataVendas { get; set; }
        public string Operador { get; set; }
        public int CaixaId { get; set; }
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public decimal TotalItem { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal Peso { get; set; }
        public int VendasBaseId { get; set; }
        //public decimal TotalRecebido { get; set; }
        //public decimal Troco { get; set; }
         public decimal SubTotal { get; set; }
         public decimal ValorUnit { get; set; }
        //public int TipoPagamentoId { get; set; }
    }
}
