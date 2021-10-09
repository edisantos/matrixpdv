namespace lemosinfotec.matrixerp.Domain.Entities
{
    public class Empresas
    {
        public int EmpresaId { get; set; }

        public string EmpresaNome { get; set; }

        public int ParceiroId { get; set; }
        public int ContaEmpresaid { get; set; }
        public virtual Parceiros Parceiros { get; set; }
        public virtual ContaEmpresas ContaEmpresas { get; set; }
    }
}
