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

Console.WriteLine("Задача №54:");
Console.WriteLine("Напишите программу,");
Console.WriteLine("которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();
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

Console.WriteLine("Задача №56:");
Console.WriteLine("Напишите программу,");
Console.WriteLine("которая будет находить строку с наименьшей суммой элементов.");
Console.WriteLine();
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

Console.WriteLine("Задача №58:");
Console.WriteLine("Напишите программу,");
Console.WriteLine("которая будет находить произведение двух матриц.");
Console.WriteLine();
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
//------------------------------------------------------------------------------------

// Задача 60:
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("Задача №60:");
Console.WriteLine("Напишите программу, которая будет построчно выводить массив,");
Console.WriteLine("добавляя индексы каждого элемента.");
Console.WriteLine();
Console.WriteLine("Многомерный массив с индексами элементов: ");
Console.WriteLine("Значения элементов массива не повторяются!! ");
Console.WriteLine();
int[,,] myArray6 = GetXYZArray(2, 2, 2);
PrintXYZArray(myArray6);
Console.WriteLine("----------------------------------------");
Console.Write("Для продолжения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//------------------------------------------------------------------------------------

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.WriteLine("Задача №62:");
Console.WriteLine("Напишите программу,");
Console.WriteLine("которая заполнит спирально массив 4 на 4.");
Console.WriteLine();
Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов массива: ");
int column = int.Parse(Console.ReadLine()!);
Console.Clear();
int [,] myArray7 = new int[rows, column];
Console.WriteLine("Пустой массив: ");
Console.WriteLine();
PrintArray(myArray7);
Console.WriteLine("----------------------------------------");
Console.WriteLine("После заполнения числами змейкой: ");
Console.WriteLine();
SnakeArray(myArray7);
PrintArray(myArray7);
Console.WriteLine("----------------------------------------");
Console.Write("Для завершения нажмите 'Enter': ");
Console.ReadLine();
Console.Clear();
//------------------------------------------------------------------------------------
//====================================================================================
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

// ПЕЧАТАЕТ ДВУМЕРНЫЙ МАССИВ                                                          (В задаче ==> 1, 2, 3, 5)
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

// СОЗДАЕТ ТРЕХМЕРНЫЙ(МНОГОМЕРНЫЙ) МАССИВ БЕЗ ПОВТОРЯЮЩИХСЯ                           (В задаче ==> 4)
// ЗНАЧЕНИЙ, ЕСЛИ ЗАДАТЬ МАССИВУ КОЛЛИЧЕСТВО ЭЛЕМЕНТОВ
// БОЛЬШЕ 99, ТО ЦИКЛ БУДЕТ РАБОТАТЬ БЕСКОНЕЧНО, ТАК КАК
// БУДЕТ ПОСТОЯННО ИСКАТЬ ЧИСЛО КОТОРОЕ НЕ ПОВТОРЯЕТСЯ!
int[,,] GetXYZArray(int x, int y, int z){
    int[,,] array = new int[x, y, z];
    string numbers = "";
    int count = 0;
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                array[i, j, k] = new Random().Next(1, 100);
                string foundNumber = Convert.ToString(array[i, j, k]);
                if(count > 0){
                bool flag = true;
                while(flag){  // тут начинается проверка на индивидуальность только что созданного числа
                    if(numbers.Contains(foundNumber)){// если такое число уже есть, то оно перезапишется
                        array[i, j, k] = new Random().Next(1, 100);
                        foundNumber = Convert.ToString(array[i, j, k]);
                    }
                    else{ // если число не повторяется, то мы выйдем из цикла перезаписи числа
                        flag = false;
                    }
                } 
                }
                numbers += (Convert.ToString(array[i, j, k]) + ","); // а тут хранятся все числа массива
                count++;
            }
        }
    }
    return array;
}
//------------------------------------------------------------------------------------

//ПЕЧАТАЕТ ТРЕХМЕРНЫЙ(МНОГОМЕРНЫЙ) МАССИВ НА ЭКРАН                                    (В задаче ==> 4)
void PrintXYZArray(int[,,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            for(int k = 0; k < array.GetLength(2); k++){
                Console.Write($"{array[i, j, k]}_({i},{j},{k}); ");
            }
            Console.WriteLine();
        }
    }
}
//------------------------------------------------------------------------------------

//МЕТОД КОТОРЫЙ ЗАПИСЫВАЕТ ЗНАЧЕНИЯ, ОТ 1 ДО N, В МАССИВ ЗМЕЙКОЙ                      (В задаче ==> 5)
//МЕТОД УНИВЕРСАЛЕН
//РАБОТАЕТ С ЛЮБЫМ КОЛИЧЕСТВОМ СТРОК И СТОЛБЦОВ
void SnakeArray(int[,] array){
    int rows = 0;
    int column = 0;
    int rowsCount = array.GetLength(0);
    int columnCount = array.GetLength(1);
    bool right = true;
    bool down = false;
    bool left = false;
    bool up = false;
    int value = 1;
    int count = 0;
    array[rows, column] = value;
    for(int i = 0; i < (array.GetLength(0) * array.GetLength(1)); i++){
        if(right){
            while(count < columnCount){
                array[rows, column] = value;
                value++;
                column++;
                count++;
            }
            down = true;
            right = false;
            column--;
            rowsCount--;
            rows++; 
            count = 0;
        }
        if(down){
            while(count < rowsCount){
                array[rows, column] = value;
                value++;
                rows++;
                count++;
            }
            left = true;
            down = false;
            rows--;
            column--;
            columnCount--;  
            count = 0;
        }
        if(left){
             while(count < columnCount){
                array[rows, column] = value;
                value++;
                column--;
                count++;
            }
            up = true;
            left = false;  
            column++;   
            rows--;   
            rowsCount--;   
            count = 0;
        }
        if(up){
            while(count < rowsCount){
                array[rows, column] = value;
                value++;
                rows--;
                count++;
            }
            right = true;
            up = false;
            rows++;
            column++;
            columnCount--;
            count = 0;
        }
    }
}