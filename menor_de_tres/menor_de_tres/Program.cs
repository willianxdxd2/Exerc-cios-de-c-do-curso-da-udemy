

int[] vet= new int[3];

for (int i = 0; i < 3; i++) {
    Console.WriteLine("digite um numero");
    vet[i] = int.Parse(Console.ReadLine() ?? "0");

}




int menor;
menor = vet[0];
for (int i = 0; i < 3; i++) {
    if (vet[i] < menor) {
        menor = vet[i];
    }
}

Console.WriteLine("O menor número é : " + menor);