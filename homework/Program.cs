// Задача 54:
// Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] myArray = GetArray(3, 4);
Console.WriteLine("Массив ДО сортировки по убыванию:");
PrintArray(myArray);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Массив ПОСЛЕ сортировки по убыванию:");
SortOrder(myArray);
PrintArray(myArray);
Console.WriteLine("----------------------------------------");
Console.Write("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//------------------------------------------------------------------------------------

// Задача 56:
// Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] myArray2 = GetArray(4, 4);
Console.WriteLine("Ваш массив: ");
PrintArray(myArray2);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Сумма элементов строк вашего массива: ");
FindStringSum(myArray2);
Console.WriteLine("----------------------------------------");
FindMinStringSum(myArray2);
Console.WriteLine("----------------------------------------");
Console.Write("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//------------------------------------------------------------------------------------

// Задача 58:
// Задайте две матрицы. Напишите программу,
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] myArray3 = GetArray(2, 2);
int[,] myArray4 = GetArray(2, 2);
Console.WriteLine("Первая матрица: ");
Console.WriteLine();
PrintArray(myArray3);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Вторая матрица: ");
Console.WriteLine();
PrintArray(myArray4);
Console.WriteLine("----------------------------------------");
Console.WriteLine("Матрица с результатами произведения: ");
Console.WriteLine();
int[,] myArray5 = ProductOfTwoMatrices(myArray3, myArray4);
PrintArray(myArray5);
Console.WriteLine("----------------------------------------");
Console.Write("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//=======================================МЕТОДЫ=======================================

// СОЗДАЕТ ДВУМЕРНЫЙ МАССИВ                                                           (В задаче ==> 1, 2, 3)
int[,] GetArray(int n, int m){
    int[,] array = new int[n, m];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}
//------------------------------------------------------------------------------------

// ПЕЧАТАЕТ ДВУМЕРНЫЙ МАССИВ                                                          (В задаче ==> 1, 2, 3)
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
//------------------------------------------------------------------------------------

// СОРТИРУЕТ ЧИСЛА В СТРОКАХ МАССИВА ПО УБЫВАНИЮ                                      (В задаче ==> 1)
void SortOrder(int[,] array){
    int min;
    int boofer;
    int minIndex;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            min = array[i, 0];
            minIndex = 0;
            for(int g = 0; g < array.GetLength(1) - j; g++){
                if(array[i, g] < min){
                    min = array[i, g];
                    minIndex = g;
                }
            }
            boofer = array[i, array.GetLength(1) - 1 - j];
            array[i, array.GetLength(1) - 1 - j] = array[i, minIndex];
            array[i, minIndex] = boofer;
        }
    }
}
//------------------------------------------------------------------------------------

// МЕТОД КОТОРЫЙ ПРОСТО КРАСИВО ВЫВОДИТ СУММУ СТРОКИ                                  (В задаче ==> 2)  
//МАССИВА РЯДОМ С САМОЙ СТРОКОЙ
//ПРОСТО НАПИСАЛ ТАКОЙ ДЛЯ КРАСОТЫ)
//(МЕТОД НЕОБЯЗАТЕЛЬНЫЙ)
void FindStringSum(int[,] array){                                                                                                  
    int[] summString = new int[array.GetLength(0)];
    int sum;
    for(int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){
            sum += array[i, j];
        }
        summString[i] = sum;
    } 
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine($"==> {summString[i]}");
    }
}
//------------------------------------------------------------------------------------

// НАХОДИТ ИНДЕКС СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ                                (В задаче ==> 2)
//РЕАЛИЗОВАЛ ПРИ ПОМОЩИ VOID, ТАК КАК
//СТРОК С МИНИМАЛЬНОЙ СУММОЙ МОЖЕТ БЫТЬ И 2 И 3
//ЭТОТ МЕТОД ПОКАЖЕТ ОБА ИНДЕКСА СТРОК
//МОЖНО БЫЛО СДЕЛАТЬ ЧЕРЕЗ МАССИВ,
//НО Я РЕШИЛ ЧЕРЕЗ STRING (поработать с конвертацией). 
void FindMinStringSum(int[,] array){
    int[] summString = new int[array.GetLength(0)];
    int sum;
    for(int i = 0; i < array.GetLength(0); i++){
        sum = 0;
        for(int j = 0; j < array.GetLength(1); j++){ 
            sum += array[i, j];
        }
        summString[i] = sum;
    } 
    int minSum = summString[0];
    for(int i = 0; i < array.GetLength(1); i++){
        if(summString[i] < minSum){
            minSum = summString[i];
        } 
    }  
    Console.Write($"Номер строк(и) с наименьшей суммой элементов ==> ");
    for(int i = 0; i < array.GetLength(1); i++){
        if(summString[i] == minSum){
           Console.Write($"{i + 1}  "); 
        }
    } 
    Console.WriteLine();
}
//------------------------------------------------------------------------------------

// МЕТОД КОТОРЫЙ ПРОСТО 'ЧУДОМ' НАХОДИТ ПРОИЗВЕДЕНИЯ                                  (В задаче ==> 3)
//ДВУХ МАТРИЦ ТАК, КАК БЫЛО ЗАЯВЛЕННО НА СЕМИНАРЕ!
//В ПОДРОБНОСТИ КОДА НЕ ВДАВАЙТЕСЬ, ВСЕ РАВНО НИЧЕГО НЕ ПОЙМЕТЕ))) ХЕ-ХЕ
int[,] ProductOfTwoMatrices(int[,] array1, int[,] array2){
    int[,] resultArray = new int[array1.GetLength(0), array1.GetLength(1)];
    int matrixMulti = 0;   // тут сумма произведений
    int count = 0;         // число иттераций 
    int rows = 0;          // нужно для махинаций с индексами
    int column = 0;        // тоже самое (для махинаций)
    int supportive = 0;    // для корректной работы после 3й итерации
    int supportive2 = 0;   // для корректной работы после 2й итерации
    bool flag = false;     // для корректной работы с индексами после 2й итерации
    while(count < array1.GetLength(0) + array1.GetLength(1)){
        for(int i = 0; i < array1.GetLength(0); i++){
            for(int j = 0; j < array1.GetLength(0); j++){
                matrixMulti += array1[rows - (i - supportive), column + j] * array2[column + j, rows - (supportive2 - supportive)];
            }
            count++;
            resultArray[rows - (i - supportive), column + i] = matrixMulti;
            matrixMulti = 0;
            if(!flag){
                rows++;
                flag = true;
            }
            if(count == (array1.GetLength(0) + array1.GetLength(1)) - 1){
                supportive++;
            }
        }
        supportive2++;
    }
    return resultArray;
}
//------------------------------------------------------------------------------------