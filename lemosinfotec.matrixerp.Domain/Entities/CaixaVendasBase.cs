using System;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class CaixaVendasBase
    {
        public int Id { get; set; }
        public DateTime DataVendas { get; set; }
        public decimal? ValorRecebido { get; set; }
        public decimal? ValorPago { get; set; }
        public decimal? ValorTroco { get; set; }
        public int TipoPagamentoId { get; set; }
        public int CaixaId { get; set; }
        public int StatusVendas { get; set; }
        public int EmpresaId { get; set; }
    }
}
