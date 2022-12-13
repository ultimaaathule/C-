

//задача 8

Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++);
if (i % 2== 0)
Console.WriteLine(i);


//задача 4

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int c = Convert.ToInt32(Console.ReadLine());
int max = a;
if (b > a)
max = b;
if (c > max)
max = c;
Console.WriteLine(max);

// задача 6

Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
 Console.WriteLine("Да"); 
else Console.WriteLine("Нет"); 


//Задача 2

Console.WriteLine("ВВедите первое число");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a > b)
    Console.WriteLine("Первое число больше");
else Console.WriteLine("Второе число больше");
