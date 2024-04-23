using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cadastro_Livro;

namespace Cadastro_Livro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ Cadastro de Livros ------------");

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

                    case "3":
                        //AtualizarLivro();
                        Console.WriteLine("\nMetodo atualizar livro");
                        break;

                    case "4":
                        //ExcluirLivro();
                        Console.WriteLine("\nMetodo excluir livro");
                        break;

                    case "5":
                        //VizualizarLivro();
                        Console.WriteLine("\nMetodo vizualizar livro");
                        break;

                    case "6":
                        CadastrarUsuario();
                        break;

                    case "7":
                        //ExcluirUsuario();
                        Console.WriteLine("\nMetodo excluir usuario");
                        break;

                    case "C":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("\nOpcao invalida!");
                        break;
                }
                opcaoUsuario = ObterOpcaoUsuario(); // Retorna para o menu de opções
            }
            Console.WriteLine("\nObrigado por usar nosso Programa"); //Caso contrario (X) o programa irá se encerrar
        }

        // ---------------------------- Metodo Menu de Opções --------------------------------------------------------------


        public static string ObterOpcaoUsuario() //Método opcaoUsuario para listagem de opções (menu)
        {
            Console.Write("\n");
            Console.WriteLine("Digite [1] para Listar livros");
            Console.WriteLine("Digite [2] para Inserir novo livro");
            Console.WriteLine("Digite [3] para Atualizar livro");
            Console.WriteLine("Digite [4] para Excluir livro");
            Console.WriteLine("Digite [5] para Visualizar livro");
            Console.WriteLine("Digite [6] para Cadastrar usuario");
            Console.WriteLine("Digite [7] para Excluir usuario");
            Console.WriteLine("Digite [C] para Limpar tela");
            Console.WriteLine("Digite [X] para Sair");
            Console.Write("\nInsira a opcao desejada: ");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            return opcaoUsuario;
        }

        // ---------------------------- Metodo Cadastrar Usuario --------------------------------------------------------------

        public static Usuario CadastrarUsuario()
        {
            Console.Clear();
            Console.Write("------------ Cadastrar Usuario ------------\n");

            Console.Write("\nDigite o Nome do Usuario: ");
            string nomeUsu = Console.ReadLine();

            Console.Write("\nDigite a Idade do Usuario: ");
            int idadeUsu = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o Email do Usuario: ");
            string emailUsu = Console.ReadLine();

            Console.Write("\nDigite o Telefone do Usuario (11 digitos): ");
            int telefoneUsu = int.Parse(Console.ReadLine());

            Usuario novoUsuario = new Usuario(nomeUsu, idadeUsu, emailUsu, telefoneUsu);

            return novoUsuario;
        }

        // ---------------------------- Metodo Cadastrar Livro --------------------------------------------------------------

        public static Livro CadastrarLivro()
        {
            Console.Clear();
            Console.Write("------------ Cadastrar Livro ------------\n");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.Write("\n{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("\n");

            Console.Write("Digite o Genero do livro entre as opcoes acima: ");
            int generoLiv = int.Parse(Console.ReadLine());

            Console.Write("\nDigite o Titulo do Livro: ");
            string titLiv = Console.ReadLine();

            Console.Write("\nDigite o Autor do Livro: ");
            string autorLiv = Console.ReadLine();

            Console.Write("\nDigite o Ano de lançamento do Livro ");
            int anoLiv = int.Parse(Console.ReadLine());

            Console.Write("\nInsira uma breve Descricao do Livro: ");
            string descLiv = Console.ReadLine();

            Livro novoLivro = new Livro((Genero)generoLiv, titLiv, autorLiv, anoLiv, descLiv);

            return novoLivro;
        }
    }
}