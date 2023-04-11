/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

Console.Clear();
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
Console.WriteLine($"Разница между макс и мин значением равна {DiffNumbers(numbers)}"); 