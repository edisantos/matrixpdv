using System;
using System.Collections.Generic;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Estoque
    {
        //Table para Estoque
        public int EstoqueId { get; set; }
        public DateTime DataRegistro { get; set; }
        public string ProdutoNome { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public double ValorUnit { get; set; }
        public int TipoProdutoId { get; set; }
        public int EstoqueMin { get; set; }
        public int FornecedorId { get; set; }
        public int EmpresaId { get; set; }
        public string FornecedorNome { get; set; }

        public ICollection<Fornecedores> Fornecedores { get; set; }
        public ICollection<Produtos> Produtos { get; set; }
    }
}
