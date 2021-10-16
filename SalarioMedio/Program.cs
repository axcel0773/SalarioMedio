using System;

namespace SalarioMedio
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioFuncionario;
            double salarioMinimo;
            double resultado;

            Console.WriteLine("Digite o valor do seu salário:");
            salarioFuncionario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o valor do salário mínimo:");
            salarioMinimo = Convert.ToDouble(Console.ReadLine());

            resultado = (salarioFuncionario / salarioMinimo);

            Console.WriteLine("Você recebe {0} salário mínimo", resultado);
        }
    }
}
