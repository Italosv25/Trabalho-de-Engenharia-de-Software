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
    public partial class FormListaReservas : Form
    {
        private List<Livro> _listaDeReservas;


        public FormListaReservas(List<Livro> reservas)
        {
            InitializeComponent();
            _listaDeReservas = reservas;
        }


        private void FormListaReservas_Load(object sender, EventArgs e)
        {

            listBoxReservas.Items.Clear();


            foreach (Livro livro in _listaDeReservas)
            {

                listBoxReservas.Items.Add($"{livro.Titulo}  -  (Autor: {livro.Autor})");
            }
        }

        private void picCapaReserva_Click(object sender, EventArgs e)
        {

        }

        private void listBoxReservas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = listBoxReservas.SelectedIndex;


            if (selectedIndex < 0 || selectedIndex >= _listaDeReservas.Count)
            {
                picCapaReserva.Image = null;
                return;
            }


            Livro livroSelecionado = _listaDeReservas[selectedIndex];


            if (livroSelecionado != null && File.Exists(livroSelecionado.CaminhoImagem))
            {

                picCapaReserva.Image = Image.FromFile(livroSelecionado.CaminhoImagem);
            }
            else
            {

                picCapaReserva.Image = null;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
