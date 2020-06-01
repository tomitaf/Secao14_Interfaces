using System;   //Necessário para utilizar a interface IComparable
using System.Globalization;

namespace Secao14_Interfaces.Entities
{
    class Funcionario : IComparable
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        
        public Funcionario(string csvFuncionario)
        {
            string[] vetor = csvFuncionario.Split(',');
            Nome = vetor[0];
            Salario = double.Parse(vetor[1], CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Nome: "
                + Nome
                + ", Salario: "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            //Ordenação por nome
            if (!(obj is Funcionario)) throw new ArgumentException("Objeto não é Funcionario");
            Funcionario f = obj as Funcionario;
            return Nome.CompareTo(f.Nome);
        }
    }
}
