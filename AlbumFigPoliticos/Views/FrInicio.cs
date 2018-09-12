using AlbumFigPoliticos.Classes;
using AlbumFigPoliticos.Views;
using System;
//using System.Collections.Generic;
using AlbumFigPoliticos.Generics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumFigPoliticos.Classes.Estáticas;

namespace AlbumFigPoliticos
{
    public partial class FrInicio : Form
    {
        public FrInicio()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSair_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LinkedList<Usuario> g = Cache.DeserializaUsuario();
            Usuario u = Cache.DeserializaLog();
            foreach(Usuario i in g)
            {
                if(i.Login == u.Login)
                {
                    g.Remove(i);
                    g.Add(u);
                }
            }
            Cache.SerializaUsuario(g);
        }

        private void btCadastroFigurinhas_Click(object sender, EventArgs e)
        {
            FrCadastroFigurinhas f = new FrCadastroFigurinhas();
            f.ShowDialog();
        }

        private void btSobre_Click(object sender, EventArgs e)
        {
            FrSobre f = new FrSobre();
            f.ShowDialog();
        }

        private void btListar_Click(object sender, EventArgs e)
        {
            FrListar f = new FrListar();
            f.ShowDialog();
        }

        private void btGanharFigurinhas_Click(object sender, EventArgs e)
        {
            FrPerguntas f = new FrPerguntas();
            f.ShowDialog();
            btGanharFigurinhas.Enabled = false;
        }

        private void btAlbum_Click(object sender, EventArgs e)
        {
            FrAlbumComp f = new FrAlbumComp();
            f.ShowDialog();
        }
    }
}
