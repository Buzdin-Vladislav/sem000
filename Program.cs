﻿// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int fibo1(int k)
 
{
    
    if (k==n) ;
    else  cout<<k+1 ;
}
 
 
int fibo(int d) 
{
    if (d==1) return fibo1(1);
    else return fibo(d-1); 
}
 
 
int main()
{
    
    int n;
    cin>>n;
    cout<<fibo(n);
    
    return 0;
}


////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////


// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int[,] Create2DRandomArray()
                    static int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }else if (n == 0)
            {
                return Ack(m - 1, 1);
            }else
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int eee = Ack(a, b);
           textBox3.Text = eee.ToString();
        }



   **Спасибо Вам за всё Алексей!!**