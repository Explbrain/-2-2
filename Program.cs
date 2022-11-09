// Console.WriteLine("Введите число дня недели");
// int x=Convert.ToInt32 ( Console.ReadLine());

// if (x==1) Console.WriteLine("Понедельник. Этот день не выходной");
// else if (x==2) Console.WriteLine("Вторник. Этот день не выходной");
// else if (x==3) Console.WriteLine("Среда. Этот день не выходной");
// else if (x==4) Console.WriteLine("Четверг. Этот день не выходной");
// else if (x==5) Console.WriteLine("Пятница. Этот день не выходной");
// else if (x==6) Console.WriteLine("Суббота. Этот день выходной");
// else if (x==7) Console.WriteLine("Воскесенье. Этот день выходной");
//  else Console.WriteLine("Вы ввели не то число");

//  Console.WriteLine("Введите трехзначное число");
// int x=Convert.ToInt32 ( Console.ReadLine());
// int y = x/10;
// int result = y%10;
// Console.WriteLine(result);

//  Console.WriteLine("Введите натуральное число");
//  int x=Convert.ToInt32 ( Console.ReadLine());
//  int y=1+log10 (double x);
//  Console.WriteLine(y);

//   Console.WriteLine("Введите номер четверти");
// int number = Convert.ToInt32(Console.ReadLine());

// string res;
// if (number == 1) res= "x>0, y>0";
// else if  (number == 2) res="x<0, y>0";
// else if  (number == 3) res="x<0, y<0";
// else if  (number == 4) res="x>0, y<0";
// else res = "Нет такой четверти ";
// Console.WriteLine(res);

// void CheckKoord(int number)    //этот тип функции ничего не возвращает в основную программу, но что-то делает
// {
//     string res;
//     if (number == 1) res= "x>0, y>0";
// else if  (number == 2) res="x<0, y>0";
// else if  (number == 3) res="x<0, y<0";
// else if  (number == 4) res="x>0, y<0";
// else res = "Нет такой четверти ";
//     Console.WriteLine(res); 
// }

// try
// {
//     Console.WriteLine("Введите номер четверти");
//     int numnum = Convert.ToInt32(Console.ReadLine());
    
//     CheckKoord(numnum);
// }
// catch 
// {
//     Console.WriteLine("Введены некорректные данные");
// }

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=N; i++)

//     {
//         Console.WriteLine($"{i*i}");
//     }

//    Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 

// Console.WriteLine("Введите число");
// int N = Convert.ToInt32(Console.ReadLine());
// for (int i=1; i<=N; i++)

//     {
//         Console.WriteLine($"{i*i*i}");
//     }

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты x точки a");
// int ax=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки a");
// int ay=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки a");
// int az=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты x точки b");
// int bx=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты y точки b");
// int by=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координаты z точки b");
// int bz=Convert.ToInt32(Console.ReadLine());

// double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
// Console.WriteLine($"Расстояние между двумя точками равно {distance}");

// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите пятизначное число");
// int n=Convert.ToInt32(Console.ReadLine());
// int x, y, c, d;
// if (n > 9999 && n < 100000)
// {
//     x=n/10000; y=n%10; c=(n/1000)%10; d=(n/10)%10;
//     if (x==y && c==d)
//     {
//         Console.WriteLine("Введенное пятизначное число - это палиндром");
//     }
//     else Console.WriteLine("Введенное пятизначное число - это НЕ палиндром");
// }
// else Console.WriteLine("Введенное число не является пятизначным");
