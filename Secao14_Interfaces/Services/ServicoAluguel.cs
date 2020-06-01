using Secao14_Interfaces.Entities;
using Secao14_Interfaces.Services;
using System;

namespace Secao14_Interfaces.Services
{
    class ServicoAluguel
    {
        public double PrecoHora { get; private set; }
        public double PrecoDia { get; private set; }
        private IServicoImposto _servicoImposto;    //Uso de interface (não importa mais qual serviço de imposto está sendo usado
        // Ele somente precisa realizar as operações desejadas
        //public ServicoImpostoBrasil _servicoImpostoBrasil = new ServicoImpostoBrasil();

        // O parâmetro servicoImposto foi inserido após a implementação da interface IServicoImposto
        public ServicoAluguel(double precoHora, double precoDia, IServicoImposto servicoImposto)
        {
            PrecoHora = precoHora;
            PrecoDia = precoDia;
            _servicoImposto = servicoImposto;
        }

        public void ProcessarInvoice(AluguelCarro aluguelCarro)
        {
            TimeSpan duracao = aluguelCarro.DataFim.Subtract(aluguelCarro.DataInicio);
            double pagamentoBasico = 0.0;
            if(duracao.TotalHours <= 12.0)
            {
                pagamentoBasico = PrecoHora * Math.Ceiling(duracao.TotalHours); // A função Math.Ceiling arredonda o valor passado como parâmetro para cima
            }
            else
            {
                pagamentoBasico = PrecoDia * Math.Ceiling(duracao.TotalDays);
            }

            double imposto = _servicoImposto.Imposto(pagamentoBasico);

            aluguelCarro.Invoice = new Invoice(pagamentoBasico, imposto);
        }
    }
}
 