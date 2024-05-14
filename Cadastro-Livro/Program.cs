using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MySql.Data;

namespace Cadastro_Livro
{
    internal class Program
    {
        static List<Livro> livros = new List<Livro>();
        static List<Usuario> usuarios = new List<Usuario>();

        static void Main(string[] args)
        {
            RealizarLogin();

            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarLivros();
                        break;
                    case "2":
                        CadastrarLivro();
                        break;
                    default:
                        Console.Write("\nOpção inválida! tente novamente: \n");
                        opcaoUsuario = Console.ReadLine();
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
            SairPrograma();

            RealizarLogin();
        }
//----------------------------------------------------------------------------------------------------------------------------------
        public static void RealizarLogin()
        {
            Console.WriteLine("------------ Faça Login para acessar o Programa de Cadastro de Livro ------------\n");

            Console.Write("Digite [1] para se Cadastrar\n");
            Console.Write("Digite [2] para Entrar no programa\n");
            Console.Write("Digite [X] para Sair do programa \n");

            Console.Write("\nInsira a opção desejada: ");

            string opcaoLogin = Console.ReadLine().ToUpper();

            switch (opcaoLogin)
            {
                case "1":
                    CadastrarUsuario();
                    RealizarLogin();
                    break;

                case "2":
                    bool loginSucesso = false;

                    while (!loginSucesso)
                    {
                        if (VerificarLogin() != null)
                        {
                            loginSucesso = true;
                        }
                        else
                        {
                            Console.Write("\nFalha no Login, deseja continuar?(S/N): \n");
                            string resLogin = Console.ReadLine();

                            if (resLogin.ToUpper() == "S")
                            {
                                VerificarLogin();
                            }
                            else if (resLogin.ToUpper() == "N")
                            {
                                RealizarLogin();
                            }
                        }
                    }
                    break;

                case "X":
                    loginSucesso = false;
                    SairPrograma();
                    Environment.Exit(0);
                    break;

                default:
                    while (opcaoLogin != "X" && opcaoLogin != "1" && opcaoLogin != "2")
                    {
                        Console.Write("\nOpcao invalida! tente novamente: ");
                        opcaoLogin = Console.ReadLine();
                    }
                        RealizarLogin();
                        break;
                }
        }
// -------------------------------------------------------------------------------------------------------------------------------
        public static string ObterOpcaoUsuario()
        {
            Console.Write("------------ Menu de Opcoes ------------\n");

            Console.WriteLine("\nDigite [1] para Listar livros");
            Console.WriteLine("Digite [2] para Inserir novo livro");
            Console.WriteLine("Digite [X] para Sair");
            Console.Write("\nInsira a opcao desejada: ");

            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();

            return opcaoUsuario;
        }
// -------------------------------------------------------------------------------------------------------------------------------
        public static Usuario CadastrarUsuario()
        {
            Console.Clear();
            Console.Write("------------ Cadastro de Usuario ------------\n");

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

            Usuario novoUsuario = new Usuario(nomeUser, datanascimentoUser, emailUser, nickUser, senhaUser);
            usuarios.Add(novoUsuario);

            Console.WriteLine();

            return novoUsuario;
        }
 //----------------------------------------------------------------------------------------------------------------------------
        public static void ListarLivros()
        {
            Console.WriteLine("---------- Lista de seus Livros ---------- \n");

            if (livros.Count == 0)
            {
                Console.WriteLine("\nNenhum livro cadastrado \n");
            }
            else
            {
                foreach (var livro in livros)
                {
                    Console.WriteLine($"Titulo: {livro.Titulo} | Autor: {livro.Autor} | Ano de Publicação: {livro.AnoPubli} | Gênero: {livro.Genero}");
                }
            }

            Console.WriteLine();
        }
 // --------------------------------------------------------------------------------------------------------------------------------
        public static Livro CadastrarLivro()
        {
            Console.Clear();
            Console.Write("------------ Cadastrar Livro - Genero ------------\n");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.Write("\n{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("\n"); // Pula linha

            Console.Write("Digite o Genero do livro entre as opcoes acima: ");
            int generoLiv = int.Parse(Console.ReadLine());

            while (generoLiv <= 0 || generoLiv > 13)
            {
                Console.Write("\nOperacao invalida, tente novamente!\n");

                Console.Write("\nDigite o Genero do livro entre as opcoes acima: ");
                generoLiv = int.Parse(Console.ReadLine());
            }

            Console.Write("\n------------ Cadastrar Livro - Informacoes ------------\n");

            Console.Write("\nDigite o Titulo do Livro: ");
            string titLiv = Console.ReadLine();

            Console.Write("\nDigite o Autor do Livro: ");
            string autorLiv = Console.ReadLine();

            Console.Write("\nDigite o Ano de lançamento do Livro: ");
            int anoLiv = Convert.ToInt32(Console.ReadLine());

            int anoAtual = DateTime.Now.Year;

            while (anoLiv > anoAtual)
            {
                Console.Write("\nAno de publicacao invalido, tente novamente! \n");

                Console.Write("\nDigite o Ano de lançamento do Livro ");
                anoLiv = int.Parse(Console.ReadLine());
            }

            Livro novoLivro = new Livro((Genero)generoLiv, titLiv, autorLiv, anoLiv);
            livros.Add(novoLivro);

            Console.Write("\n---------- Livro Cadastrado com Sucesso! ---------- \n");

            return novoLivro;
        }

//---------------------------------------------------------------------------------------------------------------------------------------

        public static Login VerificarLogin() // Método para verificar o login
        {
            Console.Clear();
            Console.Write("------------ Login ------------\n");

            Console.Write("\nDigite o seu Email: ");
            string emailLogin = Console.ReadLine();

            Console.Write("Digite a sua Senha: ");
            string senhaLogin = Console.ReadLine();

            Usuario usuario = usuarios.FirstOrDefault(u => u.useremail == emailLogin);

            if (usuario != null && usuario.password == senhaLogin)
            {
                return usuario;
            }
            else
            {
                return null;
            }
        }

        public static bool SairPrograma()
        {
            Console.WriteLine("\nObrigado por utilizar o nosso Programa! \nSaindo do programa...\n");
            Thread.Sleep(3000);

            return false;
        }
    }
}
