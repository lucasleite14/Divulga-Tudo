using System;
using System.Collections.Generic;
using CadastroAnuncio.Classe;

namespace CadastroAnuncio
{
    class Program
    {
        static void Main(string[] args)
        {
            List<cadastroAnuncio> listaCadastro = new List<cadastroAnuncio>();

            char sair;

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Cadastrar Anuncio");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.Write("Informe o nome do anuncio: ");
                string nomeAnuncio = Console.ReadLine();
                Console.Write("Informe o nome do Cliente: ");
                string nomeCliente = Console.ReadLine();
                Console.Write("Data de Inicio: ");
                DateTime dataInicio = DateTime.Parse(Console.ReadLine());
                Console.Write("Data Final: ");
                DateTime dataFinal = DateTime.Parse(Console.ReadLine());
                Console.Write("Investimento por dia: ");
                double investimentoDia = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("__________________________________________________");
                Console.Write("Deseja inserir mais um anuncio S/N: ");
                sair = char.Parse(Console.ReadLine().ToLower());
                Console.WriteLine("__________________________________________________");
                Console.WriteLine();

                cadastroAnuncio insereAnuncio = new cadastroAnuncio(nomeAnuncio, nomeCliente, dataInicio, dataFinal, investimentoDia);
                listaCadastro.Add(insereAnuncio);
                insereAnuncio.addItem();
            }
            while (sair == 's');

            Console.Clear();

            do
            {
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Relatório");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine();
                Console.WriteLine("1 - Todos os contratos");
                Console.WriteLine("2 - Filtrar contratos");
                Console.WriteLine("3 - Sair");
                Console.Write("Selecione a opção: ");
                sair = char.Parse(Console.ReadLine());
                Console.Clear();

                if (sair == '3')
                {
                    break;
                }
                else if (sair == '1')
                {
                    foreach (cadastroAnuncio cadastro in listaCadastro)
                    {
                        Console.WriteLine(cadastro.ToString());

                    }
                }
                else if (sair == '2')
                {
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine("Filtros");
                    Console.WriteLine("--------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine("1 - Filtrar por nome do cliente ");
                    Console.WriteLine("2 - Filtrar por data ");
                    Console.WriteLine("3 - Sair");
                    Console.Write("Selecione uma opção: ");
                    sair = char.Parse(Console.ReadLine());
                    Console.Clear();


                    if (sair == '1')
                    {
                        Console.Write("Informe o nome do cliente: ");
                        string nomeCliente = Console.ReadLine();

                        foreach (cadastroAnuncio cad in listaCadastro)
                        {
                            if (cad.Cliente.Contains(nomeCliente))
                            {
                                Console.WriteLine(cad.ToString());
                            }
                        }
                    }
                    else if (sair == '2')
                    {
                        Console.Write("Infrome a data de inicio: ");
                        DateTime dataInicio = DateTime.Parse(Console.ReadLine());
                        Console.Write("Informe a data final: ");
                        DateTime dataFinal = DateTime.Parse(Console.ReadLine());

                        if (dataInicio == null && dataFinal == null || dataFinal < dataInicio)
                        {
                            Console.WriteLine("Informações incorretas");
                        }
                        else
                        {
                            foreach (cadastroAnuncio cad in listaCadastro)
                            {
                                if (cad.dataInicio.Equals(dataInicio) && cad.dataTermino.Equals(dataFinal))
                                {
                                    Console.WriteLine(cad.ToString());
                                }
                            }
                        }
                    }
                    else { }

                }
            }
            while (sair != '3');
        }
    }
}
