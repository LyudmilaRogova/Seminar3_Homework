// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

void Palindrome(int number){
    if (number / 10000 == number % 10 && number / 1000 % 10 == number % 100 / 10) Console.WriteLine(number + " - это палиндром");
    else Console.WriteLine(number + " - это не палиндром");
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if(num < 10000 || num > 99999) Console.WriteLine("Введенное число не удовлетворяет условиям задачи");
else Palindrome(num);

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// double Distance(int x1, int y1, int z1, int x2, int y2, int z2){
//     double s = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
//     return s;
// }

// Console.Write("Введите координату x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Расстояние между точками в 3D пространстве: " + Distance(x1, y1, z1, x2, y2, z2));


// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// void Square(int n){
//     int i = 1;
//     while(i<=n){
//         Console.Write(i*i*i + ", ");
//         i++;
//     }
// }

// Console.Write("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num <= 0) Console.Write("Некорректный ввод");
// else Square(num);

