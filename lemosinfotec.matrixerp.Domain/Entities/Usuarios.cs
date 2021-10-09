using System;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Usuarios
    {
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataCancelado { get; set; }
        public string NomeCompleto { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public string Email { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int EmpresaId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataVencimento { get; set; }
        public int DiaVencimento { get; set; }
    }
}
