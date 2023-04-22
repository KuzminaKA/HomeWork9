// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int M = 1;
int N = 5;



int Sum(int M, int N)
{
    // int sum = M + N;

    // if (N > M)
    // {
    //     sum = sum + Sum(M + 1, N - 1);
    // }

    // return sum;
    if(M==N) return N;
    else
    return N+Sum(M,N-1);
}
System.Console.WriteLine(Sum(M, N));
