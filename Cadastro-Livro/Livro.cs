using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro
{
    public class Livro //:EntidadeBase
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set;}
        public bool Excluido { get; set; }

        public Livro(Genero gen, string tit, string aut, int ano, string desc)
        {

            this.Genero = gen;
            this.Titulo = tit;
            this.Autor = aut;
            this.Ano = ano;
            this.Descricao = desc;
            this.Excluido = false;
        }
    }
}
