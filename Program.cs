using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            double peso;
            double altura;

            Console.Write("Altura (m)..: ");
            altura = double.Parse(Console.ReadLine());

            Console.Write("Peso (kg)...: ");
            peso = double.Parse(Console.ReadLine());

            double alturares;
            double resultadofinal;

            alturares = (altura * 2);
            resultadofinal = peso / alturares;

            Console.WriteLine();

            Console.WriteLine($"IMC: {resultadofinal:N1} kg/m²");

            Console.WriteLine();

            Console.WriteLine("Presione qualquer tecla para finalizar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
