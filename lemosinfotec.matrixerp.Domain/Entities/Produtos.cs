namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Produtos
    {
        public int ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public string CodeBarra { get; set; }
        public int Total { get; set; }
        public int EmpresaId { get; set; }
        public Estoque Estoque { get; set; }
    }
}
