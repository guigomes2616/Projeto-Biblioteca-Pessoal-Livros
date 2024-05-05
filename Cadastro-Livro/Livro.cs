using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro // Define o namespace Cadastro_Livro
{
    public class Livro // Define a classe pública Livro
    {
        // Declaração de propriedades da classe Livro
        public Genero Genero { get; set; } // Propriedade para armazenar o gênero do livro
        public string Titulo { get; set; } // Propriedade para armazenar o título do livro
        public string Autor { get; set; } // Propriedade para armazenar o autor do livro
        public int AnoPubli { get; set; } // Propriedade para armazenar o ano de publicação do livro

        // Construtor da classe Livro que recebe parâmetros para inicializar as propriedades
        public Livro(Genero gen, string tit, string aut, int anop)
        {
            // Inicializa as propriedades com os valores dos parâmetros recebidos
            this.Genero = gen; // Define o gênero do livro
            this.Titulo = tit; // Define o título do livro
            this.Autor = aut; // Define o autor do livro
            this.AnoPubli = anop; // Define o ano de publicação do livro
        }
    }
}

