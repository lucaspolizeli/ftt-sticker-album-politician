using AlbumFigPoliticos.Enumeradores;
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
using Newtonsoft.Json;
using System.IO;
using AlbumFigPoliticos.Classes.Estáticas;

namespace AlbumFigPoliticos
{
    public partial class FrCadastroFigurinhas : Form
    {
        public FrCadastroFigurinhas()
        {
            // Inicializando os Enumeradores 
            InitializeComponent();

            // Carrega os Enumeradores
            // Cargos
            EnumCargo[] cargo = (EnumCargo[])Enum.GetValues(typeof(EnumCargo));
            cbCargo.DataSource = cargo;
            cbCargo.SelectedIndex = -1;

            // Juízes
            EnumJuiz[] juiz = (EnumJuiz[])Enum.GetValues(typeof(EnumJuiz));
            cbJuizConfianca.DataSource = juiz;
            cbJuizConfianca.SelectedIndex = -1;
        }

        /* ---------- Eventos ---------- */
        private void btSelecionarFigura_Click(object sender, EventArgs e)
        {
            //Abre o diálogo com o usuário pra guardar a fotinha
            if (opf.ShowDialog() == DialogResult.OK)
                pbImage.ImageLocation = opf.FileName;
        }

        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btCadastra_Click(object sender, EventArgs e)
        {
            // Dependendo de qual tab estiver selecionada, ele adiciona ou um politico, ou um partido
            if (tabCadastroFigura.SelectedIndex == 0)
            {
                LinkedList<Politico> p = Cache.DeserializaPolitico();
                string path = "\\img\\" + txtCodigoPolitico.Text + ".png";

                // Verifica se existe alguma imagem selecionada na picture box
                if (pbImage.ImageLocation != null)
                    File.Copy(pbImage.ImageLocation, Directory.GetCurrentDirectory() + path);
                else
                {
                    MessageBox.Show("Selecione uma imagem...");
                    return;
                }

                // POLITICOS SÓ PODEM TER A NUMERAÇÃO ABAIXO DO 100
                if (int.Parse(txtCodigoPolitico.Text) < 100)
                {
                    // Guarda no JSON
                    Cache.SerializaPolitico(int.Parse(txtCodigoPolitico.Text), txtNomePolitico.Text, cbCargo.SelectedItem.ToString(), double.Parse(txtMilhoesLavadosPolitico.Text), int.Parse(txtChapaPolitico.Text), path, cbPartido.SelectedItem.ToString());
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Digite um código abaixo de 100");
                    return;
                }
            }
            else if (tabCadastroFigura.SelectedIndex == 1)
            {
                LinkedList<Partido> part = new LinkedList<Partido>();
                part = Cache.DeserializaPartido();
                string path = "\\img\\" + txtCodigoPartido.Text + ".png";

                // Verifica se existe alguma imagem selecionada na picture box
                if (pbImage.ImageLocation != null)
                    File.Copy(pbImage.ImageLocation, Directory.GetCurrentDirectory() + path);
                else
                {
                    MessageBox.Show("Selecione uma imagem...");
                    return;
                }

                if(int.Parse(txtCodigoPartido.Text) >= 100)
                {
                    Cache.SerializaPartido(int.Parse(txtCodigoPartido.Text), txtNomePartido.Text, cbJuizConfianca.SelectedItem.ToString(), int.Parse(txtChapaPartido.Text), txtSigla.Text, txtFinanciadorPartido.Text, path);
                    MessageBox.Show("Salvo com sucesso!");
                }
                else
                {
                    MessageBox.Show("Digite um código abaixo de 100");
                    return;
                }



            }
        }

        private void FrCadastroFigurinhas_Load(object sender, EventArgs e)
        {
            LinkedList<Partido> part = new LinkedList<Partido>();
            part = JsonConvert.DeserializeObject<LinkedList<Partido>>(File.ReadAllText("partido.json"));
            cbPartido.SelectedIndex = -1;
            foreach (Partido i in part)
                cbPartido.Items.Add(i.Nome);
        }
    }
}
