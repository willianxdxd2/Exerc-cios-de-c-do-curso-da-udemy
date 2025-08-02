
using System.Runtime.Serialization;

Console.WriteLine("Quantos números vc vai digitar?");
    int n1 = int.Parse(Console.ReadLine() ?? "0");

int[] vet = new int[n1];

for (int i = 0; i < n1; i++) {
    vet[i] = int.Parse(Console.ReadLine () ?? "0");
}

Console.WriteLine("Valores");
int soma = 0;
for (int i = 0; i < n1; i++) {
    Console.WriteLine(vet[i]);
    
    soma = soma + vet[i];
}
double media;
media = soma / n1;

Console.WriteLine("Média: " + media);
Console.WriteLine("soma:" + soma);