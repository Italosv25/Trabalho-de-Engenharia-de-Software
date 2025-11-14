using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_engsoftware
{
    public partial class Form3 : Form
    {

        private List<Livro> listaDeLivros;
        private int indiceLivroAtual;

        public Form3()
        {
            InitializeComponent();
            CarregarLivros();
        }

        public Form3(string nomeUsuario, string tipoLogin)
        {
            InitializeComponent();
            CarregarLivros();

            string tipoFormatado = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tipoLogin.ToLower());
            label1.Text = $"Bem vindo, {tipoFormatado} - {nomeUsuario}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CarregarLivros()
        {
            listaDeLivros = new List<Livro>();

            listaDeLivros.Add(new Livro
            {
                Titulo = "A Arte da Guerra",
                Autor = "Sun Tzu",
                CaminhoImagem = "Resources/ArtedaGuerra.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Diário de um Banana",
                Autor = "Jeff Kinney",
                CaminhoImagem = "Resources/banana.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Cálculo",
                Autor = "Cengage",
                CaminhoImagem = "Resources/Calculo.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Física",
                Autor = "Autor",
                CaminhoImagem = "Resources/Fisica.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Mestre do Tempo",
                Autor = "Autor",
                CaminhoImagem = "Resources/MestredoTempo.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "O Homem mais rico",
                Autor = "Autor",
                CaminhoImagem = "Resources/OHomemmaisrico.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Pai Rico Pai Pobre",
                Autor = "Autor",
                CaminhoImagem = "Resources/PaiRicoPaiPobre.jpg.jpg"
            });

            listaDeLivros.Add(new Livro
            {
                Titulo = "Segunda Guerra",
                Autor = "Autor",
                CaminhoImagem = "Resources/SegundaGuerra.jpg.jpg"
            });


            if (listaDeLivros.Count > 0)
            {
                indiceLivroAtual = EncontrarProximoIndiceNaoLido(-1);

                if (indiceLivroAtual != -1)
                {
                    MostrarLivro(indiceLivroAtual);
                }
                else
                {
                    picCapaLivro.Image = null;
                    MessageBox.Show("Parabéns, você já leu todos os livros!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                AtualizarBotoes();
            }
        }

        private void MostrarLivro(int indice)
        {
            if (indice < 0 || indice >= listaDeLivros.Count)
            {
                picCapaLivro.Image = null;
                return;
            }

            Livro livro = listaDeLivros[indice];

            if (File.Exists(livro.CaminhoImagem))
            {
                picCapaLivro.Image = Image.FromFile(livro.CaminhoImagem);
            }
            else
            {
                picCapaLivro.Image = null;
                MessageBox.Show($"Erro: Não foi possível encontrar a imagem em {livro.CaminhoImagem}", "Erro de Imagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarBotoes()
        {
            btnAnterior.Enabled = (EncontrarAnteriorIndiceNaoLido(indiceLivroAtual) != -1);

            btnProximo.Enabled = (EncontrarProximoIndiceNaoLido(indiceLivroAtual) != -1);

            bool livroVisivel = (indiceLivroAtual != -1);
            btnReservar.Enabled = livroVisivel;
            button1.Enabled = livroVisivel;
        }

        private void btnProximo_Click_1(object sender, EventArgs e)
        {
            int proximoIndice = EncontrarProximoIndiceNaoLido(indiceLivroAtual);
            if (proximoIndice != -1)
            {
                indiceLivroAtual = proximoIndice;
                MostrarLivro(indiceLivroAtual);
                AtualizarBotoes();
            }
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            int anteriorIndice = EncontrarAnteriorIndiceNaoLido(indiceLivroAtual);
            if (anteriorIndice != -1)
            {
                indiceLivroAtual = anteriorIndice;
                MostrarLivro(indiceLivroAtual);
                AtualizarBotoes();
            }
        }

        private void btnReservar_Click_1(object sender, EventArgs e)
        {
            Livro livroAtual = listaDeLivros[indiceLivroAtual];

            GerenciadorAlugueis.AdicionarAluguel(livroAtual);

            
            string mensagem = $"Livro '{livroAtual.Titulo}' pego com sucesso!\n\n" +
                              "Prazo de devolução: 3 dias úteis.\n\n" +
                              "Atenção: A não devolução no prazo gera uma multa de \nR$ 0,50 por dia de atraso.";

            MessageBox.Show(mensagem,
                            "Aluguel Confirmado", 
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        #region FuncoesDeBuscaLivroNaoLido

        private int EncontrarProximoIndiceNaoLido(int indiceInicio)
        {
            for (int i = indiceInicio + 1; i < listaDeLivros.Count; i++)
            {
                if (!listaDeLivros[i].Lido)
                {
                    return i;
                }
            }
            return -1;
        }

        private int EncontrarAnteriorIndiceNaoLido(int indiceInicio)
        {
            for (int i = indiceInicio - 1; i >= 0; i--)
            {
                if (!listaDeLivros[i].Lido)
                {
                    return i;
                }
            }
            return -1;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (indiceLivroAtual == -1) return;

            listaDeLivros[indiceLivroAtual].Lido = true;

            int proximoIndice = EncontrarProximoIndiceNaoLido(indiceLivroAtual);
            if (proximoIndice != -1)
            {
                indiceLivroAtual = proximoIndice;
            }
            else
            {
                int anteriorIndice = EncontrarAnteriorIndiceNaoLido(indiceLivroAtual);
                if (anteriorIndice != -1)
                {
                    indiceLivroAtual = anteriorIndice;
                }
                else
                {
                    indiceLivroAtual = -1;
                    MessageBox.Show("Parabéns, você leu todos os livros!", "Fim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            MostrarLivro(indiceLivroAtual);
            AtualizarBotoes();
        }

        private void BtnReservarr_Click(object sender, EventArgs e)
        {
            Livro livroAtual = listaDeLivros[indiceLivroAtual];

            
            GerenciadorReservas.AdicionarReserva(livroAtual);

            
            string mensagem = $"Livro '{livroAtual.Titulo}' Reservado com sucesso!\n\n";
            MessageBox.Show(mensagem,
                            "Reserva Confirmada",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);



        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    public class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string CaminhoImagem { get; set; }
        public bool Lido { get; set; }
    }
}