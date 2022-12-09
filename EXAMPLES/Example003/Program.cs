/*
Задача 3
Напишите программу, которая принимает на вход число (N) и помещает в массив таблицу кубов чисел от 1 до N. 
Полученный массив вывести на экран.
3 -> [1, 8, 27].
5 -> [1, 8, 27, 64, 125]
Указание: Вывод массива вынести в отдельную функцию.
*/

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    int x = 0;
    while(index < Length)  //Решила не менять на FOR, потому что 2 переменные и пока что не знаю, как можно их вместить в этот цикл
    {
        collection[index] = x+1;
        collection[index] = ((int)Math.Pow(collection[index],3));
        index++;
        x++;
    }
}
void PrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;  // как ввести int в цикл for?
    for(index = 0; index < Length; index++)
    {
        Console.WriteLine(collection[index]); // попробуй сделать более красиво
    }
}

int N = new Random().Next(0,11);
Console.WriteLine(N);

int[] Array = new int [N];


FillArray(Array);
PrintArray(Array);

/*
void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    int x = 0;
    while(index < Length)
    {
        collection[index] = x+1;
        index++;
        x++;
    }
}
void PrintArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index < Length)
    {
        collection[index] = ((int)Math.Pow(collection[index],3));
        Console.WriteLine(collection[index]);
        index++;
    }
}

int N = new Random().Next(0,11);
Console.WriteLine(N);

int[] Array = new int [N];


FillArray(Array);
PrintArray(Array);
*/