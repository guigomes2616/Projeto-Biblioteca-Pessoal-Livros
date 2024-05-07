using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;

namespace Cadastro_Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ---------------------------- Teste de Login --------------------------------------------------------

            while (!RealizarLogin())
            {
                Console.WriteLine("\n");
            }

            Console.Clear(); // Limpa a tela

            Console.WriteLine("------------ Cadastro de Livros ------------ ");

            string opcaoUsuario = ObterOpcaoUsuario(); //Chama o metodo opcaoUsuario

            while (opcaoUsuario.ToUpper() != "X") //Enquanto a opção escolhida for diferente de X
            {
                switch (opcaoUsuario) //Varias casos para a opção escolhida
                {
                    case "1":
                        //ListarLivro();
                        Console.WriteLine("\nMetodo listar livro");
                        break;

                    case "2":
                        CadastrarLivro();
                        break;

                    default:
                        Console.WriteLine("\nOpcao invalida!");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario(); // Retorna para o menu de opções
            }

            Console.WriteLine("\nObrigado por usar nosso Programa\n"); //Caso contrario (X) o programa irá se encerrar
            Console.Clear(); // Limpa a tela

           RealizarLogin(); // Chamada ao método de login novamente
        }

        // ---------------------------- Metodo Login --------------------------------------------------------------

        public static bool RealizarLogin()
        {
            Console.WriteLine("------------ Faça Login para acessar o Programa de Cadastro de Livro ------------");

            Console.Write("\nDigite [1] para se Cadastrar");
            Console.Write("\nDigite [2] para Entrar no programa\n");
            Console.Write("\nInsira a opção desejada: ");

            string opcaoLogin = Console.ReadLine().ToUpper();

            while (true) // Loop infinito até o login ser bem-sucedido ou inválido
            {
                switch (opcaoLogin) // Verifica a opção de login
                {
                    case "1":
                        CadastrarUsuario(); // Chama o método para cadastrar um novo usuário
                        return RealizarLogin(); // Realiza o login novamente após o cadastro

                    case "2":
                        VerificarLogin();
                        continue;

                    default:
                        Console.Write("\nOpcao invalida!");
                        break;
                }
            }
        }

        // ---------------------------- Metodo Menu de Opções --------------------------------------------------------------

        public static string ObterOpcaoUsuario() //Método opcaoUsuario para listagem de opções (menu)
        {
            Console.WriteLine("\nDigite [1] para Listar livros");
            Console.WriteLine("Digite [2] para Inserir novo livro");
            Console.WriteLine("Digite [X] para Sair");
            Console.Write("\nInsira a opcao desejada: ");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            return opcaoUsuario; // Retorna a opção do usuário
        }

        // ---------------------------- Metodo Cadastrar Usuario --------------------------------------------------------------

        public static Usuario CadastrarUsuario() // Método para cadastrar um novo usuário
        {
            Console.Clear(); // Limpa a tela

            Console.Write("------------ Cadastro de Usuario ------------\n");

            // Solicita informações do usuário
            Console.Write("\nDigite o seu Nome completo: ");
            string nomeUser = Console.ReadLine();

            Console.Write("\nDigite a sua Data de Nascimento (Formato: dd/mm/aa): ");
            string datanascimentoUser = Console.ReadLine();

            Console.Write("\nDigite o seu Email: ");
            string emailUser = Console.ReadLine();

            Console.Write("\nDigite como gostaria de ser Chamado(a): ");
            string nickUser = Console.ReadLine();

            Console.Write("\nCrie uma Senha: ");
            string senhaUser = Console.ReadLine();

            // Cria um novo objeto de usuário com as informações fornecidas
            Usuario novoUsuario = new Usuario(nomeUser, datanascimentoUser, emailUser, nickUser, senhaUser);

            return novoUsuario; // Retorna o novo usuário criado
        }

        // ---------------------------- Metodo Listar Livro ----------------------------------------------------------------

        public static void ListarLivros() // Método para listar os livros cadastrados
        {
            Console.Clear(); // Limpa a tela
            Console.Write("------------ Listagem de Livros Cadastrados ------------\n");
        }

        // ---------------------------- Metodo Cadastrar Livro --------------------------------------------------------------

        public static Livro CadastrarLivro() // Método para cadastrar um novo livro
        {
            Console.Clear(); // Limpa a tela
            Console.Write("------------ Cadastrar Livro ------------\n");

            foreach (int i in Enum.GetValues(typeof(Genero))) // Itera sobre os valores do enum Genero
            {
                Console.Write("\n{0} - {1}", i, Enum.GetName(typeof(Genero), i)); // Exibe cada valor do enum
            }

            Console.WriteLine("\n"); // Pula linha

            Console.Write("Digite o Genero do livro entre as opcoes acima: ");
            int generoLiv = int.Parse(Console.ReadLine());

            while (generoLiv <= 0 || generoLiv > 13) // Verifica se o gênero do livro é válido
            {
                Console.Write("\nOperacao invalida, tente novamente!\n");

                Console.Write("\nDigite o Genero do livro entre as opcoes acima: ");
                generoLiv = int.Parse(Console.ReadLine());
            }

            Console.Clear(); // Limpa a tela

            Console.Write("------------ Cadastrar Livro ------------\n");

            // Solicita informações do livro
            Console.Write("\nDigite o Titulo do Livro: ");
            string titLiv = Console.ReadLine();

            Console.Write("\nDigite o Autor do Livro: ");
            string autorLiv = Console.ReadLine();

            Console.Write("\nDigite o Ano de lançamento do Livro: ");
            int anoLiv = Convert.ToInt32(Console.ReadLine());

            int anoAtual = DateTime.Now.Year; // Obtém o ano atual do sistema

            while (anoLiv > anoAtual) // Verifica se o ano de lançamento é válido
            {
                Console.Write("\nAno de publicacao invalido, tente novamente! \n");

                Console.Write("\nDigite o Ano de lançamento do Livro ");
                anoLiv = int.Parse(Console.ReadLine());
            }

            // Cria um novo objeto Livro com as informações fornecidas
            Livro novoLivro = new Livro((Genero)generoLiv, titLiv, autorLiv, anoLiv);

            Console.Write("\n---------- Livro Cadastrado com Sucesso! ---------- \n");

            return novoLivro; // Retorna o novo livro cadastrado
        }

        public static Login VerificarLogin() // Método para verificar o login
        {
            Console.Clear(); // Limpa a tela
            Console.Write("------------ Login ------------\n");

            // Solicita o email e a senha para login
            Console.Write("\nDigite o seu Email: ");
            string emailLogin = Console.ReadLine();

            Console.Write("Digite a sua Senha: ");
            string senhaLogin = Console.ReadLine();

            string emailEntrada = emailLogin;
            string senhaEntrada = senhaLogin;

            while (emailLogin != emailEntrada && senhaLogin != senhaEntrada) // Verifica se o login é válido
            {
                Console.WriteLine("Falha no login, tente novamente!");
            }

            Login novoLogin = new Login(emailEntrada, senhaEntrada);
            return novoLogin;
        }
    }
}
