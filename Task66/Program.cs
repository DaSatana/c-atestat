
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



Console.Write("Введите значение M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = SumNaturalNumbers(M, N);

Console.WriteLine("Сумма натуральных элементов в промежутке от {0} до {1}: {2}", M, N, sum);
Console.ReadLine();


int SumNaturalNumbers(int start, int end)
{
    if (start > end)
        return 0;

    return start + SumNaturalNumbers(start + 1, end);
}
