





Console.WriteLine("Digite seu nome");
string n1 = Console.ReadLine() ?? " ";
Console.WriteLine("Digite sua idade");
int idade1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Digite outro nome");
string n2 = (Console.ReadLine() ?? "0");
Console.WriteLine("Digite outra idade ai no final ele calcula a media entendeu");
int idade2 = int.Parse(Console.ReadLine() ?? "0");

double media;
media = (idade1 + idade2) / 2;

Console.WriteLine("A idade média entre " + n1 + " e " + n2 + " é de: " + media);
