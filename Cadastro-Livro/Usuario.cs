using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro // Define o namespace Cadastro_Livro
{
    internal class Usuario : Login // Define a classe interna Usuario
    {
        // Declaração de propriedades da classe Usuario
        public string Nome { get; set; } // Propriedade para armazenar o nome do usuário
        public string DataNascimento { get; set; } // Propriedade para armazenar a data de nascimento do usuário
        public string Nickname { get; set; } // Propriedade para armazenar o apelido do usuário

        // Construtor da classe Usuario que recebe parâmetros para inicializar as propriedades
        public Usuario(string n, string dataNas, string email, string nickname, string pass) : base(email, pass)
        {
            // Inicializa as propriedades com os valores dos parâmetros recebidos
            this.Nome = n; // Define o nome do usuário
            this.DataNascimento = dataNas; // Define a data de nascimento do usuário
            this.Nickname = nickname; // Define o apelido do usuário
        }
    }
}

