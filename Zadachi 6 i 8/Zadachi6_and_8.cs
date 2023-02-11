//Задача 6: Напишите программу, которая на вход принимает
//число и выдает, является ли число четным (делится ли оно на
//два без остатка).
//Задача 8: Напишите программу, которая на вход принимает
//число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Enter N: ");
string StrN = Console.ReadLine();
int N = Convert.ToInt32(StrN);
if (N==1)
  {
    Console.WriteLine("Нет таких чисел");
  }
else
 {
    if (N==0|N==-1)
      {
        Console.WriteLine("0");
      }
    else 
      {
        if ((N % 2)==0)
         {
            Console.WriteLine("четное");
            if (N>0)
              {
               int[] even = new int[(N/2)];
               int CurrentNumber=2;
               int indexEvenPositive=0;
                 while (CurrentNumber<=N)
                   {
                    even[indexEvenPositive]=CurrentNumber;
                    CurrentNumber=CurrentNumber+2;
                    indexEvenPositive=indexEvenPositive+1;
                   }
                 var array1=string.Join(",", even);
                 Console.WriteLine(array1);
              }
            else 
              {
               int ModuleEven = Math.Abs(N);
               int[] even = new int[(ModuleEven/2)+1];
               int CurrentNumber=-2;
               int indexEvenNegative=1;
               while (CurrentNumber>=N)
                   {
                    even[indexEvenNegative]=CurrentNumber;
                    CurrentNumber=CurrentNumber-2;
                    indexEvenNegative=indexEvenNegative+1;
                   }
                 var array2=string.Join(",", even);
                 Console.WriteLine(array2);
              }
              }
        else
          {
          Console.WriteLine("нечетное");
           if (N>0)
              {
               int[] uneven = new int[(N-1)/2];
               int CurrentNumber=2;
               int indexUnevenPositive=0;
                 while (CurrentNumber<=N-1)
                   {
                    uneven[indexUnevenPositive]=CurrentNumber;
                    CurrentNumber=CurrentNumber+2;
                    indexUnevenPositive=indexUnevenPositive+1;
                   }
                 var array3=string.Join(",", uneven);
                 Console.WriteLine(array3);
              }
            else
              {
                int ModuleUneven = Math.Abs(N);
               int[] uneven = new int[(ModuleUneven/2)+1];
               int CurrentNumber=-2;
               int indexUnevenNegative=1;
               while (CurrentNumber>=N)
                   {
                    uneven[indexUnevenNegative]=CurrentNumber;
                    CurrentNumber=CurrentNumber-2;
                    indexUnevenNegative=indexUnevenNegative+1;
                   }
                 var array4=string.Join(",", uneven);
                 Console.WriteLine(array4);
              }
          }
      }
 }    