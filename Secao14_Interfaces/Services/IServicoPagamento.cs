using System;
using System.Collections.Generic;
using Secao14_Interfaces.Entities;

namespace Secao14_Interfaces.Services
{
    interface IServicoPagamento
    {
        double ProcessarParcela(double valor, int indParcela, double juros, double taxa);
    }
}
