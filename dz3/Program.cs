// Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

// Пример

// “aBcD1ef!-” => Нет  
// “шалаш” => Да  
// “55655” => Да 

Console.Clear();

Console.WriteLine("Напиши строку: ");
string str = Console.ReadLine();

int k = str.Length;
int count = 1;
for (int i = 0; i < k / 2; i++){
    if (str[i] != str[k - i - 1]){
        Console.WriteLine("Нет, это не палиндром!");
        break;
    }
    count++;
}
if (count > k / 2){
    Console.WriteLine("Да, это палиндром!");
}