//Задача 4: Напишите программу, которая принимает на вход
//три числа и выдает максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Enter number1: ");
string StrNumber1 = Console.ReadLine();
int number1 = Convert.ToInt32(StrNumber1);
Console.WriteLine("Enter number2: ");
string StrNumber2 = Console.ReadLine();
int number2 = Convert.ToInt32(StrNumber2);
Console.WriteLine("Enter number3: ");
string StrNumber3 = Console.ReadLine();
int number3 = Convert.ToInt32(StrNumber3);
int max = number1;
if (number2>max)
{
    max=number2;
    if (number3>max)
  {
    max=number3;
    Console.WriteLine("max =");
    Console.WriteLine(max);
  }
    else 
    {
      Console.WriteLine("max =");
      Console.WriteLine(max);
    }
}
else
  if (number3>max)
  {
    max=number3;
    Console.WriteLine("max =");
    Console.WriteLine(max);
  }
  else 
  {
    Console.WriteLine("max =");
   Console.WriteLine(max);
   }