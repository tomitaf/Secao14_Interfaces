using System;

namespace Secao14_Interfaces.Entities
{
    class Contrato
    {
        public int NumeroContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotal { get; set; }
        public Parcela[] Parcelas;

        public Contrato(int numeroContrato, DateTime data, double valor, int numParcelas)
        {
            NumeroContrato = numeroContrato;
            DataContrato = data;
            ValorTotal = valor;
            Parcelas = new Parcela[numParcelas];
        }
    }
}
