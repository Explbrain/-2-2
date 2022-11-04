Console.WriteLine("Введите число дня недели");
int x=Convert.ToInt32 ( Console.ReadLine());

if (x==1) Console.WriteLine("Понедельник. Этот день не выходной");
else if (x==2) Console.WriteLine("Вторник. Этот день не выходной");
else if (x==3) Console.WriteLine("Среда. Этот день не выходной");
else if (x==4) Console.WriteLine("Четверг. Этот день не выходной");
else if (x==5) Console.WriteLine("Пятница. Этот день не выходной");
else if (x==6) Console.WriteLine("Суббота. Этот день выходной");
else if (x==7) Console.WriteLine("Воскесенье. Этот день выходной");
 else Console.WriteLine("Вы ввели не то число");


