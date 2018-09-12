namespace AlbumFigPoliticos
{
    partial class FrInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrInicio));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAlbum = new System.Windows.Forms.Button();
            this.btCadastroFigurinhas = new System.Windows.Forms.Button();
            this.btGanharFigurinhas = new System.Windows.Forms.Button();
            this.btSobre = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::AlbumFigPoliticos.Properties.Resources.imgInicio;
            this.pictureBox1.Location = new System.Drawing.Point(12, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btAlbum
            // 
            this.btAlbum.BackColor = System.Drawing.Color.Black;
            this.btAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAlbum.ForeColor = System.Drawing.Color.Red;
            this.btAlbum.Location = new System.Drawing.Point(12, 151);
            this.btAlbum.Name = "btAlbum";
            this.btAlbum.Size = new System.Drawing.Size(218, 41);
            this.btAlbum.TabIndex = 1;
            this.btAlbum.Text = "COLAR FIGURINHAS";
            this.btAlbum.UseVisualStyleBackColor = false;
            this.btAlbum.Click += new System.EventHandler(this.btAlbum_Click);
            // 
            // btCadastroFigurinhas
            // 
            this.btCadastroFigurinhas.BackColor = System.Drawing.Color.Black;
            this.btCadastroFigurinhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCadastroFigurinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastroFigurinhas.ForeColor = System.Drawing.Color.Red;
            this.btCadastroFigurinhas.Location = new System.Drawing.Point(12, 198);
            this.btCadastroFigurinhas.Name = "btCadastroFigurinhas";
            this.btCadastroFigurinhas.Size = new System.Drawing.Size(218, 41);
            this.btCadastroFigurinhas.TabIndex = 2;
            this.btCadastroFigurinhas.Text = "CADASTRO DE FIGURAS";
            this.btCadastroFigurinhas.UseVisualStyleBackColor = false;
            this.btCadastroFigurinhas.Click += new System.EventHandler(this.btCadastroFigurinhas_Click);
            // 
            // btGanharFigurinhas
            // 
            this.btGanharFigurinhas.BackColor = System.Drawing.Color.Black;
            this.btGanharFigurinhas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGanharFigurinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGanharFigurinhas.ForeColor = System.Drawing.Color.Red;
            this.btGanharFigurinhas.Location = new System.Drawing.Point(12, 245);
            this.btGanharFigurinhas.Name = "btGanharFigurinhas";
            this.btGanharFigurinhas.Size = new System.Drawing.Size(218, 41);
            this.btGanharFigurinhas.TabIndex = 3;
            this.btGanharFigurinhas.Text = "GANHAR FIGURAS";
            this.btGanharFigurinhas.UseVisualStyleBackColor = false;
            this.btGanharFigurinhas.Click += new System.EventHandler(this.btGanharFigurinhas_Click);
            // 
            // btSobre
            // 
            this.btSobre.BackColor = System.Drawing.Color.Black;
            this.btSobre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSobre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSobre.ForeColor = System.Drawing.Color.Red;
            this.btSobre.Location = new System.Drawing.Point(12, 339);
            this.btSobre.Name = "btSobre";
            this.btSobre.Size = new System.Drawing.Size(218, 41);
            this.btSobre.TabIndex = 4;
            this.btSobre.Text = "SOBRE";
            this.btSobre.UseVisualStyleBackColor = false;
            this.btSobre.Click += new System.EventHandler(this.btSobre_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(12, 386);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(218, 41);
            this.btSair.TabIndex = 5;
            this.btSair.Text = "SAIR";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click_1);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.Color.Black;
            this.btListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btListar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.ForeColor = System.Drawing.Color.Red;
            this.btListar.Location = new System.Drawing.Point(12, 292);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(218, 41);
            this.btListar.TabIndex = 6;
            this.btListar.Text = "LISTAR";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // FrInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(242, 439);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btSobre);
            this.Controls.Add(this.btGanharFigurinhas);
            this.Controls.Add(this.btCadastroFigurinhas);
            this.Controls.Add(this.btAlbum);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Album de Figurinhas";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAlbum;
        private System.Windows.Forms.Button btCadastroFigurinhas;
        private System.Windows.Forms.Button btGanharFigurinhas;
        private System.Windows.Forms.Button btSobre;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btListar;
    }
}

