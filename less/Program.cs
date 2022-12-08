//Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y),
//причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

//вариант черезх массив

// int[] points = new int [2];

// // points[0] = Convert.ToInt32(Console.ReadLine()); //вручную задаем 0 и 1 элементы
// // points[1] = Convert.ToInt32(Console.ReadLine());

// for (int i = 0; i < points.Length; i++) // автоматическое заполнение ихз массива
// {
//     points[i] = Convert.ToInt32(Console.ReadLine());
// }
//points[0] - x, points[1] - y (координаты)
// if (points[0] > 0 && points[1] > 0)
// Console.WriteLine("1");

// if (points[0] < 0 && points[1] > 0)
// Console.WriteLine("2");

// if (points[0] < 0 && points[1] < 0)
// Console.WriteLine("3");

// if (points[0] > 0 && points[1] < 0)
// Console.WriteLine("4");

//РЕШЕНИЕ ЗАДАЧИ: ПО НОМЕРУ ЧЕТВЕРТИ ОПРЕДЕЛИТЬ ВОЗМОЖНЫЕ КООРДИНАТЫ
// int point; 
// point = Convert.ToInt32(Console.ReadLine());

// if (point==1)
// Console.WriteLine("x > 0, y > 0 ");

// if (point==2)
// Console.WriteLine("x < 0, y > 0 ");

// if (point==3)
// Console.WriteLine("x < 0, y < 0 ");

// if (point==4)
// Console.WriteLine("x > 0, y < 0 ");


//ЧЕРЕЗ МАССИВ  

// string[] output = {"x > 0, y > 0", "x < 0, y > 0", "x < 0,y < 0", "x > 0, y < 0"};
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 5 && number > 0) Console.WriteLine(output[number-1]);
// else Console.WriteLine("incorrect");


// Console.WriteLine("Введите координату x первой точки");
// int x1 = System.Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y первой точки");
// int y1 = System.Convert.ToInt32(Console.ReadLine());

// int[] p1 = new int[2];
// p1[0] = x1;
// p1[1] = y1;


// Console.WriteLine("Введите координату x второй точки");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите координату y второй точки");
// int y2 = Convert.ToInt32(Console.ReadLine());

// int[] p2 = new int[2];
// p2[0] = x2;
// p2[1] = y2;

// int[] p3 = new int[2];

// p3[0] = p2[0] - p1[0];
// p3[1] = p2[1] - p1[1];

// Console.WriteLine ("Расстояние между точками равно " + Math.Sqrt(Math.Pow(p3[0], 2) + Math.Pow(p3[1], 2)) );

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    Console.WriteLine(i*i);
} 
