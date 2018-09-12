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
    public partial class FrPerguntas : Form
    {
        Perguntas n = null;
        int i = 0;
        public FrPerguntas()
        {
            InitializeComponent();
        }

        private void btcadastrarPerguntas_Click(object sender, EventArgs e)
        {
            FrCadastroPergunta f = new FrCadastroPergunta();
            f.ShowDialog();
        }

        private void FrPerguntas_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Você só pode jogar uma vez por login, após responder, você será redirecionado para o menu.");
            LinkedList<Perguntas> p = Cache.DeserializaPerguntas();
            n = new Perguntas();
            n = p.Random();
            txtPergunta.Text = n.Pergunta;
            lblRespostaA.Text = n.Resposta1;
            lblRespostaB.Text = n.Resposta2;
            lblRespostaC.Text = n.Resposta3;
            lblRespostaD.Text = n.Resposta4;
        }

        private void btVerifica_Click(object sender, EventArgs e)
        {
            if((rbA.Checked && (n.Correta == "1")) || (rbB.Checked && (n.Correta == "2")) || (rbC.Checked && (n.Correta == "3")) || (rbD.Checked && (n.Correta == "4")))
            {
                MessageBox.Show("Parabéns, você ganhou 2 figurinhas.");
                LinkedList<Politico> p = Cache.DeserializaPolitico();
                LinkedList<Partido> d = Cache.DeserializaPartido();
                Usuario user = Cache.DeserializaLog();

                user.Arsenal.Add(p.Random().Codigo);
                user.Arsenal.Add(d.Random().Codigo);
                Cache.SerializaLog(user);

                this.Close();
            }
            else if(!(rbA.Checked || rbB.Checked || rbC.Checked || rbD.Checked))
            {
                MessageBox.Show("Por favor, selecione uma resposta");
            }
            else
            {
                MessageBox.Show("ERROU VIADO DA MOLESTIA! TENTA DE NOVO AI.");
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            i++;
            if(i == 7)
            {
                FrCadastroPergunta f = new FrCadastroPergunta();
                f.ShowDialog();
            }
        }
    }
}
