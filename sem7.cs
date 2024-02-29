/* Задача 1: Задайте значения M и N. 
 M = 1; N = 15 -> 120
 M = 4; N = 8. -> 30
 */
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());
    
Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

SumFromMToN(m, n);

void SumFromMToN(int m, int n)
{
  Console.Write(SumMN(m - 1, n));
}
int SumMN(int m, int n)
{
  int res = m;
  if (m == n)
      return 0;
  else
  {
    m++;
    res = m + SumMN(m, n);
    return res;
  }
}

/*
 Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
 m = 2, n = 3 -> A(m,n) = 9
 m = 3, n = 2 -> A(m,n) = 29
 */
 
Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);

void AkkermanFunction(int m, int n)
{
  Console.Write(Akkerman(m, n)); 
}

int Akkerman(int m, int n)
{
  if (m == 0)
  {
    return n + 1;
  }
  else if (n == 0 && m > 0)
  {
    return Akkerman(m - 1, 1);
  }
  else
  {
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
  }
}

/*
Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
 */
using System;   
namespace task3
{  
  public static class Program  
  { 
    public static void print(int [] A, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(A[n] + " "); 
      	print(A, n - 1); 
      } 
      else Console.WriteLine(A[0]); 
    } 
    public static void Main()   
    { 
      int [] num = {1, 2, 5, 0, 10, 34}; 
      print(num, num.Length - 1); 
    }  
  }   
}