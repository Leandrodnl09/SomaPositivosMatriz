// Exerício do curso do Nélio Alves "Soma Positivos Matriz"
// 6) Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
// a) calcular e imprimir a soma de todos os elementos positivos da matriz.
// b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
// c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
// d) imprimir os elementos da diagonal principal da matriz.
// e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.
// Entrada:
// A entrada contém o número inteiro N, seguido dos valores da matriz com uma casa decimal cada, seguido do índice de
// uma linha, seguido do índice de uma coluna, conforma exemplo.
// Saída:
// A saída contém os valores de saída de cada ação, com uma casa decimal, na ordem em que foram apresentadas no
// enunciado, conforme exemplo.


int N = int.Parse(Console.ReadLine());

double[,] Mat = new double[N, N];

for (int i = 0; i < N; i++)
{
    string[] X = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        Mat[i, j] = double.Parse(X[j]);
    }
}
int linha = int.Parse(Console.ReadLine());
int coluna = int.Parse(Console.ReadLine());
double Soma = 0.0;

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (Mat[i, j] > 0.0)
        {
            Soma = Soma + Mat[i, j];
        }
    }
}
Console.WriteLine("SOMA DOS POSITIVOS: " + Soma.ToString("F1"));
Console.Write("LINHA ESCOLHIDA: ");
for (int j = 0; j < N; j++)
{
    Console.Write(Mat[linha, j].ToString("F1") + " ");
}
Console.WriteLine();
Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < N; i++)
{
    Console.Write(Mat[i, coluna].ToString("F1") + " ");
}
Console.WriteLine();
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < N; i++)
{
    Console.Write(Mat[i, i].ToString("F1") + " ");
}
Console.WriteLine();

for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        if (Mat[i, j] < 0.0)
        {
            Mat[i, j] = Mat[i, j] * Mat[i, j];
        }
    }
}
Console.WriteLine("MATRIZ ALTERADA:");
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        Console.Write(Mat[i, j].ToString("F1") + " ");
    }
    Console.WriteLine();
}