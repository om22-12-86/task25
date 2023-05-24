// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]


// int[] RandomArray()
// {
//     int[] Arr = new int[186];

//     for (int i = 0; i < Arr.Length; i++)
//     {
//         Arr[i] = new Random().Next(0,2);
//     }
//     return Arr;
// }

// int[] Arr = RandomArray();
// for (int i = 0; i < Arr.Length; i++)
// {
//     System.Console.WriteLine(Arr[i]);
// }
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

    // Console.WriteLine("Введите целое число А: ");
    // int a = Convert.ToInt32(Console.ReadLine());
    // Console.WriteLine("Введите целое число B: ");
    // int b = Convert.ToInt32(Console.ReadLine());
    // int x = a;
    // for (int i = 2; i <= b; i++)
    // {
    //   if (b == 0)
    //   { x = 1; }
    //   else if(b == 1)
    //   { x = a; }
    //   else
    //   {x = x * a;}
    // }
    // Console.WriteLine(x);

//     Задача 27: Напишите программу,
//      которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите целое число A: ");
   string A = Console.ReadLine();
   int x = 0;
    
   for (int i = 0; i < A.Length; i++)
    {
      //Console.WriteLine(Int32.Parse(Convert.ToString(A[i])));
      if (A.Length == 1)
      {
       x = Int32.Parse(Convert.ToString(A[i]));
      }
      else
      {
     
      x = x + Int32.Parse(Convert.ToString(A[i]));
      }
    } 
    Console.WriteLine(x);