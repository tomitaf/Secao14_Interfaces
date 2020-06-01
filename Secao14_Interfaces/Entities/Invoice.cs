using System.Globalization;

namespace Secao14_Interfaces.Entities
{
    class Invoice
    {
        public double PagamentoBasico { get; set; }
        public double Imposto { get; set; }
        
        public Invoice(double pagamentoBasico, double imposto)
        {
            PagamentoBasico = pagamentoBasico;
            Imposto = imposto;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Imposto; }
        }

        public override string ToString()
        {
            return "Pagamento básico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImposto: "
                + Imposto.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento Total: "
                + PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
