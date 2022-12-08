Console.WriteLine("Введите координату x первой точки");
int x1 = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = System.Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z первой точки");
int z1 = System.Convert.ToInt32(Console.ReadLine());

// int[] p1 = new int[3];   Сначала хотела решить с помощью массива, но решила "проще"
// p1[0] = x1;              когда возникла опечатка в "массивном" методе. Опечатку в итоге нашла,
// p1[1] = y1;              но оставила оба решения.
// p1[2] = z1;

Console.WriteLine("Введите координату x второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату z второй точки");
int z2 = System.Convert.ToInt32(Console.ReadLine());
int x3 = x2-x1;
int y3 = y2-y1;
int z3 = z2-z1;

// int[] p2 = new int[3];
// p2[0] = x2;
// p2[1] = y2;
// p2[2] = z2;

// int[] p3 = new int[3];

// p3[0] = p2[0] - p1[0];
// p3[1] = p2[1] - p1[1];
// p3[2] = p2[2] - p1[2];

double Dist = 0;
// Dist = Math.Sqrt(Math.Pow(p3[0], 2) + Math.Pow(p3[1],2) + Math.Pow(p3[2], 2));
Dist = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2) + Math.Pow(z3, 2));
 Console.WriteLine ("Расстояние между точками равно " + Dist);

