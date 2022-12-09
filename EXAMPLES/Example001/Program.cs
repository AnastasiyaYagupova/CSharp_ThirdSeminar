/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число ");
int num = Convert.ToInt32(Console.ReadLine());

string array = num.ToString();
int[] x = new int[array.Length];
for(int i = 0; i < array.Length; i++)
{
    x[i]= int.Parse(array[i].ToString());
}

if(x[0]==x[4] && x[1]==x[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
