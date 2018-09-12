namespace AlbumFigPoliticos
{
    partial class FrAlbumComp
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.pbArsenal = new System.Windows.Forms.PictureBox();
            this.btBefore = new System.Windows.Forms.Button();
            this.btNext = new System.Windows.Forms.Button();
            this.btColar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.btColaPartido = new System.Windows.Forms.Button();
            this.btVoltaPartido = new System.Windows.Forms.Button();
            this.pbArsenalPartido = new System.Windows.Forms.PictureBox();
            this.btAvancaPartido = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbArsenal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArsenalPartido)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(130, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(464, 386);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 424);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Red;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.btColar);
            this.tabPage1.Controls.Add(this.btBefore);
            this.tabPage1.Controls.Add(this.pbArsenal);
            this.tabPage1.Controls.Add(this.btNext);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(600, 398);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Políticos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Red;
            this.tabPage2.Controls.Add(this.btSair);
            this.tabPage2.Controls.Add(this.btColaPartido);
            this.tabPage2.Controls.Add(this.btVoltaPartido);
            this.tabPage2.Controls.Add(this.pbArsenalPartido);
            this.tabPage2.Controls.Add(this.btAvancaPartido);
            this.tabPage2.Controls.Add(this.flowLayoutPanel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(600, 398);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Partido";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(130, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(464, 386);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // pbArsenal
            // 
            this.pbArsenal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbArsenal.Location = new System.Drawing.Point(6, 9);
            this.pbArsenal.Name = "pbArsenal";
            this.pbArsenal.Size = new System.Drawing.Size(100, 129);
            this.pbArsenal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArsenal.TabIndex = 1;
            this.pbArsenal.TabStop = false;
            // 
            // btBefore
            // 
            this.btBefore.BackColor = System.Drawing.Color.Black;
            this.btBefore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBefore.ForeColor = System.Drawing.Color.Red;
            this.btBefore.Location = new System.Drawing.Point(6, 144);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(47, 23);
            this.btBefore.TabIndex = 2;
            this.btBefore.Text = "<";
            this.btBefore.UseVisualStyleBackColor = false;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.Color.Black;
            this.btNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btNext.ForeColor = System.Drawing.Color.Red;
            this.btNext.Location = new System.Drawing.Point(59, 144);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(47, 23);
            this.btNext.TabIndex = 3;
            this.btNext.Text = ">";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Click += new System.EventHandler(this.btNext_Click);
            // 
            // btColar
            // 
            this.btColar.BackColor = System.Drawing.Color.Black;
            this.btColar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColar.ForeColor = System.Drawing.Color.Red;
            this.btColar.Location = new System.Drawing.Point(6, 173);
            this.btColar.Name = "btColar";
            this.btColar.Size = new System.Drawing.Size(100, 23);
            this.btColar.TabIndex = 4;
            this.btColar.Text = "Colar Figura";
            this.btColar.UseVisualStyleBackColor = false;
            this.btColar.Click += new System.EventHandler(this.btColar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(6, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btSair
            // 
            this.btSair.BackColor = System.Drawing.Color.Black;
            this.btSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSair.ForeColor = System.Drawing.Color.Red;
            this.btSair.Location = new System.Drawing.Point(6, 199);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(100, 23);
            this.btSair.TabIndex = 10;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = false;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // btColaPartido
            // 
            this.btColaPartido.BackColor = System.Drawing.Color.Black;
            this.btColaPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btColaPartido.ForeColor = System.Drawing.Color.Red;
            this.btColaPartido.Location = new System.Drawing.Point(6, 170);
            this.btColaPartido.Name = "btColaPartido";
            this.btColaPartido.Size = new System.Drawing.Size(100, 23);
            this.btColaPartido.TabIndex = 9;
            this.btColaPartido.Text = "Colar Figura";
            this.btColaPartido.UseVisualStyleBackColor = false;
            this.btColaPartido.Click += new System.EventHandler(this.btColarPartido_Click);
            // 
            // btVoltaPartido
            // 
            this.btVoltaPartido.BackColor = System.Drawing.Color.Black;
            this.btVoltaPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltaPartido.ForeColor = System.Drawing.Color.Red;
            this.btVoltaPartido.Location = new System.Drawing.Point(6, 141);
            this.btVoltaPartido.Name = "btVoltaPartido";
            this.btVoltaPartido.Size = new System.Drawing.Size(47, 23);
            this.btVoltaPartido.TabIndex = 7;
            this.btVoltaPartido.Text = "<";
            this.btVoltaPartido.UseVisualStyleBackColor = false;
            this.btVoltaPartido.Click += new System.EventHandler(this.btVoltaPartido_Click);
            // 
            // pbArsenalPartido
            // 
            this.pbArsenalPartido.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbArsenalPartido.Location = new System.Drawing.Point(6, 6);
            this.pbArsenalPartido.Name = "pbArsenalPartido";
            this.pbArsenalPartido.Size = new System.Drawing.Size(100, 129);
            this.pbArsenalPartido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArsenalPartido.TabIndex = 6;
            this.pbArsenalPartido.TabStop = false;
            // 
            // btAvancaPartido
            // 
            this.btAvancaPartido.BackColor = System.Drawing.Color.Black;
            this.btAvancaPartido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancaPartido.ForeColor = System.Drawing.Color.Red;
            this.btAvancaPartido.Location = new System.Drawing.Point(59, 141);
            this.btAvancaPartido.Name = "btAvancaPartido";
            this.btAvancaPartido.Size = new System.Drawing.Size(47, 23);
            this.btAvancaPartido.TabIndex = 8;
            this.btAvancaPartido.Text = ">";
            this.btAvancaPartido.UseVisualStyleBackColor = false;
            this.btAvancaPartido.Click += new System.EventHandler(this.btAvancaPartido_Click);
            // 
            // FrAlbumComp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(632, 448);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrAlbumComp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrAlbumComp";
            this.Load += new System.EventHandler(this.FrAlbumComp_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbArsenal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArsenalPartido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox pbArsenal;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btNext;
        private System.Windows.Forms.Button btColar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.Button btColaPartido;
        private System.Windows.Forms.Button btVoltaPartido;
        private System.Windows.Forms.PictureBox pbArsenalPartido;
        private System.Windows.Forms.Button btAvancaPartido;
    }
}