using System;
using Secao14_Interfaces.Entities;

namespace Secao14_Interfaces.Entities
{
    class AluguelCarro
    {
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public Veiculo Veiculo { get; set; }
        public Invoice Invoice { get; set; }

        public AluguelCarro(DateTime dataInicio, DateTime dataFim, Veiculo veiculo)
        {
            DataInicio = dataInicio;
            DataFim = dataFim;
            Veiculo = veiculo;
            Invoice = null;     // O Invoice só deve ser gerado quando enviarmos a ordem de processamento
        }
    }
}
