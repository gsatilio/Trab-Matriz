//int[] nome = new int[10];
//int[][] matriz = new int[3][3];
int qtdelinhas = 3, qtdecolunas = 3;

int[,] matriz1 = new int[qtdelinhas, qtdecolunas];
int[,] matriz2 = new int[qtdelinhas, qtdecolunas];

int[,] matrizadd = new int[qtdelinhas, qtdecolunas];
int[,] matrizsub = new int[qtdelinhas, qtdecolunas];
int[,] matrizmult = new int[qtdelinhas, qtdecolunas];
float[,] matrizdiv = new  float[qtdelinhas, qtdecolunas];

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


Console.WriteLine("\nMATRIZ 1:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matriz1[linha,coluna] + " ");
    }
}


Console.WriteLine("\nMATRIZ 2:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matriz2[linha, coluna] + " ");
    }
}

Console.Write("\n------------------------------------");


// calcuna matriz 3
for (int linha = 0;linha < qtdelinhas; linha++)
{
    for(int coluna = 0;coluna < qtdecolunas; coluna++)
    {
        matrizadd[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
        matrizsub[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
        matrizmult[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
        matrizdiv[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
    }
}

Console.Write("\nOperação de SOMA:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matrizadd[linha, coluna] + " ");
    }
}

Console.Write("\nOperação de SUBTRAÇÃO:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matrizsub[linha, coluna] + " ");
    }
}

Console.WriteLine("\nOperação de MULTIPLICAÇÃO:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matrizmult[linha, coluna] + " ");
    }
}

Console.WriteLine("\nOperação de DIVISÃO:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    Console.WriteLine();
    for (int coluna = 0; coluna < qtdecolunas; coluna++)
    {
        Console.Write(matrizdiv[linha, coluna] + " ");
    }
}


int numero = 0;
Console.WriteLine("\nOperação de SOMA LINHAS:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    int col = 0;
    while (col < qtdecolunas)
    {
        numero += matriz1[linha,col];
        col++;
    }
    Console.WriteLine($"Linha: {linha} resulta em: {numero}");
    numero = 0;
}


Console.WriteLine("\nReferente a Matriz 1:");

numero = 0;
Console.WriteLine("\nOperação de SOMA COLUNAS:");
for (int col = 0; col < qtdecolunas; col++)
{
    int lin = 0;
    while (lin < qtdelinhas)
    {
        numero += matriz1[lin, col];
        lin++;
    }
    Console.WriteLine($"Coluna: {col} resulta em: {numero}");
    numero = 0;
}

int dig1 = 0;
int dig2 = 0;
int coldiag2 = qtdecolunas - 1;
Console.WriteLine("\nOperação de SOMA  DIAGONAIS:");
for (int linha = 0; linha < qtdelinhas; linha++)
{
    for (int col = 0; col < qtdecolunas; col++)
    {
        // diagonal esquerda para direita
        if (linha == col) {
            dig1 += matriz1[linha, col];
        }
        //diagonal direita para esquerda
        if (col == coldiag2)
        {
            dig2 += matriz1[linha, coldiag2];
            coldiag2--;
        }
    }
}

Console.WriteLine($"Diagonal 1 resulta em: {dig1}");
Console.WriteLine($"Diagonal 2 resulta em: {dig2}");
