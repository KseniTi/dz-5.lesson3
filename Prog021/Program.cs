/*
Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

void Zadacha21()
{

    Console.WriteLine("Введите координаты точки А через пробел: ");
    string pointA = Console.ReadLine();
    Console.WriteLine("Введите координаты точки B через пробел: ");
    string pointB = Console.ReadLine();
    Console.WriteLine("Введите координаты точки C через пробел: ");
    string pointC = Console.ReadLine();

    string[] pointASplit = pointA.Split();
    string[] pointBSplit = pointB.Split();
    string[] pointCSplit = pointC.Split();
    
    double distance = Math.Sqrt(Math.Pow(Convert.ToInt32(pointASplit[0]) - Convert.ToInt32(pointBSplit[0]) - Convert.ToInt32(pointCSplit[0]), 2) 
                        + Math.Pow(Convert.ToInt32(pointASplit[1]) - Convert.ToInt32(pointBSplit[1]) - Convert.ToInt32(pointCSplit[1]), 2));
    Console.WriteLine("Растояние между точка в 3D пространстве: " + Math.Round(distance, 2));

}

Zadacha21();