// Ex1. Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Clear();
int[] startArray = GetArray (4, 100, 1000);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Количество четных чисел в массиве равно {GetCountElements(startArray, 100, 1000)}");
int [] GetArray (int size, int minValue, int maxValue) {
    int [] res = new int [size];
    for (int i = 0; i < size; i++) {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
    }
    int GetCountElements(int [] array, int minValue, int maxValue) {
        int count = 0;
        foreach (int item in array)
        {
            if (item % 2 == 0)
            count++;
        }
        return count;
    }
