namespace Trabalho_engsoftware
{
    partial class FormListaAlugados
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
            this.listBoxAlugados = new System.Windows.Forms.ListBox();
            this.picCapaAlugado = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapaAlugado)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlugados
            // 
            this.listBoxAlugados.FormattingEnabled = true;
            this.listBoxAlugados.Location = new System.Drawing.Point(12, 177);
            this.listBoxAlugados.Name = "listBoxAlugados";
            this.listBoxAlugados.Size = new System.Drawing.Size(102, 186);
            this.listBoxAlugados.TabIndex = 0;
            this.listBoxAlugados.SelectedIndexChanged += new System.EventHandler(this.listBoxAlugados_SelectedIndexChanged);
            // 
            // picCapaAlugado
            // 
            this.picCapaAlugado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picCapaAlugado.Location = new System.Drawing.Point(263, 103);
            this.picCapaAlugado.Name = "picCapaAlugado";
            this.picCapaAlugado.Size = new System.Drawing.Size(316, 511);
            this.picCapaAlugado.TabIndex = 1;
            this.picCapaAlugado.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livros Alugados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 679);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListaAlugados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(787, 720);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCapaAlugado);
            this.Controls.Add(this.listBoxAlugados);
            this.Name = "FormListaAlugados";
            this.Text = "FormListaAlugados";
            this.Load += new System.EventHandler(this.FormListaAlugados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapaAlugado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlugados;
        private System.Windows.Forms.PictureBox picCapaAlugado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}