// Console.Write("Mehsul sayi daxil et: ");
// string input = Console.ReadLine();
// if (!int.TryParse(input, out int productCount))
// {
//     Console.WriteLine("Invalid input");
//     return;
// }
// string[] products = new string[productCount];
// int[] counts = new int[productCount];
//
// for (int i = 0; i < productCount; i++)
// {
//     Console.WriteLine($"Enter product {i + 1} name:");
//     products[i] = Console.ReadLine();
//     Console.WriteLine($"Enter product {i + 1} amount:");
//     string input2 = Console.ReadLine();
//     if (!int.TryParse(input2, out int productAmount)|| productAmount < 0)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     counts[i] = productAmount;
// }
//
// while (true)
// {
//     
//     Console.WriteLine("\n===== MENYU =====");
//     Console.WriteLine("1. Bütün məhsulları göstər");
//     Console.WriteLine("2. Ümumi məhsul sayını göstər");
//     Console.WriteLine("3. Ən çox olan məhsulu göstər");
//     Console.WriteLine("4. Ən az olan məhsulu göstər");
//     Console.WriteLine("5. Müəyyən saydan çox olan məhsulları göstər");
//     Console.WriteLine("6. Məhsul axtar");
//     Console.WriteLine("7. Yeni məhsul sayı əlavə et");
//     Console.WriteLine("8. Çıxış");
//     Console.Write("Seciminizi daxil edin (1-8): ");
//     string choice = Console.ReadLine();
//     switch (choice)
//     {
//         case "1":
//             ShowProducts(products,counts);
//             break;
//         case "2":
//             Console.WriteLine((GetTotalCount(counts)));
//             break;
//         case "3":
//             GetMaxProduct(counts);
//             break;
//         case "4":
//             GetMinProduct(counts);
//             break;
//         case "5":
//             Console.Write("Say daxil edin: ");
//             int number = int.Parse(Console.ReadLine());
//             ShowProductsGreaterThan(products,counts,number);
//             break;
//         case "6":
//             Console.Write("Mehsulun adini daxil edin: ");
//             string name = Console.ReadLine();
//             SearchProduct(products,counts,name);
//             break;
//         case "7":
//             Console.Write("Mehsulun adini daxil edin: ");
//             string productName = Console.ReadLine();
//             Console.Write("Say daxil edin: ");
//             int amount = int.Parse(Console.ReadLine());
//             AddCount(products,counts,productName,amount);
//             break;
//         case "8":
//             Console.WriteLine("Program baglandi.");
//             break;
//         default:
//             Console.WriteLine("Error!");
//             break;
//     }
//    
//     
// }
//
// void ShowProducts(string[] products, int[] counts)
// {
//     for (int i = 0; i < products.Length; i++)
//     {
//         Console.WriteLine($"{products[i]}: {counts[i]}");
//     }
// }
//
// int GetTotalCount(int[] counts)
// {
//     int total = 0;
//     for (int i = 0; i < counts.Length; i++)
//     {
//         total+=counts[i];
//     }
//     return total;
// }
//
// void GetMaxProduct(int[] counts)
// {
//     int max = counts[0];
//     int index = 0;
//     for (int i = 0; i < counts.Length; i++)
//     {
//         if (counts[i] > max)
//         {
//             max = counts[i];
//             index = i;
//         }
//     }
//     Console.WriteLine($"{products[index]}: {max}");
// }
//
// void GetMinProduct(int[] counts)
// {
//     int min = counts[0];
//     int index = 0;
//     for (int i = 0; i < counts.Length; i++)
//     {
//         if (counts[i] < min)
//         {
//             min = counts[i];
//             index = i;
//         }
//     }
//     Console.WriteLine($"{products[index]}: {min}");
// }
//
// void ShowProductsGreaterThan(string[] products, int[] counts, int number)
// {
//     bool found = false;
//     for (int i = 0; i < products.Length; i++)
//     {
//         if (counts[i] > number)
//         {
//             Console.WriteLine($"{products[i]}: {counts[i]}");
//             found = true;
//         }
//     }
//
//     if (!found)
//     {
//         Console.WriteLine("Mehsul tapilmadi. ");
//     }
// }
//
// void SearchProduct(string[] products, int[] counts, string name)
// {
//     bool found = false;
//     for (int i = 0; i < products.Length; i++)
//     {
//         if (products[i].ToLower() == name.ToLower())
//         {
//             found = true;
//             break;
//         }
//     }
//
//     if (!found)
//     {
//         Console.WriteLine("Mehsul tapilmadi. ");
//     }
// }
//
// void AddCount(string[] products, int[] counts, string name, int amount)
// {
//     bool found = false;
//     for (int i = 0; i < products.Length; i++)
//     {
//         if (products[i].ToLower() == name.ToLower())
//         {
//             counts[i]+=amount;
//             Console.WriteLine($"Yeni say: {counts[i]}");
//             found = true;
//             break;
//         }
//     }
//     if (!found)
//     {
//         Console.WriteLine("Mehsul tapilmadi. ");
//     }
// }




