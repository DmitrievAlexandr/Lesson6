//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
 //чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3
//Вводим сразу все числа в одну линию, не через бесконечное  
//кол-во ReadLine.

Console.WriteLine("Введите числа через запятую");
string text = Console.ReadLine();
string[] arrayStr = text.Split(",");
Console.WriteLine("Количество положительных чисел = " + Positiv(arrayStr));

int Positiv(string[] array)
{
    int count = 0, a = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (int.TryParse(arrayStr[i], out a))
        {
            if (a > 0)
                count++;
        }
    }
 
   return count;
}