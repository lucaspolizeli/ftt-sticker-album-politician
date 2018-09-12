using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlbumFigPoliticos.Ordenação
{
    static class BubleSort
    {
        // BubleSort dos Politicos
        public static Politico[] OrdenaPoliticoPorCodigo(Politico[] vetor)
        {
            Politico aux;
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (vetor[j].Codigo > vetor[j + 1].Codigo)
                    {
                        //efetua a troca de valores
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }
        public static Politico[] OrdenaPoliticoPorChapa(Politico[] vetor)
        {
            Politico aux;
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (vetor[j].NumeroChapa > vetor[j + 1].NumeroChapa)
                    {
                        //efetua a troca de valores
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }
        public static Politico[] OrdenaPoliticoPorMilhoesLavados(Politico[] vetor)
        {
            Politico aux;
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (vetor[j].MilhoesLavados > vetor[j + 1].MilhoesLavados)
                    {
                        //efetua a troca de valores
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }

        // BubleSort dos Partidos
        public static Partido[] OrdenaPartidoPorChapa(Partido[] vetor)
        {
            Partido aux;
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (vetor[j].NumeroChapa > vetor[j + 1].NumeroChapa)
                    {
                        //efetua a troca de valores
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }
        public static Partido[] OrdenaPartidoPorCodigo(Partido[] vetor)
        {
            Partido aux;
            for (int i = vetor.Length - 1; i >= 1; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (vetor[j].Codigo > vetor[j + 1].Codigo)
                    {
                        //efetua a troca de valores
                        aux = vetor[j];
                        vetor[j] = vetor[j + 1];
                        vetor[j + 1] = aux;
                    }
                }
            }
            return vetor;
        }
    }
}
