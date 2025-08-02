using System;
using System.Globalization;


namespace ConsoleApp1 {
    internal class Program {
        static void Main(string[] args) {

            double salario1, salario2;
            string nome1, nome2;
            int idade;
            char sexo;

            Console.WriteLine("Digite o nome da primeira pessoa: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("Digite o salario da pessoa");
            salario1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("Digite o salario da segunda pessoa");
            salario2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma idade: ");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um sexo f/m");
            sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome 1= " +nome1);
            Console.WriteLine("salario1= " + salario1.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Nome 2= " + nome2);
            Console.WriteLine("salario2= " + salario2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Idade = " + idade);
            Console.WriteLine("Sexo = " + sexo );

        }
    }
}
