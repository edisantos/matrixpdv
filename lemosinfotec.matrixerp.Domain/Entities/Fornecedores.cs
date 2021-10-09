namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Fornecedores
    {
        //Table Fornecedor
        public int FornecedorId { get; set; }
        public string FornecedorNome { get; set; }
        public string Cnpj { get; set; }
        public string Endereco { get; set; }
        public int Numero { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }
        public int EmpresaId { get; set; }
        public virtual Estoque Estoque { get; set; }
    }
}
