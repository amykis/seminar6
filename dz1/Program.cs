﻿// Задача 1: Задайте двумерный массив символов (тип char
// [,]). Создать строку из символов этого массива.

Console.Clear();

char [,] ch = { 
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};
string str = "";
for (int i =0; i < ch.GetLength(0); i++){
    for (int j = 0; j < ch.GetLength(1); j++){
        str += ch[i, j];
    }
}

Console.Write(str);
Console.WriteLine();