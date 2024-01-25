// string str = "hello";
// char [] ch = str.ToCharArray();

// ch[1] = 'E';
// str = new string(ch);

// string str1 = (str.ToCharArray()[1] = 'E').ToString();

// Console.WriteLine(str);

// char [] ch = new char [str.Length];

// for (int i = 0; i < )

// char ch = 'V';
// string str = "ghjf";

// char [] ch = {'a', 'b', 'c', 'd'};
// string str1 = new string(ch);

// string str3 = new string('1', 10);

// Console.WriteLine(str);
// Console.WriteLine(str1);
// Console.WriteLine(str3);




// Задача №1: Задайте массив символов (тип char []). Создайте строку из символов этого массива.

// Указание
// Конструктор строки вида string(char[]) не использовать.

// Пример
// [‘a’, ‘b’, ‘c’, ‘d’] => “abcd”

Console.Clear();
char [] ch = {'a', 'b', 'c', 'd'};
string str = "";
foreach (char e in ch){
    str += e;
}

Console.Write(str);
Console.WriteLine();


// Задача №2: На основе символов строки (тип string) сформировать массив символов (тип char[]).
// Вывести массив на экран.

// Пример
// “Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’]

string str1 = "Hello!";
char [] ch1 = new char [str1.Length];
for (int i = 0; i < str1.Length; i++){
    ch1[i] = str1[i];
}
foreach (char e in ch1){
    Console.Write(e+" ");
}

// Считать строку с консоли, состоящую из латинских букв в нижнем регистре.
// Выяснить, сколько среди введённых букв гласных.

// Пример

// “hello” => 2
// “world” => 2