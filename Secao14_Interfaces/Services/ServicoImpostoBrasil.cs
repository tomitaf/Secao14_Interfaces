
namespace Secao14_Interfaces.Services
{
    class ServicoImpostoBrasil : IServicoImposto    // Aqui está sendo dito que a classe ServicoImpostoBrasil é um subtipo
        // da interface IServicoImposto
    {
        public double Imposto(double valor)
        {
            if(valor <= 100)
            {
                return valor * 0.2;
            }
            else
            {
                return valor * 0.15;
            }

        }

    }
}
