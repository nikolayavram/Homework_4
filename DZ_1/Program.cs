﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
inDegree(numberA, numberB);


void inDegree(int a, int b)
{
    int result = 1;

    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

int ReadInt(string argument)
{
    Console.WriteLine(argument);
    return Convert.ToInt32(Console.ReadLine());
}
