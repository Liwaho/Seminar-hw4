/*ВСЕ ЗАДАЧИ РЕШАЕМ ЧЕРЕЗ МЕТОДЫ

Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int St(int an, int bn)
{
   int result = 1;
  for(int i=1; i <= bn; i++){
    result = result * an;
  }
    return result;
}
    Console.WriteLine("Input first number: ");
    int an = int.Parse(Console.ReadLine());
    Console.WriteLine("Input second number: ");
    int bn = int.Parse(Console.ReadLine());    
    Console.WriteLine("Result:" + St(an,bn));


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

/*Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/
