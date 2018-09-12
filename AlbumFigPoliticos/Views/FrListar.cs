using System;
using AlbumFigPoliticos.Generics;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlbumFigPoliticos.Classes.Estáticas;
using AlbumFigPoliticos.Ordenação;

namespace AlbumFigPoliticos.Views
{
    public partial class FrListar : Form
    {
        public FrListar()
        {
            InitializeComponent();
            cbEscolhaPartido.SelectedIndex = 0;
            cbEscolhaPolitico.SelectedIndex = 0;
        }

        // Criação dos Data Grid
        public void CriaDTGridPolitico()
        {
            dataGridView1.ColumnCount = 6;
            
            dataGridView1.Columns[0].Name = "Código";
            dataGridView1.Columns[1].Name = "Nome";
            dataGridView1.Columns[2].Name = "Número Chapa";
            dataGridView1.Columns[3].Name = "Cargo";
            dataGridView1.Columns[4].Name = "Milhões Lavados";
            dataGridView1.Columns[5].Name = "Partido";
        }
        public void CriaDTGridPartido()
        {
            dataGridView2.ColumnCount = 6;

            dataGridView2.Columns[0].Name = "Código";
            dataGridView2.Columns[1].Name = "Nome";
            dataGridView2.Columns[2].Name = "Número Chapa";
            dataGridView2.Columns[3].Name = "Financiador";
            dataGridView2.Columns[4].Name = "Juiz de Confiança";
            dataGridView2.Columns[5].Name = "Sigla";
        }

        // Carregamento dos DataGrid
        // Politico
        public void ExibeDTPoliticoOrdenadoPorChapa()
        {
            dataGridView1.Rows.Clear();
            LinkedList<Politico> p = Cache.DeserializaPolitico();
            Politico[] vetorPolitico = new Politico[p.Count];
            Politico[] vetorPolitico2 = new Politico[p.Count];
            int contador = 0;
            foreach(Politico i in p){
                vetorPolitico[contador] = i;
                contador++;
            }

            vetorPolitico2 = BubleSort.OrdenaPoliticoPorChapa(vetorPolitico);

            LinkedList <Politico> g = new LinkedList<Politico>();
            contador = 0;
            foreach(Politico i in p)
            {
                g.Add(vetorPolitico2[contador]);
                contador++;
            }

            var rows = new LinkedList<string[]>();
            foreach (Politico t in g)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Cargo,
                    t.MilhoesLavados.ToString(),
                    t.Partido.Nome
                };
                rows.Add(row1);
            }

