using Secao14_Interfaces.Entities.Enums;

namespace Secao14_Interfaces.Entities
{
    abstract class AbstrataForma : IForma
    {
        public Cor Cor { get; set; }

        public abstract double Area();
    }
}
