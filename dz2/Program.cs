// Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы замененены на строчные. 

// Пример
// “aBcD1ef!-” => “abcd1ef!-”  

Console.Clear();

string str = "aBcD1ef!-";
char [] ch = new char [str.Length];

for (int i = 0; i < str.Length; i++){
    ch[i] = (str.ToLower().ToCharArray()[i]);
}

str = "";
foreach (char e in ch){
    str += e;
}
Console.Write(str);