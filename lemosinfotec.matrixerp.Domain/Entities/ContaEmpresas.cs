using System;
using System.Collections.Generic;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class ContaEmpresas
    {
        public int ContaEmpresaId { get; set; }
        public int EmpresaId { get; set; }
        public int ParceiroId { get; set; }
        public DateTime DataVencimento { get; set; }
        public string StatusPagamento { get; set; }
        public int Ativo { get; set; }

        public ICollection<Empresas> Empresas { get; set; }
        public ICollection<Parceiros> Parceiros { get; set; }
    }
}
