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

//=======================================МЕТОДЫ=======================================

int[,] GetArray(int n, int m){//------------------------------СОЗДАЕТ ДВУМЕРНЫЙ МАССИВ  (В задаче ==> 1, 2)
    int[,] array = new int[n, m];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array){//-----------------------------ПЕЧАТАЕТ ДВУМЕРНЫЙ МАССИВ  (В задаче ==> 1, 2)
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void SortOrder(int[,] array){//----------СОРТИРУЕТ ЧИСЛА В СТРОКАХ МАССИВА ПО УБЫВАНИЮ  (В задаче ==> 1)
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


void FindStringSum(int[,] array){//--МЕТОД КОТОРЫЙ ПРОСТО КРАСИВО ВЫВОДИТ СУММУ СТРОКИ  (В задаче ==> 2)                                                  
    int minSumIndex;                                //МАССИВА РЯДОМ С САМОЙ СТРОКОЙ                                                   
    int[] summString = new int[array.GetLength(0)]; //ПРОСТО НАПИСАЛ ТАКОЙ ДЛЯ КРАСОТЫ)
    int sum;                                        //(МЕТОД НЕОБЯЗАТЕЛЬНЫЙ)
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


void FindMinStringSum(int[,] array){//НАХОДИТ ИНДЕКС СТРОКИ С НАИМЕНЬШЕЙ СУММОЙ ЭЛЕМЕНТОВ (В задаче ==> 2)
    int[] summString = new int[array.GetLength(0)];//РЕАЛИЗОВАЛ ПРИ ПОМОЩИ VOID, ТАК КАК
    int sum;                                       //СТРОК С МИНИМАЛЬНОЙ СУММОЙ МОЖЕТ БЫТЬ И 2 И 3
    for(int i = 0; i < array.GetLength(0); i++){   //ЭТОТ МЕТОД ПОКАЖЕТ ОБА ИНДЕКСА СТРОК
        sum = 0;                                   //МОЖНО БЫЛО СДЕЛАТЬ ЧЕРЕЗ МАССИВ,
        for(int j = 0; j < array.GetLength(1); j++){//НО Я РЕШИЛ ЧЕРЕЗ STRING    
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