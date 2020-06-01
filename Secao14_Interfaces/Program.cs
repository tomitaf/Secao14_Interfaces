using System;
using System.Globalization;
using Secao14_Interfaces.Entities;
using Secao14_Interfaces.Entities.Enums;
using Secao14_Interfaces.Services;

namespace Secao14_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //SolucaoSemInterfaces();
            //Secao14_ExFixacao();
            HerancaInterface();
        }

        public static void HerancaInterface()
        {
            IForma circulo = new Circulo()
            {
                Raio = 10.0,
                Cor = Cor.Preto
            };

            IForma retangulo = new Retangulo()
            {
                Largura = 5,
                Altura = 2,
                Cor = Cor.Azul
            };

            Console.WriteLine("Círculo: ");
            Console.WriteLine(circulo);
            Console.WriteLine();
            Console.WriteLine("Retânculo: ");
            Console.WriteLine(retangulo);
        }

        public static void Secao14_ExFixacao()
        {
            // Input de informações
            Console.Write("Numero do contrato: ");
            int numeroContrato = int.Parse(Console.ReadLine());
            Console.Write("Data início do contrato (dd/mm/yyyy): ");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor que deseja parcelar: ");
            double valorContrato = double.Parse(Console.ReadLine());
            Console.Write("Número de parcelas: ");
            int numeroParcelas = int.Parse(Console.ReadLine());

            // Implementar as classes e interfaces necessárias
            Contrato contrato = new Contrato(numeroContrato, dataInicio, valorContrato, numeroParcelas);
            ServicoParcelas servicoParcelas = new ServicoParcelas(contrato, new ServicoPagamentoA());
            Console.WriteLine("Processando parcelas...");
            servicoParcelas.ProcessarParcelas();
            Console.WriteLine("Imprimindo parcelas...");
            servicoParcelas.ImprimirContrato();

        }

        public static void SolucaoSemInterfaces()
        {
            Console.Write("Modelo do carro: ");
            string modelo = Console.ReadLine();
            Console.Write("Data e hora do aluguel: ");
            DateTime dataInicio = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Data e hora da devolução: ");
            DateTime dataFim = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Preço por hora: ");
            double precoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Preço por dia: ");
            double precoDia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            AluguelCarro aluguelCarro = new AluguelCarro(dataInicio, dataFim, new Veiculo(modelo));
            ServicoAluguel servicoAluguel = new ServicoAluguel(precoHora, precoDia, new ServicoImpostoBrasil());
            servicoAluguel.ProcessarInvoice(aluguelCarro);
            Console.WriteLine("INVOICE");
            Console.WriteLine(aluguelCarro.Invoice);

        }

    }
}
