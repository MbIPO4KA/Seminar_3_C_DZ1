/* Задача 19
Напишите программу, которая принимает на вход пятизначное число
 и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/
Console.Write("Введите пятизначное число: ");
int namber = Convert.ToInt32(Console.ReadLine());


int result = (namber / 10000) % 10 ;
int result2 = namber  % 10 ;
int result3 = (namber / 1000) % 10 ;
int result4 = (namber / 10) % 10 ;

if (namber >= 10000 && namber < 100000  )   
{
    Console.WriteLine($"первая цифра этого числа  {result}  ");      
    Console.WriteLine($"последняя цифра этого числа  {result2}  ");
    Console.WriteLine($"вторая цифра этого числа  {result3}  ");      
    Console.WriteLine($"четвертая цифра этого числа  {result4}  ");
    if (result==result2 && result3==result4)
    {
        Console.WriteLine("Число является  палиндромом. ");
    }
    else
    {
        Console.WriteLine("Число НЕ является  палиндромом. ");
    }
}
else
{
     Console.Write($"Нет, число {namber} не пятизначное."); 
        
}
