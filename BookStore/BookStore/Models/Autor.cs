using System.Collections.Generic;

namespace BookStore.Models
{
    public class Autor
    {

        // Método construtor da classe
        public Autor()
        {
            this.Livros = new List<Livro>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public ICollection<Livro> Livros { get; set; }
    }
}