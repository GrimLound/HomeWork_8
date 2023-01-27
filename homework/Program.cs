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

//=======================================МЕТОДЫ=======================================

int[,] GetArray(int n, int m){//------------------------------СОЗДАЕТ ДВУМЕРНЫЙ МАССИВ
    int[,] array = new int[n, m];
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return array;
}


void PrintArray(int[,] array){//-----------------------------ПЕЧАТАЕТ ДВУМЕРНЫЙ МАССИВ
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


void SortOrder(int[,] array){//----------СОРТИРУЕТ ЧИСЛА В СТРОКАХ МАССИВА ПО УБЫВАНИЮ
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