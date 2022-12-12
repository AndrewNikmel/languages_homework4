// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int NaturalPow(int numberA, int numberB){
//     int nice = 1;
//     for(int i=1; i <= numberB; i++){
//         nice = nice * numberA;
//     }
//     return nice;
// }
// Console.WriteLine("Enter the first number: ");
// int numA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the second number: ");
// int numB = Convert.ToInt32(Console.ReadLine());
// int res = NaturalPow(numA, numB);
// Console.WriteLine($"Число {numA} в натуральной степени числа {numB} равно {res}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Вот так оно не работает. надо думать


// int LineSum(int num){
//     int rest = num%10;
//     int sum = 0;
//     while(rest>0){
//         sum = (num-rest)/10 + rest;
//     }
//     return sum;
// }
// Console.WriteLine("Enter the number");
// int number = Convert.ToInt32(Console.ReadLine());
// int res = LineSum(number);
// Console.WriteLine($"Сумма цифр числа {number} составляет {res}");



// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// (спрашиваем длину массива, просим пользователя ввести числа)

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
