using System;

namespace NotasEstudiantes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la primera nota del estudiante");
            string valor1 = Console.ReadLine();
            int nota1 = Convert.ToInt32(valor1);

            Console.WriteLine("Digite la segunda nota del estudiante");
            string valor2 = Console.ReadLine();
            int nota2 = Convert.ToInt32(valor2);

            Console.WriteLine("Digite la tercera nota del estudiante");
            string valor3 = Console.ReadLine();
            int nota3 = Convert.ToInt32(valor3);

            double promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("Nota 1: {0}, Nota 2: {1} y Nota 3: {2} = Promedio {3}", nota1, nota2, nota3, promedio);
        }
    }
}
