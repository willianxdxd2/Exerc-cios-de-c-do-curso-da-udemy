using System;

namespace Programa {
    class Program {
        static void Main(string[] args) {

            int b, h;
            double p, d, a;

            Console.WriteLine("Digite a base do retangulo");
            while (!int.TryParse(Console.ReadLine(), out b)) {
                Console.WriteLine("Entrada inválida, digite outra: ");
            }
            Console.WriteLine("Digite a altura do retangulo");
            while (!int.TryParse(Console.ReadLine(), out h)) {
                Console.WriteLine("Entrada inválida, digite outra: ");
            }

            a = b * h;
            p = b*2 + h * 2;
            d = Math.Sqrt(b * b + h * h);

            Console.WriteLine("ÁREA: " + a );
            Console.WriteLine("Perimetro: " + p);
            Console.WriteLine("Diagonal:"  + d);

        }
    }
}
