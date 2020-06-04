using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class Livro
    {
        // Método construtor da classe
        public Livro()
        {
            this.Autores = new List<Autor>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string ISBN { get; set; }
        public DateTime DataLancamento { get; set; }

        public int CategoriaID { get; set; }
        public Categoria Categoria { get; set; }

        public ICollection<Autor> Autores { get; set; }
    }
}