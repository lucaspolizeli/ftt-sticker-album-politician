using AlbumFigPoliticos.Classes;
using AlbumFigPoliticos.Classes.Estáticas;
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

namespace AlbumFigPoliticos.Views
{
    public partial class FrLogin : Form
    {

        public FrLogin()
        {
            InitializeComponent();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            FrCadastro f = new FrCadastro();
            f.ShowDialog();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            LinkedList<Usuario> u = Cache.DeserializaUsuario();
            foreach(Usuario i in u)
            {
                if(i.Login == txtUsuario.Text && i.Senha == txtSenha.Text)
                {
                    FrInicio f = new FrInicio();
                    if(i.UltimaData != DateTime.Today.ToShortDateString())
                    {
                        MessageBox.Show("Parabéns, hoje é o seu primeiro login, você ganhou 2 figurinhas.");
                        LinkedList<Politico> p = Cache.DeserializaPolitico();
                        LinkedList<Partido> d = Cache.DeserializaPartido();
                        LinkedList<int> sorteados = new LinkedList<int>();

                        i.Arsenal.Add(p.Random().Codigo);
                        i.Arsenal.Add(d.Random().Codigo);
                    }

                    i.UltimaData = DateTime.Today.ToShortDateString();
                    Cache.SerializaLog(i);

                    f.ShowDialog();
                    break;
                }
                else if(txtUsuario.Text == "" && txtSenha.Text == "")
                {
                    MessageBox.Show("Aconteceu algo de errado, verifique..");
                    break;
                }
                else if(txtUsuario.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Aconteceu algo de errado, verifique..");
                    break;
                }
            }
        }
    }
}
