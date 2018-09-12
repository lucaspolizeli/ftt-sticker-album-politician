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
    public partial class FrCadastro : Form
    {
        public FrCadastro()
        {
            InitializeComponent();
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastrar_Click(object sender, EventArgs e)
        {
            if (txtSenha.Text == txtConfirmaSenha.Text)
            {
                LinkedList<Usuario> u = Cache.DeserializaUsuario();
                foreach(Usuario i in u)
                {
                    if(i.Login == txtUsuario.Text)
                    {
                        MessageBox.Show("Já existe um usuário com esse nome, tente outro login.");
                        break;
                    }
                    else
                    {
                        MessageBox.Show("Parabéns, por se cadastrar, você ganhou 2 figurinhas.");
                        LinkedList<Politico> p = Cache.DeserializaPolitico();
                        LinkedList<Partido> d = Cache.DeserializaPartido();
                        LinkedList<int> sorteados = new LinkedList<int>();

                        sorteados.Add(p.Random().Codigo);
                        sorteados.Add(d.Random().Codigo);
                        MessageBox.Show(Cache.SerializaUsuario(txtNome.Text, txtSenha.Text, txtUsuario.Text, sorteados, 0, DateTime.Today.ToShortDateString()));

                        MessageBox.Show("Faça o login!");
                        this.Close();

                        break;
                    }

                }
            }
            else
            {
                MessageBox.Show("Você fez algo de errado, ou deixou algum campo em branco. Tente novamente.");
            }
        }
    }
}
