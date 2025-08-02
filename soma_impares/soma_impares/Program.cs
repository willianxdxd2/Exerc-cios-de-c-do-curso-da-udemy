Console.WriteLine("Digite um número");
int n1 = int.Parse(Console.ReadLine() ?? "0");
int n2 = int.Parse(Console.ReadLine() ?? "0");
int soma = 0;
int troca = 0;


if (n1 > n2) {
    troca = n2;
    n2 = n1;
    n1 = troca;
}


for (int i = n1+1; i < n2; i++) {
    if (i % 2 != 0) {
        soma = soma + i;
    }
}

Console.WriteLine("A soma dos Impares é de : " + soma);