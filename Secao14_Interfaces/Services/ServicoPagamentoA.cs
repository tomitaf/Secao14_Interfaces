using System;
using System.Collections.Generic;
using Secao14_Interfaces.Entities;

namespace Secao14_Interfaces.Services
{
    class ServicoPagamentoA : IServicoPagamento
    {
        public double ProcessarParcela(double valor, int indParcela, double juros, double taxa)
        {
            return valor * (1 + (indParcela * juros)) * (1 + taxa);
        }
    }
}
