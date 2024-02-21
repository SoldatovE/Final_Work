/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

using System;

class Program
{static void Main(string[] args)
    {
        Console.WriteLine("Введите строки через запятую:");
        string input = Console.ReadLine();
        string[] inputStrings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        
        string[] result = FilterShortStrings(inputStrings);

        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    }
    
}
