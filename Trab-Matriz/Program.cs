//int[] nome = new int[10];
//int[][] matriz = new int[3][3];
int tamanhoMatriz = 0, opcao = 0;
string titulo = "";
float[,] matriz1 = new float[tamanhoMatriz, tamanhoMatriz];
float[,] matriz2 = new float[tamanhoMatriz, tamanhoMatriz];
float[,] matriz3 = new float[tamanhoMatriz, tamanhoMatriz];
void imprimirMatriz(float[,] matriz, string titulo)
{
    Console.Write(titulo);
    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
            Console.Write(matriz[linha, coluna] + " ");
        }
    }
    Console.WriteLine();
}
void escolherTamanho()
{
    Console.WriteLine("Bem vindo ao Matriz Quadrada Simulator!");
    while (tamanhoMatriz <= 0)
    {
        Console.WriteLine("Informe o nro de Linhas/Colunas de sua Matriz:");
        tamanhoMatriz = int.Parse(Console.ReadLine());
    }
}
void realizaOperacao(int tipo)
{
    matriz1 = new float[tamanhoMatriz, tamanhoMatriz];
    matriz2 = new float[tamanhoMatriz, tamanhoMatriz];
    matriz3 = new float[tamanhoMatriz, tamanhoMatriz];
    criarMatriz(matriz1);
    criarMatriz(matriz2);
    imprimirMatriz(matriz1, "\nMATRIZ 1:");
    imprimirMatriz(matriz2, "\nMATRIZ 2:");
    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
            switch (tipo)
            {
                case 1:
                    titulo = "\nOperação de SOMA";
                    matriz3[linha, coluna] = matriz1[linha, coluna] + matriz2[linha, coluna];
                    break;
                case 2:
                    titulo = "\nOperação de SUBTRAÇÃO";
                    matriz3[linha, coluna] = matriz1[linha, coluna] - matriz2[linha, coluna];
                    break;
                case 3:
                    titulo = "\nOperação de MULTIPLICAÇÃO";
                    matriz3[linha, coluna] = matriz1[linha, coluna] * matriz2[linha, coluna];
                    break;
                case 4:
                    titulo = "\nOperação de DIVISÃO";
                    matriz3[linha, coluna] = matriz1[linha, coluna] / matriz2[linha, coluna];
                    break;
            }
        }
    }
    imprimirMatriz(matriz3, $"{titulo}");
}
void Menu()
{
    while (opcao <= 0 || opcao > 5)
    {
        tamanhoMatriz = 0;
        Console.Clear();
        escolherTamanho();
        Console.WriteLine($"Nro de Linhas informada:{tamanhoMatriz} e Nro de Colunas informada: {tamanhoMatriz}");
        Console.WriteLine("Escolha a opção desejada:\n1 - Adição:\n2 - Subtração:\n3 - Multiplicação:\n4 - Divisão:\n5 - Para voltar ao Inicio.");
        opcao = int.Parse(Console.ReadLine());
        if (opcao == 5)
        {
            Console.Clear();
            opcao = 0;
            Menu();
        }
        else
        {
            realizaOperacao(opcao);
        }
    }
}
void criarMatriz(float[,] entradaMatriz)
{
    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
            entradaMatriz[linha, coluna] = new Random().Next(1, 20);
        }
    }
}
Menu();*/


