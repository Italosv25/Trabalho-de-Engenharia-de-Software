using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Trabalho_engsoftware
{
    public partial class Tela2 : Form
    {
        public Tela2()
        {
            InitializeComponent();
        }

        private string nomeDoUsuario;
        private string tipoDoUsuario;

        private List<Image> listaImagens = new List<Image>();
        private int indiceImagemAtual = 0;

        public Tela2(string nomeDoBanco, string tipoDoBanco)
        {

            InitializeComponent();

            this.nomeDoUsuario = nomeDoBanco;
            this.tipoDoUsuario = tipoDoBanco;
        }

        private void Tela2_Load(object sender, EventArgs e)
        {
            listaImagens.Add(Properties.Resources.one_piece_vol_100);
            listaImagens.Add(Properties.Resources.thumbnail_397_x_595);
            listaImagens.Add(Properties.Resources.jamboeditora_torre);
            listaImagens.Add(Properties.Resources.thumbnail_397_x_595__1_);
            listaImagens.Add(Properties.Resources.PaiRicoPaiPobre_jpg);
            // Adicione ou remova as imagens que quiser aqui

            if (listaImagens.Count > 0)
            {
                // Corrigido para "pictureBoxLLivros"
                pictureBoxLLivros.Image = listaImagens[0];
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (listaImagens.Count == 0)
            {
                return;
            }

            indiceImagemAtual++;

            if (indiceImagemAtual >= listaImagens.Count)
            {
                indiceImagemAtual = 0;
            }

            // Corrigido para "pictureBoxLLivros"
            pictureBoxLLivros.Image = listaImagens[indiceImagemAtual];
        }


        private void BtnLivros_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            this.Hide();
            form3.ShowDialog();
            this.Show();

        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEmprestimos_Click(object sender, EventArgs e)
        {
            List<Livro> livrosReservados = GerenciadorReservas.ObterReservas();
            if (livrosReservados.Count == 0)
            {
                MessageBox.Show("Você ainda não reservou nenhum livro.", "Reservas Vazias");
                return;
            }

            FormListaReservas formLista = new FormListaReservas(livrosReservados);
            formLista.ShowDialog();

        }

        private void BtnLivrosAlugados_Click(object sender, EventArgs e)
        {
            List<Livro> meusLivros = GerenciadorAlugueis.ObterAlugueis();

            if (meusLivros.Count == 0)
            {
                MessageBox.Show("Você ainda não alugou nenhum livro!",
                                "Aviso",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
            else
            {
                FormListaAlugados formLista = new FormListaAlugados();
                formLista.Show();
            }
        }
    }
}