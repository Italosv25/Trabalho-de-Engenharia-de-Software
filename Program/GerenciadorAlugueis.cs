using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_engsoftware
{
    internal class GerenciadorAlugueis
    {
        
        private static List<Livro> listaDeAlugados = new List<Livro>();

        public static void AdicionarAluguel(Livro livro)
        {
            listaDeAlugados.Add(livro);
        }

        
        public static List<Livro> ObterAlugueis()
        {
            return listaDeAlugados;
        }
    }

}
