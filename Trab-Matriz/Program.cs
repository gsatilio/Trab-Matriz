//int[] nome = new int[10];
//int[][] matriz = new int[3][3];
int qtdelinhas = 3, qtdecolunas = 3;

float[,] matriz1 = new float[qtdelinhas, qtdecolunas];
float[,] matriz2 = new float[qtdelinhas, qtdecolunas];

float[,] matrizadd = new float[qtdelinhas, qtdecolunas];
float[,] matrizsub = new float[qtdelinhas, qtdecolunas];
float[,] matrizmult = new float[qtdelinhas, qtdecolunas];
float[,] matrizdiv = new  float[qtdelinhas, qtdecolunas];


void imprimirMatriz(float[,] matriz, string titulo)
{
    Console.Write(titulo);
    for (int linha = 0; linha < qtdelinhas; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < qtdecolunas; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
    Console.WriteLine();
}

//criacao matriz 1
for (int linha = 0; linha < qtdelinhas; linha++)
{
    for(int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        matriz1[linha, coluna] = new Random().Next(1,20);
    }
}

//criacao matriz 2
for (int linha = 0; linha < qtdelinhas; linha++)
{
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        matriz2[linha, coluna] = new Random().Next(1, 20);
    }
}
imprimirMatriz(matriz1, "\nMATRIZ 1:");

imprimirMatriz(matriz2, "\nMATRIZ 2:");

// calcuna matriz 3
for (int linha = 0;linha < qtdelinhas; linha++)
{
    for(int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        matrizadd[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        matrizsub[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        matrizmult[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        matrizdiv[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
    }
}

imprimirMatriz(matrizadd, "\nOperação de SOMA:");

imprimirMatriz(matrizsub, "\nOperação de SUBTRAÇÃO:");

imprimirMatriz(matrizmult, "\nOperação de MULTIPLICAÇÃO:");

imprimirMatriz(matrizdiv, "\nOperação de DIVISÃO:");


////////////////////////////
///

Console.WriteLine("\nReferente a Matriz 1:");

float resultado = 0;
Console.WriteLine("\nOperação de SOMA LINHAS:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    int col = 0;
    while (col < qtdecolunas)
    {
        resultado += matriz1[linha, col];
        col++;
    }
    Console.WriteLine($"Linha: {linha} resulta em: {resultado}");
    resultado = 0;
}


resultado = 0;
Console.WriteLine("\nOperação de SOMA COLUNAS:");
for (int col = 0; col < qtdecolunas; col++)
{
    int lin = 0;
    while (lin < qtdelinhas)
    {
        resultado += matriz1[lin, col];
        lin++;
    }
    Console.WriteLine($"Coluna: {col} resulta em: {resultado}");
    resultado = 0;
}

float diag1 = 0;
float diag2 = 0;
int coldiag2 = qtdecolunas - 1;
Console.WriteLine("\nOperação de SOMA  DIAGONAIS:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    for (int col = 0; col < qtdecolunas; col++)
    {
        // diagonal esquerda para direita
        if (linha == col) {
            diag1 += matriz1[linha, col];
        }
        //diagonal direita para esquerda
        if (col == coldiag2)
        {
            diag2 += matriz1[linha, coldiag2];
            coldiag2--;
        }
    }
}

Console.WriteLine($"Diagonal 1 resulta em: {diag1}");
Console.WriteLine($"Diagonal 2 resulta em: {diag2}");
