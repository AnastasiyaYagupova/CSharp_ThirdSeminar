/*
Задача 2
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
 double [] Array = new double [3];
 for(int i = 0; i< Array.Length; i++)
 {
    Console.WriteLine("Введите координаты точки A, разделяя командой ENTER ");
    Array[i] = Convert.ToDouble(Console.ReadLine());
 }

 double [] secArray = new double [3];
 for(int i = 0; i< secArray.Length; i++)
 {
    Console.WriteLine("Введите координаты точки B, разделяя командой ENTER ");
    secArray[i] = Convert.ToDouble(Console.ReadLine());
 }
double distance = Math.Sqrt(Math.Pow(secArray[0]-Array[0],2)
                           +Math.Pow(secArray[1]-Array[1],2)
                           +Math.Pow(secArray[2]-Array[2],2));
//double distance = Math.Sqrt((secArray[0]-Array[0])*(secArray[0]-Array[0])+(secArray[1]-Array[1])*(secArray[1]-Array[1])+(secArray[2]-Array[2])*(secArray[2]-Array[2]));
Console.WriteLine($"Расстояние между точками A и B: {distance}");

