//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число 1: ");
string strNum1=Console.ReadLine();

Console.WriteLine("Введите число 2: ");
string strNum2=Console.ReadLine();

int num1=int.Parse(strNum1);
int num2=int.Parse(strNum2);

if(num1>num2)
{
    Console.WriteLine($"Число {num1} больше числа {num2}");
}
else if (num2>num1)
{
    Console.WriteLine($"Число {num2} больше числа {num1}");
}
else
{
    Console.WriteLine($"Число {num1} равно числу {num2}");
}