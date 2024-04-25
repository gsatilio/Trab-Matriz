int tamanhoMatriz = 0, opcao = 0, random1 = 0, random2 = 0;
string titulo = "";
float[,] matriz1 = new float[tamanhoMatriz, tamanhoMatriz];
float[,] matriz2 = new float[tamanhoMatriz, tamanhoMatriz];
float[,] matriz3 = new float[tamanhoMatriz, tamanhoMatriz];

void escolherTamanho()
{
    Console.WriteLine("Bem vindo ao Matriz Quadrada Simulator!");
    while (tamanhoMatriz <= 0)
    {
        Console.WriteLine("Informe o nro de Linhas/Colunas de sua Matriz:");
        tamanhoMatriz = int.Parse(Console.ReadLine());
    }
}
void sorteioMatriz()
{
    Console.WriteLine("Informe o primeiro numero entre os aleatorios:");
    random1 = int.Parse(Console.ReadLine());
    while (random2 < random1)
    {
        Console.WriteLine("Informe o segundo numero entre os aleatorios:");
        random2 = int.Parse(Console.ReadLine());
    }
}

void imprimirMatriz(float[,] entradaMatriz, string titulo)
{
    Console.Write(titulo);
    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
        Console.WriteLine();
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
            Console.Write(entradaMatriz[linha, coluna] + " ");
        }
    }
    Console.WriteLine();
}

void popularMatriz(float[,] entradaMatriz)
{
    for (int linha = 0; linha < tamanhoMatriz; linha++)
    {
        for (int coluna = 0; coluna < tamanhoMatriz; coluna++)
        {
            entradaMatriz[linha, coluna] = new Random().Next(random1, random2);
        }
    }
}
void realizaOperacao(int tipo)
{
    int calcMat = 0, nroMatriz = 0, calcMatReturn = 1;

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
    popularMatriz(matriz3);
    imprimirMatriz(matriz3, "\n**********Matriz 3 Gerada**********");

    while (calcMatReturn != 0)
    {
        nroMatriz = 0;
        calcMatReturn = 0;
        calcMat = 0;
        while (nroMatriz <= 0 || nroMatriz > 3)
        {
            Console.WriteLine("Escolha:\n1 - Matriz 1\n2 - Matriz 2\n3 - Matriz 3");
            nroMatriz = int.Parse(Console.ReadLine());
        }
        while (calcMat <= 0 || calcMat > 3)
        {
            Console.WriteLine("Escolha:\n1 - Somar Linha\n2 - Somar Coluna\n3 - Somar Diagonais");
            calcMat = int.Parse(Console.ReadLine());
        }
        switch (nroMatriz)
        {
            case 1:
                imprimirMatriz(matriz1, $"{titulo} para Matriz {nroMatriz}:");
                calcMatReturn = CalcularDirecoesMatriz(calcMat, matriz1);
                break;
            case 2:
                imprimirMatriz(matriz2, $"{titulo} para Matriz {nroMatriz}:");
                calcMatReturn = CalcularDirecoesMatriz(calcMat, matriz2);
                break;
            case 3:
                imprimirMatriz(matriz3, $"{titulo} para Matriz {nroMatriz}:");
                calcMatReturn = CalcularDirecoesMatriz(calcMat, matriz3);
                break;
        }
    }
}


int CalcularDirecoesMatriz(int tipo, float[,] matrizEntrada)
{
    float resultado = 0;
    float diag1 = 0;
    float diag2 = 0;
    int opcao = 0;
    switch (tipo)
    {
        case 1: // Somar Linha
            Console.WriteLine($"\nOperação de SOMA LINHAS na Matriz{tipo}:");
            for (int linha = 0; linha < tamanhoMatriz; linha++)
            {
                int col = 0;
                while (col < tamanhoMatriz)
                {
                    resultado += matrizEntrada[linha, col];
                    col++;
                }
                Console.WriteLine($"Linha: {linha} resulta em: {resultado}");
                resultado = 0;
            }
            break;
        case 2: // Somar Coluna
            Console.WriteLine($"\nOperação de SOMA COLUNAS na Matriz{tipo}:");
            for (int col = 0; col < tamanhoMatriz; col++)
            {
                int lin = 0;
                while (lin < tamanhoMatriz)
                {
                    resultado += matrizEntrada[lin, col];
                    lin++;
                }
                Console.WriteLine($"Coluna: {col} resulta em: {resultado}");
                resultado = 0;
            }
            break;
        case 3: // Somar Diagonal
            int coldiag2 = tamanhoMatriz - 1;
            Console.WriteLine($"\nOperação de SOMA  DIAGONAIS na Matriz{tipo}:");
            for (int linha = 0; linha < tamanhoMatriz; linha++)
            {
                for (int col = 0; col < tamanhoMatriz; col++)
                {
                    // diagonal esquerda para direita
                    if (linha == col)
                    {
                        diag1 += matrizEntrada[linha, col];
                    }
                    //diagonal direita para esquerda
                    if (col == coldiag2)
                    {
                        diag2 += matrizEntrada[linha, coldiag2];
                        coldiag2--;
                    }
                }
            }
            Console.WriteLine($"Diagonal Esquerda -> Direita: {diag1}\nDiagonal Direita <- Esquerda: {diag2}");
            break;
    }
    Console.WriteLine("Deseja escolher outra operação?\n1 - Sim\n0 - Não");
    opcao = int.Parse(Console.ReadLine());
    return opcao;
}
void Menu()
{
    while (opcao <= 0 || opcao > 5)
    {
        tamanhoMatriz = 0;
        Console.Clear();
        escolherTamanho();
        sorteioMatriz();
        Console.WriteLine($"Nro de Linhas informada:{tamanhoMatriz} e Nro de Colunas informada: {tamanhoMatriz}");
        Console.WriteLine("Escolha a opção desejada:\n1 - Adição:\n2 - Subtração:\n3 - Multiplicação:\n4 - Divisão:\n5 - Para voltar ao Inicio.");
        opcao = int.Parse(Console.ReadLine());
        if (opcao == 5)
        {
            random1 = 0;
            random2 = 0;
            opcao = 0;
            Console.Clear();
            Menu();
        }
        else
        {
            matriz1 = new float[tamanhoMatriz, tamanhoMatriz];
            matriz2 = new float[tamanhoMatriz, tamanhoMatriz];
            matriz3 = new float[tamanhoMatriz, tamanhoMatriz];
            popularMatriz(matriz1);
            imprimirMatriz(matriz1, "\n**********Matriz 1 Gerada**********");
            popularMatriz(matriz2);
            imprimirMatriz(matriz2, "\n**********Matriz 2 Gerada**********");
            realizaOperacao(opcao);
        }
    }
}
Menu();