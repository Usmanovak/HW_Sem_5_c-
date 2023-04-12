/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();
int[] startArray = GetRandomArray (10, -10, 10);
Console.WriteLine(String.Join(" ", startArray));
int sum = 0;
SumOdd (startArray);
Console.WriteLine($"Сумма нечетных элементов массива равна {SumOdd(startArray)}");

int [] GetRandomArray (int size, int minValue, int maxValue) {
    int [] res = new int [size];
    for (int i = 0; i < size; i++) {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
    }

int SumOdd (int[] startArray) {
    int result = sum;
    for (int i = 0; i < startArray.Length + 1; i++) {
        if (i % 2 == 1) {
            sum += startArray[i];
        }
    }
    return result;
}

/*int [] sum = GetSumElements(array);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях равна {sum [i]}");
int [] GetArray (int size, int minValue, int maxValue) 
int GetSumElements(int [] array) {
    int sum = 0;
    for (int i = 0; i % 2 !=0; i++) {
        sum += array[i];
        }
        return sum;
    }


/*Console.Clear();
int [] numbers = {3, 7, 22, 2, 78};
Console.WriteLine(String.Join (" ", numbers));

int minNumber = numbers[0];
int maxNumber = numbers[0];

MinNumber (numbers);
int MinNumber (int []numbers) {
    int res = minNumber;
    for (int i = 0; i < numbers.Length; i++) {
        if (numbers[i] < minNumber) {
            minNumber = numbers[i];
        }
    }
    return res;
}

MaxNumber (numbers);
int MaxNumber (int []numbers) {
    int re = maxNumber;
    for (int i = 0; i < numbers.Length; i++) {
        if (numbers[i] > maxNumber) {
            maxNumber = numbers[i];
        }
    }
    return re;
}


DiffNumbers (numbers);
int DiffNumbers (int[] numbers) {
    int result = maxNumber - minNumber;
    for (int i = 0; i < numbers.Length; i++) {
    }
    return result;
}
Console.WriteLine($"Разница между макс и мин значением равна {DiffNumbers(numbers)}"); */