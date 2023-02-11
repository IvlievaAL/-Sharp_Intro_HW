//Задача 2: Напишите программу, которая на вход принимает 
//два числа и выдает, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3
Console.WriteLine("Enter number1: ");
string StrNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(StrNumber1);
Console.WriteLine("Enter number2: ");
string StrNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(StrNumber2);
int max;
if (number1==number2)
{
    Console.WriteLine("Numbers are equal");
}
else
 if (number1>number2)
  {
   max=number1;
   Console.WriteLine(max);
  }
  else 
  {
   max=number2;
   Console.WriteLine(max);
  }