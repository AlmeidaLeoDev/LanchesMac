﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    // Classe Lanche mapeada para a tabela Lanches
    [Table("Lanches")]
    public class Lanche
    {
        [Key]
        public int LancheId { get; set; }
        [Required(ErrorMessage = "O nome do lanche deve ser informado")]
        [Display(Name = "Nome do Lanche")]
        [StringLength(50, MinimumLength = 10, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deverá ser informado")]
        [Display(Name = "Descrição do Lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string DescricaoCurta { get; set; }
        [Required(ErrorMessage = "A descrição do lanche deve ser informado")]
        [Display(Name = "Descrição do Lanche")]
        [StringLength(200, MinimumLength = 20, ErrorMessage = "O {0} deve ter no mínimo {1} e no máximo {2} caracteres")]
        public string DescricaoDetalhada { get; set; }
        [Required(ErrorMessage = "Informe o preço do lanche")]
        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.999, ErrorMessage = "O preço deve estar entre 1 e 999.999")]
        public decimal Preco { get; set; }
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho Imagem Miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1} caracteres")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsLanchePreferido { get; set; }
        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        // Criação das propriedades de navegação através da chave primária da classe "Categoria"
        public int CategoriaId { get; set; }
        // Propriedade referência para uso da tipo "Categoria"
        public virtual Categoria Categoria { get; set; }
    }
}
