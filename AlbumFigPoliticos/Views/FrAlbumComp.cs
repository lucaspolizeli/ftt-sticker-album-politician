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
using System.IO;
using AlbumFigPoliticos.Classes;

namespace AlbumFigPoliticos
{
    public partial class FrAlbumComp : Form
    {

        public FrAlbumComp()
        {
            InitializeComponent();
        }

        // Variáveis Globais
        Usuario user = Cache.DeserializaLog();
        LinkedList<Politico> soPoliticos = Cache.RetornoPolitico(Cache.DeserializaLog().Arsenal);
        LinkedList<Partido> soPartidos = Cache.RetornoPartido(Cache.DeserializaLog().Arsenal);
        LinkedList<Politico> politico = Cache.DeserializaPolitico();
        LinkedList<Partido> partido = Cache.DeserializaPartido();
        PictureBox l;
        int i = 0;
        int j = 0;


        private void FrAlbumComp_Load(object sender, EventArgs e)
        {
            // Cria todas picbox dos politicos na tela
            foreach (Politico i in politico)
            {
                // Defino os atributos de cada picturebox
                l = new PictureBox();
                flowLayoutPanel1.Controls.Add(l);
                l.BackColor = Color.Black;
                l.Size = new System.Drawing.Size(100, 121);
                l.Name = i.Codigo.ToString();
                l.Enabled = false;
                l.SizeMode = PictureBoxSizeMode.StretchImage;

                // Tranformando a imagem em matriz, e trocando o rgb dela pra cinza
                Bitmap bmp = new Bitmap(Directory.GetCurrentDirectory() + i.Imagem);
                int width = bmp.Width;
                int height = bmp.Height;
                Color p;

                // Deixando a cor da imagem cinza
                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        //get pixel value
                        p = bmp.GetPixel(x, y);

                        //extract pixel component ARGB
                        int a = p.A;
                        int r = p.R;
                        int g = p.G;
                        int b = p.B;

                        //find average
                        int avg = (r + g + b) / 3;

                        //set new pixel value
                        bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                    }
                }

                // Verifico se está colada, se estiver, ok, se não, deixa cinza
                if (Cache.Colada(i.Codigo))
                    l.ImageLocation = Directory.GetCurrentDirectory() + i.Imagem;
                else
                    l.Image = bmp;
            }

            // Cria todas picbox dos partidos
            foreach (Partido i in partido)
            {
                l = new PictureBox();
                flowLayoutPanel2.Controls.Add(l);
                l.BackColor = Color.Black;
                l.Size = new System.Drawing.Size(100, 121);
                l.Enabled = false;
                l.Name = i.Codigo.ToString();
                l.SizeMode = PictureBoxSizeMode.StretchImage;

                /* Bitmap bmp = new Bitmap(Directory.GetCurrentDirectory() + i.Imagem);
                 int width = bmp.Width;
                 int height = bmp.Height;
                 Color p;
                 for (int y = 0; y < height; y++)
                 {
                     for (int x = 0; x < width; x++)
                     {
                         //get pixel value
                         p = bmp.GetPixel(x, y);

                         //extract pixel component ARGB
                         int a = p.A;
                         int r = p.R;
                         int g = p.G;
                         int b = p.B;

                         //find average
                         int avg = (r + g + b) / 3;

                         //set new pixel value
                         bmp.SetPixel(x, y, Color.FromArgb(a, avg, avg, avg));
                     }
                 }
                 */

                // Verifico se está colada, se estiver, ok, se não, deixa cinza
                if (Cache.Colada(i.Codigo))
                    l.ImageLocation = Directory.GetCurrentDirectory() + i.Imagem;
                //else
                //l.Image = bmp;
            }