            foreach (string[] rowrray in rows)
            {
                dataGridView1.Rows.Add(rowrray);
            }
        }
        public void ExibeDTPoliticoOrdenadoPorCodigo()
        {
            dataGridView1.Rows.Clear();
            LinkedList<Politico> p = Cache.DeserializaPolitico();
            Politico[] vetorPolitico = new Politico[p.Count];
            Politico[] vetorPolitico2 = new Politico[p.Count];
            int contador = 0;
            foreach(Politico i in p){
                vetorPolitico[contador] = i;
                contador++;
            }

            vetorPolitico2 = BubleSort.OrdenaPoliticoPorCodigo(vetorPolitico);

            LinkedList <Politico> g = new LinkedList<Politico>();
            contador = 0;
            foreach(Politico i in p)
            {
                g.Add(vetorPolitico2[contador]);
                contador++;
            }

            var rows = new LinkedList<string[]>();
            foreach (Politico t in g)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Cargo,
                    t.MilhoesLavados.ToString(),
                    t.Partido.Nome
                };
                rows.Add(row1);
            }

            foreach (string[] rowrray in rows)
            {
                dataGridView1.Rows.Add(rowrray);
            }
        }
        public void ExibeDTPoliticoOrdenadoPorMilhoes()
        {
            dataGridView1.Rows.Clear();
            LinkedList<Politico> p = Cache.DeserializaPolitico();
            Politico[] vetorPolitico = new Politico[p.Count];
            Politico[] vetorPolitico2 = new Politico[p.Count];
            int contador = 0;
            foreach(Politico i in p){
                vetorPolitico[contador] = i;
                contador++;
            }

            vetorPolitico2 = BubleSort.OrdenaPoliticoPorMilhoesLavados(vetorPolitico);

            LinkedList <Politico> g = new LinkedList<Politico>();
            contador = 0;
            foreach(Politico i in p)
            {
                g.Add(vetorPolitico2[contador]);
                contador++;
            }

            var rows = new LinkedList<string[]>();
            foreach (Politico t in g)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Cargo,
                    t.MilhoesLavados.ToString(),
                    t.Partido.Nome
                };
                rows.Add(row1);
            }

            foreach (string[] rowrray in rows)
            {
                dataGridView1.Rows.Add(rowrray);
            }
        }
        public void ExibeDTPoliticoOrdenadoPorPartido()
        {
            dataGridView1.Sort(dataGridView1.Columns[5], ListSortDirection.Ascending);
        }
        public void ExibeDTPoliticoOrdenadoPorNome()
        {
            dataGridView1.Sort(dataGridView1.Columns[1], ListSortDirection.Ascending);

        }

        // Partido
        public void ExibeDTPartidoOrdenadoPorChapa()
        {
            dataGridView1.Rows.Clear();
            LinkedList<Partido> p = Cache.DeserializaPartido();
            Partido[] vetorPartido = new Partido[p.Count];
            Partido[] vetorPartido2 = new Partido[p.Count];
            int contador = 0;
            foreach (Partido i in p)
            {
                vetorPartido[contador] = i;
                contador++;
            }

            vetorPartido2 = BubleSort.OrdenaPartidoPorChapa(vetorPartido);

            LinkedList<Partido> g = new LinkedList<Partido>();
            contador = 0;
            foreach (Partido i in p)
            {
                g.Add(vetorPartido2[contador]);
                contador++;
            }

            var rows1 = new LinkedList<string[]>();
            foreach (Partido t in g)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Financiador,
                    t.JuizConfianca,
                    t.Sigla
                };
                rows1.Add(row1);
            }

            foreach (string[] rowrray in rows1)
            {
                dataGridView2.Rows.Add(rowrray);
            }
        }
        public void ExibeDTPartidoOrdenadoPorCodigo()
        {
            dataGridView1.Rows.Clear();
            LinkedList<Partido> p = Cache.DeserializaPartido();
            Partido[] vetorPartido = new Partido[p.Count];
            Partido[] vetorPartido2 = new Partido[p.Count];
            int contador = 0;
            foreach (Partido i in p)
            {
                vetorPartido[contador] = i;
                contador++;
            }

            vetorPartido2 = BubleSort.OrdenaPartidoPorCodigo(vetorPartido);

            LinkedList<Partido> g = new LinkedList<Partido>();
            contador = 0;
            foreach (Partido i in p)
            {
                g.Add(vetorPartido2[contador]);
                contador++;
            }

            var rows1 = new LinkedList<string[]>();
            foreach (Partido t in g)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Financiador,
                    t.JuizConfianca,
                    t.Sigla
                };
                rows1.Add(row1);
            }

            foreach (string[] rowrray in rows1)
            {
                dataGridView2.Rows.Add(rowrray);
            }
        }
        public void ExibeDTPartidoOrdenadoPorNome()
        {
            dataGridView2.Sort(dataGridView2.Columns[1], ListSortDirection.Ascending);

        }
        public void ExibeDTPartidoOrdenadoPorFinanciador()
        {
            dataGridView2.Sort(dataGridView2.Columns[3], ListSortDirection.Ascending);
        }
        public void ExibeDTPartidoOrdenadoPorJuiz()
        {
            dataGridView2.Sort(dataGridView2.Columns[4], ListSortDirection.Ascending);
        }

        // Eventos 
        private void FrListar_Load(object sender, EventArgs e)
        {
            LinkedList<Politico> p = Cache.DeserializaPolitico();
            CriaDTGridPolitico();
            CriaDTGridPartido();

            LinkedList<Partido> p1 = Cache.DeserializaPartido();
            var rows1 = new LinkedList<string[]>();
            foreach (Partido t in p1)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Financiador,
                    t.JuizConfianca,
                    t.Sigla
                };
                rows1.Add(row1);
            }

            foreach (string[] rowrray in rows1)
            {
                dataGridView2.Rows.Add(rowrray);
            }

            var rows = new LinkedList<string[]>();
            foreach (Politico t in p)
            {
                string[] row1 = new string[]
                {
                    t.Codigo.ToString(),
                    t.Nome,
                    t.NumeroChapa.ToString(),
                    t.Cargo,
                    t.MilhoesLavados.ToString(),
                    t.Partido.Nome
                };
                rows.Add(row1);
            }

            foreach (string[] rowrray in rows)
            {
                dataGridView1.Rows.Add(rowrray);
            }
        }
        private void btSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var content = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                LinkedList<Politico> politico = Cache.DeserializaPolitico();
                Politico poli = new Politico();
                foreach (Politico p in politico)
                {
                    if (p.Codigo == int.Parse(content))
                    {
                        poli = p;
                    }
                }
                FrVerFiguraPolitico f = new FrVerFiguraPolitico(poli);
                f.ShowDialog();
            }
            catch (Exception)
            {
                
            }
            
        }
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var content = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
                LinkedList<Partido> partido = Cache.DeserializaPartido();
                Partido part = new Partido();
                foreach (Partido p in partido)
                {
                    if (p.Codigo == int.Parse(content))
                    {
                        part = p;
                    }
                }
                FrVerFiguraPartido f = new FrVerFiguraPartido(part);
                f.ShowDialog();
            }
            catch (Exception)
            {

            }

        }
        private void cbEscolhaPolitico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscolhaPolitico.SelectedIndex == 1)
                ExibeDTPoliticoOrdenadoPorCodigo();
            else if (cbEscolhaPolitico.SelectedIndex == 2)
                ExibeDTPoliticoOrdenadoPorMilhoes();
            else if (cbEscolhaPolitico.SelectedIndex == 3)
                ExibeDTPoliticoOrdenadoPorNome();
            else if (cbEscolhaPolitico.SelectedIndex == 4)
                ExibeDTPoliticoOrdenadoPorPartido();
            else if (cbEscolhaPolitico.SelectedIndex == 5)
                ExibeDTPoliticoOrdenadoPorChapa();

        }
        private void cbEscolhaPartido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEscolhaPartido.SelectedIndex == 1)
                ExibeDTPartidoOrdenadoPorCodigo();
            else if (cbEscolhaPartido.SelectedIndex == 2)
                ExibeDTPartidoOrdenadoPorNome();
            else if (cbEscolhaPartido.SelectedIndex == 3)
                ExibeDTPartidoOrdenadoPorFinanciador();
            else if (cbEscolhaPartido.SelectedIndex == 4)
                ExibeDTPartidoOrdenadoPorJuiz();
            else if (cbEscolhaPartido.SelectedIndex == 5)
                ExibeDTPartidoOrdenadoPorChapa();

        }
    }
}
