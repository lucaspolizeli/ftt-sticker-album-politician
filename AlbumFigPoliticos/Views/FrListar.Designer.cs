namespace AlbumFigPoliticos.Views
{
    partial class FrListar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabMostra = new System.Windows.Forms.TabControl();
            this.Político = new System.Windows.Forms.TabPage();
            this.cbEscolhaPolitico = new System.Windows.Forms.ComboBox();
            this.Partido = new System.Windows.Forms.TabPage();
            this.cbEscolhaPartido = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabMostra.SuspendLayout();
            this.Político.SuspendLayout();
            this.Partido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 31);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(756, 326);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // tabMostra
            // 
            this.tabMostra.Controls.Add(this.Político);
            this.tabMostra.Controls.Add(this.Partido);
            this.tabMostra.Location = new System.Drawing.Point(12, 11);
            this.tabMostra.Name = "tabMostra";
            this.tabMostra.SelectedIndex = 0;
            this.tabMostra.Size = new System.Drawing.Size(776, 389);
            this.tabMostra.TabIndex = 1;
            // 
            // Político
            // 
            this.Político.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Político.Controls.Add(this.dataGridView1);
            this.Político.Controls.Add(this.cbEscolhaPolitico);
            this.Político.Location = new System.Drawing.Point(4, 22);
            this.Político.Name = "Político";
            this.Político.Padding = new System.Windows.Forms.Padding(3);
            this.Político.Size = new System.Drawing.Size(768, 363);
            this.Político.TabIndex = 0;
            this.Político.Text = "Político";
            // 
            // cbEscolhaPolitico
            // 
            this.cbEscolhaPolitico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolhaPolitico.FormattingEnabled = true;
            this.cbEscolhaPolitico.Items.AddRange(new object[] {
            "Ordenar por...",
            "Código",
            "Milhões Lavados",
            "Nome",
            "Partido",
            "Chapa"});
            this.cbEscolhaPolitico.Location = new System.Drawing.Point(6, 6);
            this.cbEscolhaPolitico.Name = "cbEscolhaPolitico";
            this.cbEscolhaPolitico.Size = new System.Drawing.Size(756, 21);
            this.cbEscolhaPolitico.TabIndex = 2;
            this.cbEscolhaPolitico.SelectedIndexChanged += new System.EventHandler(this.cbEscolhaPolitico_SelectedIndexChanged);
            // 
            // Partido
            // 
            this.Partido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Partido.Controls.Add(this.cbEscolhaPartido);
            this.Partido.Controls.Add(this.dataGridView2);
            this.Partido.Location = new System.Drawing.Point(4, 22);
            this.Partido.Name = "Partido";
            this.Partido.Padding = new System.Windows.Forms.Padding(3);
            this.Partido.Size = new System.Drawing.Size(768, 363);
            this.Partido.TabIndex = 1;
            this.Partido.Text = "Partido";
            // 
            // cbEscolhaPartido
            // 
            this.cbEscolhaPartido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscolhaPartido.FormattingEnabled = true;
            this.cbEscolhaPartido.Items.AddRange(new object[] {
            "Ordenar por...",
            "Código",
            "Nome",
            "Financiador",
            "Juiz de Confiança",
            "Chapa"});
            this.cbEscolhaPartido.Location = new System.Drawing.Point(6, 6);
            this.cbEscolhaPartido.Name = "cbEscolhaPartido";
            this.cbEscolhaPartido.Size = new System.Drawing.Size(756, 21);
            this.cbEscolhaPartido.TabIndex = 1;
            this.cbEscolhaPartido.SelectedIndexChanged += new System.EventHandler(this.cbEscolhaPartido_SelectedIndexChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(6, 31);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(756, 326);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btSair.Location = new System.Drawing.Point(713, 406);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 23);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // FrListar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.tabMostra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrListar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listar";
            this.Load += new System.EventHandler(this.FrListar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabMostra.ResumeLayout(false);
            this.Político.ResumeLayout(false);
            this.Partido.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabControl tabMostra;
        private System.Windows.Forms.TabPage Político;
        private System.Windows.Forms.TabPage Partido;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbEscolhaPolitico;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.ComboBox cbEscolhaPartido;
    }
}