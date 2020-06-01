using System;
namespace Secao14_Interfaces.Entities
{
    class Circulo : AbstrataForma
    {
        public double Raio { get; set; }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }

        public override string ToString()
        {
            return "Cor: "
                + Cor
                + ", Raio: "
                + Raio
                + ", Area: "
                + Area();
        }
    }
}
