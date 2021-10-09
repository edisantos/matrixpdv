using System;
using System.Collections.Generic;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Parceiros
    {
        public int ParceiroId { get; set; }
        public DateTime DataCadastro { get; set; }
        public string Nome { get; set; }
        public string Endereceo { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int EmpresaId { get; set; }

        public ICollection<Empresas> Empresas { get; set; }
        public ContaEmpresas ContaEmpresas { get; set; } 

    }
}
