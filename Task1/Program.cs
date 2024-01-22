/* Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная. */
using System;
class Program
{ 
    static bool IsEvenSum(int num)
    {
        int sum = 0;
        foreach (char c in num.ToString())
        {

            sum += int.Parse(c.ToString());

        }
        return sum % 2 == 0;

    }
    static void Main(string[] args)

    {
        string input;
        while (true)
        {

            Console.Write("Введите целое число или 'q' для завершения программы: ");
            input = Console.ReadLine();
            if (input == "q")

            {
                break;
            }

            if (int.TryParse(input, out int num))

            {
                if (IsEvenSum(num))

                {
                    break;
                }
            }
            else
            {
              Console.WriteLine("Введено некорректное значение, попробуйте снова");
            }
        }
        Console.WriteLine("Программа завершена");

    }

}