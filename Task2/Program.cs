﻿/* Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. */
 void PrintData(string res)
 {
     Console.WriteLine(res);
 }

 int[] Gen1DArray(int len, int minValue, int maxValue)
 {
     int[] arr = new int[len];
     for (int i = 0; i < arr.Length; i++)
     {
         arr[i] = new Random().Next(minValue, maxValue + 1);
     }
     return arr;
 }
 

void Print1DArr(int[] arr)
{
     Console.Write("[");
     for (int i = 0; i < arr.Length - 1; i++)
     {
         Console.Write(arr[i] + ", ");
     }
     Console.WriteLine(arr[arr.Length - 1] + "]");
 }


 int CountElem(int[] arr)
 {
     int res = 0;
     for (int i = 0; i < arr.Length; i++)
     {
         if (Test(arr[i]))
         {
             res++;
         }
     }
     return res;
 }

 bool Test(int n)
 {
     return (n % 2 == 0);
 }



int[] testArr = Gen1DArray(10,100,999);

Print1DArr(testArr);

int count = CountElem(testArr);

PrintData("Количество четных элементов равно: "+count);
