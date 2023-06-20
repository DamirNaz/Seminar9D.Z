// Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("введите число:");
// int num=Convert.ToInt32(Console.ReadLine());
// int finishNum=1;
// Console.WriteLine(PrintNumbers(num,finishNum));
// string PrintNumbers(int num1, int num2)
// {
//     if(num1==num2)
//     {
//         return num1.ToString();
//     }
//     return (num1+" "+ PrintNumbers(num1-1,num2));
// }

//_____________________________________________________________________________

//  Задайте значения M и N. Напишите программу, которая найдёт 
//  сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.WriteLine("введите меньшее число:");
// int num1=Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("введите большее число:");
// int num2=Convert.ToInt32(Console.ReadLine());

// int PrintNumbers(int number1,int number2)
// {
//     if(number1==number2)
//     {
//         return number1;
//     }
//     return number1+PrintNumbers(number1+1,number2);
// }
// Console.WriteLine(PrintNumbers(num1,num2));

//____________________________________________________________________________

// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

AkkermanFunction(m,n);


// вызов функции Аккермана
void AkkermanFunction(int m, int n)
{
    Console.Write(Akkerman(m, n)); 
}

// функция Аккермана
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
