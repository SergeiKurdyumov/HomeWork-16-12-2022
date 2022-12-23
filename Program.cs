




// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void AboveZero(int num){
//     int[] array = new int [num];
//     int summ = 0;
//     for(int i = 0; i < array.Length; i++){
//          Console.WriteLine($"Введите число: ");
//          array[i] = Convert.ToInt32(Console.ReadLine());
//         if(array[i] > 0) summ = summ + 1;}
//     Console.WriteLine($"{summ}");
// }
// Console.WriteLine("Сколько чисел вы хотите ввести?");
// AboveZero(Convert.ToInt32(Console.ReadLine()));








// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
// задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void NumbersInLine(double k1, double b1, double k2, double b2){
//         double x = (b2 - b1) / (k1 - k2);
//     Console.WriteLine($"{x} {k1 * x + b1}");
// }
// Console.WriteLine("Введите координату k1");
// double n1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату b1");
// double n2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату k2");
// double n3 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату b2");
// double n4 = Convert.ToInt32(Console.ReadLine());
// NumbersInLine(n1,n2,n3,n4);