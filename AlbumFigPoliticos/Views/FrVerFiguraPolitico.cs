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
    public partial class FrVerFiguraPolitico : Form
    {
        Politico poli = null;
        public FrVerFiguraPolitico(Politico p)
        {
            InitializeComponent();
            poli = p;
            pictureBox1.ImageLocation = Directory.GetCurrentDirectory() + p.Imagem;
            lblNome.Text = p.Nome;
            lblCodigo.Text = p.Codigo.ToString();
            lblCargo.Text = p.Cargo;
            lblChapa.Text = p.NumeroChapa.ToString();
            lblMilhoes.Text = p.MilhoesLavados.ToString();
            lblPartido.Text = p.Partido.Sigla;

        }

        private void FrVerFiguraPolitico_Load(object sender, EventArgs e)
        {

        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
