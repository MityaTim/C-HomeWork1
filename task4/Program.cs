int a, b, c, m;
Console.Write("a = "); a =
Convert.ToInt32(Console.ReadLine());
m = a;
Console.Write("b = "); b = 
Convert.ToInt32(Console.ReadLine());
if (b > m) m = b;
Console.Write("c = "); c =
Convert.ToInt32(Console.ReadLine());
if (c > m) m = c;
Console.Write($"max = {m}");
