// **Задача 66**: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120  
// M = 4; N = 8. -> 30

int ResultSummRecurent(int M, int N, int result)
{
    if (N == M) return result;
    else
    {
        result += N;
        return ResultSummRecurent(M, N - 1, result);
    }
}


Console.Clear();
int M = 1;
int N = 15;
int result = M;
System.Console.WriteLine(ResultSummRecurent(M, N, result));