using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho_engsoftware
{
    public partial class FormListaAlugados : Form
    {
        public FormListaAlugados()
        {
            InitializeComponent();
        }

        private void FormListaAlugados_Load(object sender, EventArgs e)
        {
            listBoxAlugados.Items.Clear();
            picCapaAlugado.Image = null;

            List<Livro> meusLivros = GerenciadorAlugueis.ObterAlugueis();

            foreach (Livro livro in meusLivros)
            {
                listBoxAlugados.Items.Add(livro);
            }

            listBoxAlugados.DisplayMember = "Titulo";
        }

        private void listBoxAlugados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxAlugados.SelectedItem != null)
            {
                Livro livroSelecionado = (Livro)listBoxAlugados.SelectedItem;

                if (livroSelecionado != null && File.Exists(livroSelecionado.CaminhoImagem))
                {
                    picCapaAlugado.Image = Image.FromFile(livroSelecionado.CaminhoImagem);
                    picCapaAlugado.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    picCapaAlugado.Image = null;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
