double cm, m ,km;

Console.Write("Entre com a medida (em metros): ");
m = Convert.ToDouble(Console.ReadLine());

cm = m * 100;
km = m / 1000;

Console.WriteLine("\n--- Equivalência ---\n");
Console.WriteLine($"{cm} cm");
Console.WriteLine($"{m} m");
Console.WriteLine($"{km} km\n");
