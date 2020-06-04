using System.Collections.Generic;

namespace BookStore.Models
{
    public class Categoria
    {
        // Método construtor da classe
        public Categoria()
        {
            this.Livros = new List<Livro>();
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}