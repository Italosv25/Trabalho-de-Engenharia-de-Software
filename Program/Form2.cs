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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string matricula = txtMatricula.Text;
            string telefone = txtTelefone.Text;
            string tipoLogin = cmbTipoLogin.Text;

            if(string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(matricula) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(tipoLogin))
            {
                MessageBox.Show("Erro: Todos os campos são obrigatórios.",
                                "Erro de Validação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; 
            }
            if (matricula.Length != 4 || !matricula.All(char.IsDigit))
            {
                MessageBox.Show("Erro: A matrícula deve conter exatamente 4 números.",
                                "Erro de Validação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtMatricula.Focus(); 
                return;
            }

            
            if (telefone.Length != 11 || !telefone.All(char.IsDigit))
            {
                MessageBox.Show("Erro: O telefone deve conter exatamente 11 números (com DDD, sem traços ou parênteses).",
                                "Erro de Validação",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txtTelefone.Focus(); 
                return;
            }


            MessageBox.Show("Cadastro realizado com sucesso!",
                            "Sucesso",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

            string loginMatricula = txtMatricula.Text;
            this.Hide();
            Form1 telaLogin = new Form1(loginMatricula);
            telaLogin.ShowDialog();
            this.Close();
        }
        }
    }

