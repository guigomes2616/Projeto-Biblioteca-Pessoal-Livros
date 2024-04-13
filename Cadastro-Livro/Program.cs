using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                        //InserrLivro();
                        Console.WriteLine("\nMetodo inserir livro");
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
                        //CadastrarUsuario();
                        Console.WriteLine("\nMetodo cadastrar usuario");
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
    }
}