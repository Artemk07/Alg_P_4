Console.WriteLine("Строка: ");
char[] Chars = Console.ReadLine().ToCharArray();

for (int i = 0; i<Chars.Length; i+=2){
Chars[i] = Char.ToUpper(Chars[i]);
}
Console.WriteLine(Chars);

Console.WriteLine("Число до 1000:");
int number = int.Parse(Console.ReadLine());
if (number <= 1000)
    for (int i = 0; i < number; i++)
        Console.WriteLine(i);
    else
        Console.WriteLine("Число > 1000.");

Console.WriteLine("Введите 5 элементов");
string[] stringArray = Console.ReadLine().Split(' ');
if (stringArray.Length != 5)
    Console.WriteLine("Что-то не так");
else
{
    string result = "";
for (int i = 4; i >= 0; i--)
    result += $"{stringArray[i]} ";
    Console.WriteLine(result.Trim());
}
