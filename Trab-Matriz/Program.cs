//int[] nome = new int[10];
//int[][] matriz = new int[3][3];
int qtdelinhas = 0, qtdecolunas = 0, opcao = 0;
float[,] matriz1 = new float[qtdelinhas, qtdecolunas];
float[,] matriz2 = new float[qtdelinhas, qtdecolunas];
float[,] matriz3 = new float[qtdelinhas, qtdecolunas];

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

void escolherTamanho()
{
    Console.WriteLine("Bem vindo ao Matriz Simulator!");
    while (qtdelinhas <= 0)
    {
        Console.WriteLine("Informe o nro de Linhas de sua Matriz:");
        qtdelinhas = int.Parse(Console.ReadLine());
    }

    while (qtdecolunas <= 0)
    {
        Console.WriteLine("Informe o nro de Colunas de sua Matriz:");
        qtdecolunas = int.Parse(Console.ReadLine());
    }
}

void escolherOpcao()
{
    while (opcao <= 0 || opcao > 5)
    {
        escolherTamanho();
        Console.Clear();
        Console.WriteLine($"Nro de Linhas informada:{qtdelinhas} e Nro de Colunas informada: {qtdecolunas}");
        Console.WriteLine("Escolha a opção desejada:");
        Console.WriteLine("1 - Adição:");
        Console.WriteLine("2 - Subtração:");
        Console.WriteLine("3 - Multiplicação:");
        Console.WriteLine("4 - Divisão:");
        Console.WriteLine("5 - Para voltar ao Inicio.");
        opcao = int.Parse(Console.ReadLine());

        if (opcao == 5)
        {
            qtdelinhas = 0;
            qtdecolunas = 0;
            opcao = 0;
            Console.Clear();
            escolherOpcao();
        }
    }
}

void criarMatriz(float[,] entradaMatriz)
{
    for (int linha = 0; linha < qtdelinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdecolunas; coluna++)
        {
            entradaMatriz[linha, coluna] = new Random().Next(1, 20);
        }
    }
}

void realizaOperacao(int tipo)
{
    for (int linha = 0; linha < qtdelinhas; linha++)
    {
        for (int coluna = 0; coluna < qtdecolunas; coluna++)
        {
            switch (tipo)
            {
                case 1:
                    matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                    break;
                case 2:
                    matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                    break;
                case 3:
                    matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                    break;
                case 4:
                    matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                    break;
            }
            
        }
    }
}

escolherOpcao();

matriz1 = new float[qtdelinhas, qtdecolunas];
matriz2 = new float[qtdelinhas, qtdecolunas];
matriz3 = new float[qtdelinhas, qtdecolunas];

criarMatriz(matriz1);
criarMatriz(matriz2);
realizaOperacao(opcao);

imprimirMatriz(matriz1, "\nMATRIZ 1:");
imprimirMatriz(matriz2, "\nMATRIZ 2:");

switch (opcao)
{
    case 1:
        imprimirMatriz(matriz3, "\nOperação de SOMA:");
        break;
    case 2:
        imprimirMatriz(matriz3, "\nOperação de SUBTRAÇÃO:");
        break;
    case 3:
        imprimirMatriz(matriz3, "\nOperação de MULTIPLICAÇÃO:");
        break;
    case 4:
        imprimirMatriz(matriz3, "\nOperação de DIVISÃO:");
        break;

}


/*
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
*/

