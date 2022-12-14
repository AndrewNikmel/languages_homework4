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


// int LineSum(int num){
//     if (num<10){
//         return num;
//     }
//     int rest = num%10;
//     int rr = num/10;
//     return rest + LineSum(rr);
// }
// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int res = LineSum(number);
// Console.WriteLine($"Сумма цифр числа {number} равна {res}");




// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// (спрашиваем длину массива, просим пользователя ввести числа)

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] Array(){
//     int [] arr = new int [8];
//     for(int i = 0; i < arr.Length; i++){
//         arr[i] = new Random().Next(0,2);
//     }
//     return arr;
// }
// void ShowArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++){
//         Console.Write($"{arr[i]} ");
//     }
// }

// ShowArray(Array());

// второй вариант


// int[] Array(int numb){
//     int [] arr = new int [numb];
//     for(int i = 0; i < numb; i++){
//         arr[i] = new Random().Next(5,16);
//     }
//     return arr;
// }
// void ShowArray(int[] arr){
//     for (int i = 0; i < arr.Length; i++){
//         Console.Write($"{arr[i]} ");
//     }
// }
// Console.WriteLine("Enter the size of array");
// int lenghthy = Convert.ToInt32(Console.ReadLine());
// ShowArray(Array(lenghthy));



// int[] Array(int [] ar)
// {
//     int size = Convert.ToInt32(Console.ReadLine());
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Enter a number:");
//         int a = Convert.ToInt32(Console.ReadLine());
//         ar [a] = (a + " " );
//     }
//     return ar ;
// }
// Console.WriteLine("Enter the size of your array: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Array();
// Console.WriteLine($"Your array is {Array()}");

// void Size(){
//     Console.WriteLine("Enter the size");
//     int size = Convert.ToInt32(Console.ReadLine());
// }

// int [] Array(int arr){
//     for(int i = 0; i < void Size(); i++){
        
//     }
//     return arr
// }

/// give up again


// void WriteArray(int [] array, int length){
//     for (int i = 0; i < length; i++){
//         int a = Convert.ToBase64CharArray(Console.ReadLine());
//         array [i] = a;
//         Console.WriteLine(array[i] + " ");
//     }
// }
// Console.WriteLine("Enter the size of your array: ");
// int size = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter the number");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = WriteArray(num, size);
// Console.Write($"Your array is {res}");


// int[] Array(int [] ar, int size)
// {
//     size = Convert.ToInt32(Console.ReadLine());
//     ar[] = new int [size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine("Enter a number:");
//         int a = Convert.ToInt32(Console.ReadLine());
//         ar [a] = (a + " " );
//     }
//     return ar ;
// }
// Console.WriteLine("Enter the size of your array: ");
// int num = Convert.ToInt32(Console.ReadLine());
// Array();
// Console.WriteLine($"Your array is {Array()}");

// int Length(int num){
//     num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

void Array(int[] a, int b)
{
    a = new int [b];
    for(int i = 0; i < b; i++){
        Console.WriteLine("Enter the number: ");
        a[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.Write(a);
}
Console.WriteLine("Enter the length of the array");
int length = Convert.ToInt32(Console.ReadLine());
int[] arr = new int [length];
Array(arr, length);
