Console.WriteLine("Tablas de multiplicar");
for (int a= 1; a <=5; a++)
{
    Console.WriteLine($"Tabla del {a}");
    for (int p = 1; p <=10; p++)
        Console.WriteLine($"{a} x {p} = {a*p}");
}