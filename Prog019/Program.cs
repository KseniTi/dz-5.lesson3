/*Напишите программу, которая принимает на
вход пятизначное число и проверяет, является ли оно
палиндромом.
14212 -> нет
23432 -> да
12821 -> да
*/

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число");
    int number = Convert.ToInt32(Console.ReadLine());
   
    if(Convert.ToString(number)[0] == Convert.ToString(number)[4] && Convert.ToString(number)[1] == Convert.ToString(number)[3]) Console.WriteLine("Число палиндром");
    else Console.WriteLine("Не является");
}

Zadacha19();

