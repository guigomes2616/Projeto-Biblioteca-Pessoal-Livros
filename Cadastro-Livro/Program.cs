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
            Console.WriteLine("Digite [X] para Sair");
            Console.Write("\nInsira a opcao desejada: ");

            string opcaoUsuario = Console.ReadLine().ToUpper();

            return opcaoUsuario;
        }

        // ---------------------------- Metodo Cadastrar Livro --------------------------------------------------------------

        public static Livro CadastrarLivro()
        {
            Console.Clear();
            Console.Write("------------ Cadastrar Livro ------------\n");

            foreach (int i in Enum.GetValues(typeof(Genero))) //i vai percorrer os valores de Enum da classe Genero
            {
                Console.Write("\n{0} - {1}", i, Enum.GetName(typeof(Genero), i)); //Vai imprimir cada valor {0} e seu nome {1}
            }

            Console.WriteLine("\n"); //Pula linha

            Console.Write("Digite o Genero do livro entre as opcoes acima: ");
            int generoLiv = int.Parse(Console.ReadLine());

           while (generoLiv <= 0 || generoLiv > 13){ //Enquanto generoLiv for menor ou igual a 0 OU maior que 13
                Console.Write("\nOperacao invalida, tente novamente!\n");

                Console.Write("\nDigite o Genero do livro entre as opcoes acima: ");
                generoLiv = int.Parse(Console.ReadLine());
            }

            Console.Clear(); //Limpa a tela

            Console.Write("------------ Cadastrar Livro ------------\n");

            Console.Write("\nDigite o Titulo do Livro: ");
            string titLiv = Console.ReadLine();

            Console.Write("\nDigite o Autor do Livro: ");
            string autorLiv = Console.ReadLine();

            Console.Write("\nDigite o Ano de lançamento do Livro: ");
            int anoLiv = Convert.ToInt32(Console.ReadLine());

            int anoAtual = DateTime.Now.Year; //Variavel que busca o ano atual do sistema

            while (anoLiv > anoAtual) //Enquanto anoLiv for maior que ano Atual
            {
                Console.Write("\nAno de publicacao invalido, tente novamente! \n");

                Console.Write("\nDigite o Ano de lançamento do Livro ");
                anoLiv = int.Parse(Console.ReadLine());
            }

            Console.Write("\n---------- Livro Cadastrado com Sucesso! ---------- \n");

            Livro novoLivro = new Livro((Genero)generoLiv, titLiv, autorLiv, anoLiv); //Cria um novo Objeto "novo Livro" com os parametros passados - corresponde ao metodo da classe Livro

            return novoLivro; //Retorna "novoLivro"
        }
    }
}