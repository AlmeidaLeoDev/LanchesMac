namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; } 
        public string Nome { get; set; }
        public string DescricaoCurta { get; set; }
        public string DescricaoDetalhada { get; set; }
        public int MyProperty { get; set; }
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; }
        public string ImagemThumbnailUrl { get; set; }
        public int MyProperty1 { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }

        // Criação das propriedades de navegação através da chave primária da classe "Categoria"
        public int CategoriaId { get; set; }
        // Propriedade referência para uso da tipo "Categoria"
        public virtual Categoria Categoria { get; set; }
    }
}
