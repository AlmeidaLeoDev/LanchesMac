﻿namespace LanchesMac.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }
        public string CategoriaNome { get; set; }
        public string Descricao { get; set; }

        // Relacionamento "um-para-muito"
        public List<Lanche> Lanches { get; set; } 
    }
}
