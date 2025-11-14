namespace Trabalho_engsoftware
{
    partial class FormListaReservas
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
            this.listBoxReservas = new System.Windows.Forms.ListBox();
            this.picCapaReserva = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCapaReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxReservas
            // 
            this.listBoxReservas.FormattingEnabled = true;
            this.listBoxReservas.Location = new System.Drawing.Point(39, 106);
            this.listBoxReservas.Name = "listBoxReservas";
            this.listBoxReservas.Size = new System.Drawing.Size(199, 251);
            this.listBoxReservas.TabIndex = 0;
            this.listBoxReservas.SelectedIndexChanged += new System.EventHandler(this.listBoxReservas_SelectedIndexChanged);
            // 
            // picCapaReserva
            // 
            this.picCapaReserva.BackColor = System.Drawing.Color.WhiteSmoke;
            this.picCapaReserva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapaReserva.Location = new System.Drawing.Point(278, 74);
            this.picCapaReserva.Name = "picCapaReserva";
            this.picCapaReserva.Size = new System.Drawing.Size(308, 500);
            this.picCapaReserva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCapaReserva.TabIndex = 1;
            this.picCapaReserva.TabStop = false;
            this.picCapaReserva.Click += new System.EventHandler(this.picCapaReserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Livros Reservados";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 610);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormListaReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(633, 650);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picCapaReserva);
            this.Controls.Add(this.listBoxReservas);
            this.Name = "FormListaReservas";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FormListaReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapaReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxReservas;
        private System.Windows.Forms.PictureBox picCapaReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}