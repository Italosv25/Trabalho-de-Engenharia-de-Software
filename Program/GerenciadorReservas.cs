using System.Collections.Generic;

namespace Trabalho_engsoftware
{
    
    public static class GerenciadorReservas
    {
        
        private static List<Livro> listaDeReservas = new List<Livro>();

       
        public static void AdicionarReserva(Livro livro)
        {
            if (livro != null && !listaDeReservas.Contains(livro))
            {
                
                
                listaDeReservas.Add(livro);
            }
        }

        
        public static List<Livro> ObterReservas()
        {
            return listaDeReservas;
        }
    }
}