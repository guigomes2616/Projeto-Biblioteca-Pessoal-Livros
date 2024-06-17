using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro // Define o namespace Cadastro_Livro
{
    public class Livro
    {
        public string Titulo { get; set; } // Propriedade para armazenar o título do livro
        public string Autor { get; set; } // Propriedade para armazenar o autor do livro
        public int AnoPubli { get; set; } // Propriedade para armazenar o ano de publicação do livro

        // Construtor da classe Livro que recebe parâmetros para inicializar as propriedades
        public Livro(string titulo, string autor, int anoPubli)
        {
            // Inicializa as propriedades com os valores dos parâmetros recebidos
            this.Titulo = titulo;
            this.Autor = autor;
            this.AnoPubli = anoPubli;
        }
    }
}

