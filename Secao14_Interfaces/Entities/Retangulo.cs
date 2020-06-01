using System;
using System.Collections.Generic;
using System.Text;

namespace Secao14_Interfaces.Entities
{
    class Retangulo : AbstrataForma
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public override double Area()
        {
            return Largura * Altura;
        }

        public override string ToString()
        {
            return "Cor: "
                + Cor
                + ", Largura: "
                + Largura
                + ", Altura: "
                + Altura
                +", Area: "
                + Area();
        }
    }
}
