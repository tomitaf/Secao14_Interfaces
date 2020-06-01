using System;
using System.Globalization;

namespace Secao14_Interfaces.Entities
{
    class Parcela
    {
        public DateTime Vencimento { get; set; }
        public double ValorParcela { get; set; }
        public int OrdParcela { get; set; }

        public Parcela(DateTime vcto, double valor, int ordParcela)
        {
            Vencimento = vcto;
            ValorParcela = valor;
            OrdParcela = ordParcela;
        }

        public override string ToString()
        {
            return "#" + OrdParcela
                + "Vencimento: "
                + Vencimento.ToString("dd/MM/yyyy")
                + ", Valor: "
                + ValorParcela.ToString("F2", CultureInfo.InvariantCulture);
                
        }
    }
}
