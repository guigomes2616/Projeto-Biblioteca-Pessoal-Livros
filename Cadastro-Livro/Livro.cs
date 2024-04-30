using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro
{
    public class Livro
    {
        public Genero Genero { get; set; }
        public string Titulo { get; set; }
        public string Autor {  get; set; }
        public int AnoPubli { get; set; }

        public Livro(Genero gen, string tit, string aut, int anop)
        {

            this.Genero = gen;
            this.Titulo = tit;
            this.Autor = aut;
            this.AnoPubli = anop;
        }
    }
}
