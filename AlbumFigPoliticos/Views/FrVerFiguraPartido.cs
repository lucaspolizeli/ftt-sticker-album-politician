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

namespace AlbumFigPoliticos.Views
{
    public partial class FrVerFiguraPartido : Form
    {
        public FrVerFiguraPartido(Partido p)
        {
            InitializeComponent();

            lblNomePartido.Text = p.Nome;
            lblCodigoPartido.Text = p.Codigo.ToString();
            lblChapaPartido.Text = p.NumeroChapa.ToString();
            lblFinanciador.Text = p.Financiador;
            lbligla.Text = p.Sigla;
            lblJuizPartido.Text = p.JuizConfianca;
            pictureBox2.ImageLocation = Directory.GetCurrentDirectory() + p.Imagem;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
