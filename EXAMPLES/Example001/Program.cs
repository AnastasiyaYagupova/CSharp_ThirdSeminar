/* Задача 1
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

Console.WriteLine("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

int [] Array = new int [5];

int Length = Array.Length;
    int i = Length;
        while(N > 0)
        {
            Array[i-1] = N % 10; 
            N = N / 10;  
            i--;
        }

if(Array[0]==Array[4] && Array[1]==Array[3])
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

/*
int [] Array = new int [5];
int [] TurnOverArray = new int [5];

void FillArray(int[] Collection)
{
    int Length = Collection.Length;
    int i = Length;
        while(N > 0)
        {
            Collection[i-1] = N % 10; 
            N = N / 10;  
            i--;
        }
}

void SecFillArray(int[] Collection)
{
   int Length = Collection.Length;
    int i = 0;
        while(N > 0)
        {
            Collection[i] = N % 10; 
            N = N / 10;  
            i++;
        } 
}
void PrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;  
    for(index = 0; index < Length; index++)
    {
        Console.WriteLine(collection[index]); 
    }
}

FillArray(Array);
SecFillArray(Array);

PrintArray(Array);
PrintArray(TurnOverArray);
*/






/*
ПРЕДЫДУЩЕЕ РЕШЕНИЕ
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
*/