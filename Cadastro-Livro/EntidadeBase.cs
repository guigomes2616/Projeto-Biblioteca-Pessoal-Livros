using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_Livro
{
    public abstract class EntidadeBase //Classe publica - EntidadeBase 
    {
        public int id { get; protected set; } //propriedade publica "id" - get(permite a leitura) - protected set (modificação apenas dentro da classe e derivados)
    }
}