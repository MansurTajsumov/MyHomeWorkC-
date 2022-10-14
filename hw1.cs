
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*
Console.WriteLine("Определим какое из двух чисел больше.");
Console.WriteLine("Введите первое число");
int firstnum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secnum = Convert.ToInt32(Console.ReadLine());

if (firstnum>secnum)
{
    Console.WriteLine($"Число {firstnum} больше {secnum}");
}
if (firstnum<secnum)
    {
        Console.WriteLine($"Число {secnum} больше {firstnum}");  
    }
    
else
{
    Console.WriteLine("Числа равны");
}
*/



//Задача 4: Напишите программу,
//которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*
Console.WriteLine("Введите три числа:");
int firstnum = Convert.ToInt32(Console.ReadLine());
int secnum = Convert.ToInt32(Console.ReadLine());
int threenum = Convert.ToInt32(Console.ReadLine());
int max = firstnum;
if (secnum > firstnum)
    max = secnum;
if (threenum > max)
    max = threenum;
Console.WriteLine($"Максимальное число: {max}");
*/


//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Проверка четности числа");
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
*/

//Задача 8: Напишите программу, 
//которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 0;
while (current<num-1)
{
    current += 2;
    Console.Write(current + " ");
}
*/



