using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro
{
    internal class Usuario
    {
        public string Nome {  get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }

        public Usuario(string n, int idad, string em, int tel)
        {
            this.Nome = n;
            this.Idade = idad;
            this.Email = em;
            this.Telefone = tel;
        }
    }
}
