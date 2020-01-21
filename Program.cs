using System;

namespace questão012
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor A: ");
            var texto = Console.ReadLine();
            double A = double.Parse(texto);

            Console.WriteLine("Digite o Valor B: ");
            var texto2 = Console.ReadLine();
            double B = double.Parse(texto2);

            Console.WriteLine("Digite o Valor C: ");
            var texto3 = Console.ReadLine();
            double C = double.Parse(texto3);

            double raiz = Math.Pow(B, 2) -4 * A * C;
            if (raiz > 0)
            {
                double x1 = ((-B) + Math.Sqrt(raiz) / (2 * A));
                double x2 = ((-B) - Math.Sqrt(raiz) / (2 * A));

                Console.WriteLine("Valor da primeira linha é: " + x1);
                Console.WriteLine("Valor da segunda linha é: " + x2);
            }
            else
            {
                Console.WriteLine("Impossível calcular");
            }
        }
    }
}
