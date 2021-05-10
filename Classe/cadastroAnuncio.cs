using System;
using System.Collections.Generic;
using System.Text;

namespace CadastroAnuncio.Classe
{
    class cadastroAnuncio
    {
        public string nomeAnuncio { get; set; }
        public string Cliente { get; set; }
        public DateTime dataInicio { get; set; }
        public DateTime dataTermino { get; set; }
        public double investimentoDia { get; set; }

        calculadora calc = new calculadora();

        public cadastroAnuncio()
        {

        }

        public cadastroAnuncio(string nomeanuncio, string cliente, DateTime datainicio, DateTime datatermino, double investimentodia)
        {
            nomeAnuncio = nomeanuncio;
            Cliente = cliente;
            dataInicio = datainicio;
            dataTermino = datatermino;
            investimentoDia = investimentodia;
        }

        public void addItem()
        {
            calc.valorDias(dataInicio, dataTermino, investimentoDia);
            calc.compartilhamento(investimentoDia);
        }


        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("---------------------------------");
            sb.AppendLine("Contrato");
            sb.AppendLine("---------------------------------");
            sb.AppendLine();
            sb.AppendLine($"Nome do Aununcio: {nomeAnuncio}");
            sb.AppendLine($"Nome do Cliente: {Cliente}");
            sb.AppendLine($"Data de Inicio: {dataInicio.ToString()}");
            sb.AppendLine($"Data Final: {dataTermino.ToString()}");
            sb.AppendLine($"Investimento por dia: R$ {investimentoDia.ToString("F2")}");
            //sb.AppendLine($"Valor total de Investimento: R$ {calc.valorDias(dataInicio, dataTermino, investimentoDia).ToString("F2")}");
            //sb.AppendLine(calc.ToString());
            
            sb.AppendLine(calc.ToString());
            return sb.ToString();

        }
    }
}
