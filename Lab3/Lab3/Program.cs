// Console.Write("Telebe sayini daxil et: ");
// string input = Console.ReadLine();
// if (!int.TryParse(input, out int studentCount))
// {
//     Console.WriteLine("Telebe sayiniz bulunamadi");
//     return;
// }
// string[] students = new string[studentCount];
// int[]grades = new int[studentCount];
//
// for (int i = 0; i < studentCount; i++)
// {
//     Console.Write($"Enter student {i+1} name : ");
//     students[i] = Console.ReadLine();
//     Console.Write("Telebenin balini daxil edin: ");
//     string input2 = Console.ReadLine();
//     if (!int.TryParse(input2, out int studentGrade)|| studentGrade<0 || studentGrade>100)
//     {
//         Console.WriteLine("Invalid input");
//         return;
//     }
//     grades[i] = studentGrade;
// }
//
// while (true)
// {
//     Console.WriteLine("\n===== MENYU =====");
//     Console.WriteLine("1. Bütün tələbələri göstər");
//     Console.WriteLine("2. Orta balı göstər");
//     Console.WriteLine("3. Ən yüksək balı göstər");
//     Console.WriteLine("4. Ən aşağı balı göstər");
//     Console.WriteLine("5. Keçən tələbələri göstər");
//     Console.WriteLine("6. Kəsilən tələbələri göstər");
//     Console.WriteLine("7. Ada görə tələbə axtar");
//     Console.WriteLine("8. Çıxış");
//     Console.Write("Seciminizi daxil edin (1-8): ");
//     string choice = Console.ReadLine();
//     switch (choice)
//     {
//         case "1":
//             ShowAllStudents(students, grades);
//             break;
//         case "2":
//             Console.WriteLine("Average is: " + Average(grades));
//             break;
//         case "3":
//             Console.WriteLine("Max is: " + MaxGrade(grades));
//             break;
//         case "4":
//             Console.WriteLine("Min is: " + MinGrade(grades));
//             break;
//         case "5":
//             ShowPassed(students, grades);
//             break;
//         case "6":
//             ShowFailed(students, grades);
//             break;
//         case "7":
//             SearchStudent(students, grades);
//             break;
//         case "8":
//         {
//             Console.Write("Program baglandi. ");
//             break;
//         }
//         
//     }
// }
//
// void ShowAllStudents(string[] students, int[] grades)
// {
//     for (int i = 0; i < students.Length; i++)
//     {
//         Console.WriteLine($"{students[i]} - {grades[i]}");
//     }
// }
//
// double Average(int[] grades)
// {
//     double sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return sum / grades.Length;
//     
// }
//
//
//
// int MaxGrade(int[] grades)
// {
//     int max = grades[0];
//     foreach (int grade in grades)
//     {
//         if (grade > max)
//         {
//             max = grade;
//         }
//     }
//     return max;
// }
//
// int MinGrade(int[] grades)
// {
//     int min= grades[0];
//     foreach (int grade in grades)
//     {
//         if (grade < min)
//         {
//             min = grade;
//         }
//     }
//     return min;
// }
//
//  void ShowPassed(string[]students, int[] grades)
// {
//     Console.Write("\nKecen telebeler: ");
//     for (int i = 0; i < students.Length; i++)
//     {
//         if (grades[i] >= 60)
//         {
//             Console.WriteLine($"{students[i]} - {grades[i]}");
//         }
//     }
// }
//  void ShowFailed(string[] students, int[] grades)
// {
//     Console.WriteLine("\nKəsilən tələbələr:");
//
//     for (int i = 0; i < students.Length; i++)
//     {
//         if (grades[i] < 60)
//         {
//             Console.WriteLine($"{students[i]} - {grades[i]}");
//         }
//     }
// }
//
//  void SearchStudent(string[] students, int[] grades)
// {
//     Console.Write("Axtarmaq istediyiniz telebenin adini qeyd edin: ");
//     string name = Console.ReadLine();
//     for (int i=0;i<students.Length;i++)
//     {
//         if (students[i] == name)
//         {
//            Console.WriteLine($"Student name: {students[i]},Grade: {grades[i]}");
//            return;
//         }
//     }
//     Console.Write("Student not found!");
// }

