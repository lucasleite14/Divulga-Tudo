using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnuncio.Classe
{
    class calculadora
    {
        double comp = 30.0, totalVizualizacao = 0, totalVisualizacaoFinal = 0, totalValor = 0;
        int j = 0, clique = 12, totalClique = 0, k = 0, totalCompartilhamento = 0;
        public calculadora()
        {

        }


        public void valorDias(DateTime datainicial, DateTime datafinal, double valor)
        {
            TimeSpan date = datafinal - datainicial;
            totalValor = date.Days * valor;
        }


        public void compartilhamento(double valor)
        {

            totalVizualizacao = comp * valor; //Calcula o total de vizualizações por dia. 

            if (totalVizualizacao >= 100) // Verifica se mais de 100 pessoas visualizaram o anuncio
            {
                for (int i = 100; i <= totalVizualizacao; i += 100)
                {
                    j++;
                }

                totalClique = 12 * j; // Calcula o valor de cliques a cada 100 pessoas

                if (totalClique >= 20)
                {
                    for (int i = 20; i <= totalClique; i += 20)
                    {
                        k++;
                        if (k == 4)
                        {
                            break;
                        }
                    }

                    totalCompartilhamento = k * 3; //Calcula o total de compatilhamentos
                    totalVisualizacaoFinal = (totalVizualizacao + (totalCompartilhamento * 40)); // Calcula o total de vizulizações. 
                }
            }


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Total Investido: R$ " + totalValor.ToString("F2"));
            sb.AppendLine("Total de Visualizações: " + (totalVisualizacaoFinal));
            sb.AppendLine("Total de Cliques: " + (totalClique));
            sb.AppendLine($"Total de Compartilhamentos: {totalCompartilhamento}");
            return sb.ToString();
        }
    }
}
