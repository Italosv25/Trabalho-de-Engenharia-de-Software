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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string matricula)
        {
            InitializeComponent();
            txtMatricula.Text = matricula;
        }

        private void Criarcontabtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 telaDeCadastro = new Form2();
            telaDeCadastro.ShowDialog();
            this.Show();
        }

        private void Logarbtn_Click(object sender, EventArgs e)
        {
            
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string matricula = txtMatricula.Text;

            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(matricula))
            {
               
                MessageBox.Show("Por favor, preencha todos os campos.",
                                "Campos Vazios",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);

                return; 
            }

            string nomeDoBanco = "(Usuário Teste)";
            string tipoDoBanco = "aluno";
            bool usuarioEncontrado = true;

            if (usuarioEncontrado)
            {
                this.Hide();
                Tela2 telaPrincipal = new Tela2(nomeDoBanco, tipoDoBanco);
                telaPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Matrícula não encontrada.", "Erro de Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}