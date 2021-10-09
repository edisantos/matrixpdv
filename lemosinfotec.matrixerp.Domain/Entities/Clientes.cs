using System;

namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Clientes
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string ClienteNome { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
       
    }
}
