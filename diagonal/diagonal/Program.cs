Console.WriteLine("Qual a ordem da matriz?");
int n1 = int.Parse(Console.ReadLine() ?? "0");
int[,] mat = new int[n1, n1];

for (int i = 0; i < n1; i++) {
    for (int j = 0; j < n1; j++) {

        Console.WriteLine("Elemento [ " + i + "," + j + "] :");
        mat[i, j] = int.Parse(Console.ReadLine() ?? "0");
    }
}
int cont = 0;
Console.WriteLine("Diagonal principal: ");
for (int i = 0; i < n1; i++) {
    for (int j = 0; j < n1; j++) {

        if (mat[i, j] == mat[i, i]) {
            Console.WriteLine(mat[i, j]);
        }
        if (mat[i,j] < 0) {

                cont++;
        }
    }
}

Console.WriteLine("Quantidade de negativos = " + cont);