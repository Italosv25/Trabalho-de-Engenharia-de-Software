namespace Trabalho_engsoftware
{
    partial class Tela2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BtnLivros = new System.Windows.Forms.Button();
            this.BtnEmprestimos = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.NomeUsuarioLBL = new System.Windows.Forms.Label();
            this.Emojilbl = new System.Windows.Forms.Label();
            this.pictureBoxLLivros = new System.Windows.Forms.PictureBox();
            this.BtnLivrosAlugados = new System.Windows.Forms.Button();
            this.LBLnovidades = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLivros
            // 
            this.BtnLivros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLivros.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivros.Location = new System.Drawing.Point(12, 175);
            this.BtnLivros.Name = "BtnLivros";
            this.BtnLivros.Size = new System.Drawing.Size(318, 70);
            this.BtnLivros.TabIndex = 0;
            this.BtnLivros.Text = "Livros";
            this.BtnLivros.UseVisualStyleBackColor = true;
            this.BtnLivros.Click += new System.EventHandler(this.BtnLivros_Click);
            // 
            // BtnEmprestimos
            // 
            this.BtnEmprestimos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEmprestimos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmprestimos.Location = new System.Drawing.Point(12, 251);
            this.BtnEmprestimos.Name = "BtnEmprestimos";
            this.BtnEmprestimos.Size = new System.Drawing.Size(318, 70);
            this.BtnEmprestimos.TabIndex = 1;
            this.BtnEmprestimos.Text = "Reservados";
            this.BtnEmprestimos.UseVisualStyleBackColor = false;
            this.BtnEmprestimos.Click += new System.EventHandler(this.BtnEmprestimos_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.Location = new System.Drawing.Point(1007, 854);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(104, 47);
            this.BtnSair.TabIndex = 2;
            this.BtnSair.Text = "Sair";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // NomeUsuarioLBL
            // 
            this.NomeUsuarioLBL.AutoSize = true;
            this.NomeUsuarioLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomeUsuarioLBL.Location = new System.Drawing.Point(52, 48);
            this.NomeUsuarioLBL.Name = "NomeUsuarioLBL";
            this.NomeUsuarioLBL.Size = new System.Drawing.Size(123, 31);
            this.NomeUsuarioLBL.TabIndex = 3;
            this.NomeUsuarioLBL.Text = "Usuario: ";
            // 
            // Emojilbl
            // 
            this.Emojilbl.AutoSize = true;
            this.Emojilbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emojilbl.Location = new System.Drawing.Point(12, 48);
            this.Emojilbl.Name = "Emojilbl";
            this.Emojilbl.Size = new System.Drawing.Size(46, 31);
            this.Emojilbl.TabIndex = 4;
            this.Emojilbl.Text = "👤";
            // 
            // pictureBoxLLivros
            // 
            this.pictureBoxLLivros.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBoxLLivros.Location = new System.Drawing.Point(674, 115);
            this.pictureBoxLLivros.Name = "pictureBoxLLivros";
            this.pictureBoxLLivros.Size = new System.Drawing.Size(392, 588);
            this.pictureBoxLLivros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLLivros.TabIndex = 5;
            this.pictureBoxLLivros.TabStop = false;
            // 
            // BtnLivrosAlugados
            // 
            this.BtnLivrosAlugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLivrosAlugados.Location = new System.Drawing.Point(12, 327);
            this.BtnLivrosAlugados.Name = "BtnLivrosAlugados";
            this.BtnLivrosAlugados.Size = new System.Drawing.Size(318, 70);
            this.BtnLivrosAlugados.TabIndex = 6;
            this.BtnLivrosAlugados.Text = "Livros Alugados";
            this.BtnLivrosAlugados.UseVisualStyleBackColor = true;
            this.BtnLivrosAlugados.Click += new System.EventHandler(this.BtnLivrosAlugados_Click);
            // 
            // LBLnovidades
            // 
            this.LBLnovidades.AutoSize = true;
            this.LBLnovidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnovidades.ForeColor = System.Drawing.Color.Gold;
            this.LBLnovidades.Location = new System.Drawing.Point(702, 68);
            this.LBLnovidades.Name = "LBLnovidades";
            this.LBLnovidades.Size = new System.Drawing.Size(333, 31);
            this.LBLnovidades.TabIndex = 7;
            this.LBLnovidades.Text = "★ Novidades da semana ★";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tela2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1123, 913);
            this.Controls.Add(this.LBLnovidades);
            this.Controls.Add(this.BtnLivrosAlugados);
            this.Controls.Add(this.pictureBoxLLivros);
            this.Controls.Add(this.Emojilbl);
            this.Controls.Add(this.NomeUsuarioLBL);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnEmprestimos);
            this.Controls.Add(this.BtnLivros);
            this.Name = "Tela2";
            this.Text = "Tela2";
            this.Load += new System.EventHandler(this.Tela2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLivros;
        private System.Windows.Forms.Button BtnEmprestimos;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label NomeUsuarioLBL;
        private System.Windows.Forms.Label Emojilbl;
        private System.Windows.Forms.PictureBox pictureBoxLLivros;
        private System.Windows.Forms.Button BtnLivrosAlugados;
        private System.Windows.Forms.Label LBLnovidades;
        private System.Windows.Forms.Timer timer1;
    }
}