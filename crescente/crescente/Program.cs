

Console.WriteLine("Digite um número");
int n1 = int.Parse(Console.ReadLine() ?? "0");
int n2 = int.Parse(Console.ReadLine() ?? "0");

while (n1 != n2) {
    if (n1 > n2) {
        Console.WriteLine("Decrescente");
    }
    else{
        Console.WriteLine("Crescente");
        }

    Console.WriteLine("Digite um número");
    n1 = int.Parse(Console.ReadLine() ?? "0");
    n2 = int.Parse(Console.ReadLine() ?? "0");
}