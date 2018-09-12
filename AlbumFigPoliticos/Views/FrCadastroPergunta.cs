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
using AlbumFigPoliticos.Classes;

namespace AlbumFigPoliticos.Views
{
    public partial class FrCadastroPergunta : Form
    {
        public FrCadastroPergunta()
        {
            InitializeComponent();
        }

        private void btCadastraPergunta_Click(object sender, EventArgs e)
        {
            LinkedList<Perguntas> p = Cache.DeserializaPerguntas();
            p.Add(new Perguntas() {
                Pergunta = txtPergunta.Text,
                Resposta1 = txtResposta1.Text,
                Resposta2 = txtResposta2.Text,
                Resposta3 = txtResposta3.Text,
                Resposta4 = txtResposta4.Text,
                Correta = txtCerto.Text
            });
            MessageBox.Show(Cache.SerializaPergunta(p));
        }
    }
}