            // Definindo a imagem inicial do pacote de figuras como um o primeiro
            pbArsenal.ImageLocation = Directory.GetCurrentDirectory() + soPoliticos[0].Imagem;
            pbArsenalPartido.ImageLocation = Directory.GetCurrentDirectory() + soPartidos[0].Imagem;
        }

        // Botão que fecha a tela
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Avança dentro da lista Arsenal, que é as figurinhas que o usuário tem
        private void btNext_Click(object sender, EventArgs e)
        {
            if (i < soPoliticos.Count - 1)
            {
                pbArsenal.ImageLocation = "";
                pbArsenal.ImageLocation = Directory.GetCurrentDirectory() + soPoliticos[++i].Imagem;
                return;
            }
            MessageBox.Show("Acabou meu filho, volta ai!");
        }

        // Volta na lista Arsena, que é as figurinhas que o usuário tem
        private void btBefore_Click(object sender, EventArgs e)
        {
            if (i <= 0)
                MessageBox.Show("Vai pra frente meu filho!");
            else
            {
                pbArsenal.ImageLocation = "";
                pbArsenal.ImageLocation = Directory.GetCurrentDirectory() + soPoliticos[--i].Imagem;
            }
        }

        // Cola a figurinha no album
        private void btColar_Click(object sender, EventArgs e)
        {
            foreach (PictureBox l in flowLayoutPanel1.Controls)
            {
                if (l.Name == soPoliticos[i].Codigo.ToString())
                {
                    if (user.FigurinhasColadas != null)
                    {
                        foreach (int f in user.FigurinhasColadas)
                        {
                            if (Cache.Colada(soPoliticos[i].Codigo))
                            {
                                MessageBox.Show("Irmão, essa vc já colou parça. Cola outra ae.");
                                break;
                            }
                            else
                            {
                                l.ImageLocation = Directory.GetCurrentDirectory() + soPoliticos[i].Imagem;
                                MessageBox.Show("Figurinha Colada!");
                                if (user.FigurinhasColadas == null)
                                    user.FigurinhasColadas = new LinkedList<int>();
                                user.FigurinhasColadas.Add(soPoliticos[i].Codigo);
                                Cache.SerializaLog(user);
                                break;
                            }
                        }
                    }
                    else
                    {
                        l.ImageLocation = Directory.GetCurrentDirectory() + soPoliticos[i].Imagem;
                        MessageBox.Show("Figurinha Colada!");
                        if (user.FigurinhasColadas == null)
                            user.FigurinhasColadas = new LinkedList<int>();
                        user.FigurinhasColadas.Add(soPoliticos[i].Codigo);
                        Cache.SerializaLog(user);
                        break;
                    }
                }
            }

        }
        private void btColarPartido_Click(object sender, EventArgs e)
        {
            foreach (PictureBox l in flowLayoutPanel2.Controls)
            {
                if (l.Name == soPartidos[j].Codigo.ToString())
                {
                    if (user.FigurinhasColadas != null)
                    {
                        foreach (int f in user.FigurinhasColadas)
                        {
                            if (Cache.Colada(soPartidos[j].Codigo))
                            {
                                MessageBox.Show("Irmão, essa vc já colou parça. Cola outra ae.");
                                break;
                            }
                            else
                            {
                                l.ImageLocation = Directory.GetCurrentDirectory() + soPartidos[j].Imagem;
                                MessageBox.Show("Figurinha Colada!");
                                if (user.FigurinhasColadas == null)
                                    user.FigurinhasColadas = new LinkedList<int>();
                                user.FigurinhasColadas.Add(soPartidos[j].Codigo);
                                Cache.SerializaLog(user);
                                break;
                            }
                        }
                    }
                    else
                    {
                        l.ImageLocation = Directory.GetCurrentDirectory() + soPartidos[j].Imagem;
                        MessageBox.Show("Figurinha Colada!");
                        if (user.FigurinhasColadas == null)
                            user.FigurinhasColadas = new LinkedList<int>();
                        user.FigurinhasColadas.Add(soPartidos[j].Codigo);
                        Cache.SerializaLog(user);
                        break;
                    }

                }

            }
        }

        // Botão que faz sair
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Botão que faz o partido avançar no negócio lá 
        private void btAvancaPartido_Click(object sender, EventArgs e)
        {
            if (j < soPartidos.Count - 1)
            {
                pbArsenalPartido.ImageLocation = "";
                pbArsenalPartido.ImageLocation = Directory.GetCurrentDirectory() + soPartidos[++j].Imagem;
                return;
            }
            MessageBox.Show("Acabou meu filho, volta ai!");
        }

        private void btVoltaPartido_Click(object sender, EventArgs e)
        {
            if (j <= 0)
                MessageBox.Show("Vai pra frente meu filho!");
            else
            {
                pbArsenalPartido.ImageLocation = "";
                pbArsenalPartido.ImageLocation = Directory.GetCurrentDirectory() + soPartidos[--j].Imagem;
            }
        }
    }
}
