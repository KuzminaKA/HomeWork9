﻿//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int Akkerman(int n, int m)
{
    if (n==0)
    return m+1;
    else
    if((n!=0) && ( m==0))
    return Akkerman(n-1,1);
    else
    return Akkerman(n-1, Akkerman(n,m-1));
}

int n=3;
int m=2;
System.Console.WriteLine(Akkerman(n,m));