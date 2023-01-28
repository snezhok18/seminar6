// Задача 41: 
// Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел строго больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4
// Для строки можно использовать данный 
// метод string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries)
// (пользователь вводит в консоли числа через пробел и они формируют строку)

// Console.WriteLine("Введите числа через пробел:");
// int[] numbers = ArrayString(Console.ReadLine()!);
// Console.WriteLine($"Количество чисел больше НУЛЯ -> {PositivNumbers(numbers)}");

// -----Method 1-----

// int[] ArrayString(string stringArr)
// {
// string[] nums = stringArr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// int[] result = new int[nums.Length];
// for (int i = 0; i < result.Length; i++)
// {
//     result[i] = int.Parse(nums[i]);
// }
// return result;
// }

// // -----Method 2-----

// int PositivNumbers(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }


// Задача 43:
// Написать программу, которая на вход принимает массив из любого 
// количества элементов (не менее 6)в промежутке от 0 до 100, 
// а на выходе выводит этот же массив, но отсортированный по 
// возрастанию(от меньшего числа к большему).

int size = new Random().Next(6, 15);
Console.WriteLine($"В массиве будет {size} элементов");
int[] array = OurArray(size);
Console.WriteLine($"[{String.Join(", ", array)}]");
SortArray(array);
Console.WriteLine($"[{String.Join(", ", array)}]");


// --- Метод формирования массива случайных чисел ---
int[] OurArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(101);
    }
    return arr;
}
// ---


// --- Метод сортировки массива в порядке возрастания ---

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[i] > array[j])
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
    }
}

// ---