// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите первое натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

if(numberM<1 || numberN<1)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

SumFromMToN(numberM, numberN);

void SumFromMToN(int numberM, int numberN)
{
    Console.Write(SumMN(numberM - 1, numberN));
}

int SumMN(int numberM, int numberN)
{
    int res = numberM;
    if (numberM == numberN)
        return 0;
    else
    {
        numberM++;
        res = numberM + SumMN(numberM, numberN);
        return res;
    }
}


