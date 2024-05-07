using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro // Declara o namespace Cadastro_Livro
{
    public class Login // Declara a classe pública Login
    {
        public string useremail; // Declara uma propriedade pública chamada useremail para armazenar o e-mail do usuário
        public string password; // Declara uma propriedade pública chamada password para armazenar a senha do usuário

        public Login(string email, string pass) // Declara um construtor público para a classe Login que recebe um e-mail e uma senha como parâmetros
        {
            this.useremail = email; // Atribui o valor do parâmetro user à propriedade useremail da classe
            this.password = pass; // Atribui o valor do parâmetro pass à propriedade password da classe
        }
    }
}
