// bool IsEven(int number)
// {
//     if (number % 2 == 0)
//     {
//         return true;
//     }
//     return false;
// }
// Console.WriteLine(IsEven(10));


// int GetMax(int a, int b)
// {
//     if (a > b)
//     {
//         return a;
//     }
//     else
//     {
//         return b;
//     }
//     
// }
// Console.WriteLine(GetMax(9, 5));


// int GetSum(int[] arr)
// {
//     int sum = 0;
//     foreach(int item in arr)
//     {
//         sum += item;
//     }
//     return sum;
// }
// Console.WriteLine(GetSum([5, 5, 3]));


// int CountPositive(int[] arr)
// {
//     int counter = 0;
//     foreach(int item in arr)
//     {
//         if (item > 0)
//         {
//             counter++;
//         }
//     }
//     return counter;
// }
// Console.WriteLine(CountPositive([-4,-8,1,243,34,-5]));


// bool IsPrime(int number)
// {
//     for (int i = 2; i < number; i++)
//     {
//         if (number % i == 0)
//         {
//             return false;
//         }
//     }
//     return true;
// } 
// Console.WriteLine(IsPrime(19));


// Console.Write("Massivin uzunlugunu daxil edin: ");
// string input = Console.ReadLine();
// if (!int.TryParse(input, out int number))
// {
//     Console.WriteLine("Invalid input!");    
// }
// int[] arr = new int[number];
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write("Massivin elementlerini daxil edin: ");
//     if (!int.TryParse(Console.ReadLine(), out arr[i]))
//     {
//         Console.WriteLine("Invalid input!");
//     }
// }
//
// int GetMax(int[] arr)
// { 
//     int max = arr[0];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//     }
//     return max;
// }
// Console.WriteLine(GetMax(arr));


// Console.Write("Massivin uzunlugunu daxil edin: ");
// string input = Console.ReadLine();
// if (!int.TryParse(input, out int number))
// {
//     Console.WriteLine("Invalid input!");    
// }
// int[] arr = new int[number];
// for (int i = 0; i < arr.Length; i++)
// {
//     Console.Write("Massivin elementlerini daxil edin: ");
//     if (!int.TryParse(Console.ReadLine(), out arr[i]))
//     {
//         Console.WriteLine("Invalid input!");
//     }
// }
//
// int GetDifference(int[] arr)
// {
//     int max = arr[0];
//     int min = arr[0];
//     for (int i = 0; i < arr.Length; i ++)
//     {
//         if (arr[i] > max)
//         {
//             max = arr[i];
//         }
//
//         if (arr[i] < min)
//         {
//             min = arr[i];
//         }
//     }
//     return max - min;
// }
// Console.WriteLine(GetDifference(arr));


// using System.Text.Json;
//
// int[] GetEvenNumbers(int[] arr)
// {
//     int counter = 0;
//     foreach (int item in arr)
//     {
//         if (item % 2 == 0)
//         {
//             counter++;
//         }
//     }
//     int[]newArr = new int[counter];
//     int index = 0;
//     foreach (int item in arr)
//     {
//         if (item % 2 == 0)
//         {
//             newArr[index] = item;
//             index++;
//         }
//     }
//     return newArr;
// }
//
// Console.WriteLine(JsonSerializer.Serialize(GetEvenNumbers([1, 4, 7, 8, 10])));

