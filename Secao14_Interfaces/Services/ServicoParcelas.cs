using System;
using Secao14_Interfaces.Entities;
using System.Text;

namespace Secao14_Interfaces.Services
{
    class ServicoParcelas
    {
        public Contrato Contrato { get; set; }
        public IServicoPagamento _servicoPagamento;

        public ServicoParcelas(Contrato contrato, IServicoPagamento servicoPagamento)
        {
            Contrato = contrato;
            _servicoPagamento = servicoPagamento;
        }

        public void ProcessarParcelas()
        {
            double juros = 0.01;
            double taxaPagamento = 0.02;
            int qtdParcelas = Contrato.Parcelas.Length;
            double valorBase = Contrato.ValorTotal / qtdParcelas;
            for(int i = 0; i < qtdParcelas; i++)
            {
                DateTime dataParcela = Contrato.DataContrato.AddMonths(i + 1);
                double valorParcela = _servicoPagamento.ProcessarParcela(valorBase, i + 1, juros, taxaPagamento);
                Contrato.Parcelas[i] = new Parcela(dataParcela, valorParcela, i+1);
            }
        }

        public void ImprimirContrato()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("# Contrato: " + Contrato.NumeroContrato);
            sb.AppendLine("Data do contrato: " + Contrato.DataContrato);
            sb.AppendLine("# Parcelas: " + Contrato.Parcelas.Length);
            foreach(Parcela parc in Contrato.Parcelas)
            {
                sb.AppendLine(parc.ToString());
            }
            Console.WriteLine(sb.ToString());
        }


    }
}
