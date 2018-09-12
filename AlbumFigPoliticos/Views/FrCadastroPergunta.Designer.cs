namespace AlbumFigPoliticos.Views
{
    partial class FrCadastroPergunta
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
            this.txtPergunta = new System.Windows.Forms.TextBox();
            this.txtResposta1 = new System.Windows.Forms.TextBox();
            this.txtResposta3 = new System.Windows.Forms.TextBox();
            this.txtResposta2 = new System.Windows.Forms.TextBox();
            this.txtCerto = new System.Windows.Forms.TextBox();
            this.txtResposta4 = new System.Windows.Forms.TextBox();
            this.btCadastraPergunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPergunta
            // 
            this.txtPergunta.Location = new System.Drawing.Point(12, 12);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(100, 20);
            this.txtPergunta.TabIndex = 0;
            // 
            // txtResposta1
            // 
            this.txtResposta1.Location = new System.Drawing.Point(12, 38);
            this.txtResposta1.Name = "txtResposta1";
            this.txtResposta1.Size = new System.Drawing.Size(100, 20);
            this.txtResposta1.TabIndex = 1;
            // 
            // txtResposta3
            // 
            this.txtResposta3.Location = new System.Drawing.Point(12, 90);
            this.txtResposta3.Name = "txtResposta3";
            this.txtResposta3.Size = new System.Drawing.Size(100, 20);
            this.txtResposta3.TabIndex = 3;
            // 
            // txtResposta2
            // 
            this.txtResposta2.Location = new System.Drawing.Point(12, 64);
            this.txtResposta2.Name = "txtResposta2";
            this.txtResposta2.Size = new System.Drawing.Size(100, 20);
            this.txtResposta2.TabIndex = 2;
            // 
            // txtCerto
            // 
            this.txtCerto.Location = new System.Drawing.Point(12, 142);
            this.txtCerto.Name = "txtCerto";
            this.txtCerto.Size = new System.Drawing.Size(100, 20);
            this.txtCerto.TabIndex = 5;
            // 
            // txtResposta4
            // 
            this.txtResposta4.Location = new System.Drawing.Point(12, 116);
            this.txtResposta4.Name = "txtResposta4";
            this.txtResposta4.Size = new System.Drawing.Size(100, 20);
            this.txtResposta4.TabIndex = 4;
            // 
            // btCadastraPergunta
            // 
            this.btCadastraPergunta.Location = new System.Drawing.Point(12, 168);
            this.btCadastraPergunta.Name = "btCadastraPergunta";
            this.btCadastraPergunta.Size = new System.Drawing.Size(100, 23);
            this.btCadastraPergunta.TabIndex = 6;
            this.btCadastraPergunta.Text = "Cadastrar";
            this.btCadastraPergunta.UseVisualStyleBackColor = true;
            this.btCadastraPergunta.Click += new System.EventHandler(this.btCadastraPergunta_Click);
            // 
            // FrCadastroPergunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(124, 197);
            this.Controls.Add(this.btCadastraPergunta);
            this.Controls.Add(this.txtCerto);
            this.Controls.Add(this.txtResposta4);
            this.Controls.Add(this.txtResposta3);
            this.Controls.Add(this.txtResposta2);
            this.Controls.Add(this.txtResposta1);
            this.Controls.Add(this.txtPergunta);
            this.Name = "FrCadastroPergunta";
            this.Text = "FrCadastroPergunta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPergunta;
        private System.Windows.Forms.TextBox txtResposta1;
        private System.Windows.Forms.TextBox txtResposta3;
        private System.Windows.Forms.TextBox txtResposta2;
        private System.Windows.Forms.TextBox txtCerto;
        private System.Windows.Forms.TextBox txtResposta4;
        private System.Windows.Forms.Button btCadastraPergunta;
    }
}