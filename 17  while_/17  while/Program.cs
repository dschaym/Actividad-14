Console.WriteLine("Ingrese un número: ");
int numeros = 0;
int rango = -1;
while (rango != 0)
{
    Console.Write("Número: ");
    rango = int.Parse(Console.ReadLine());
    if (rango > 0)
    {
        Console.WriteLine("El número es positivo.");
        numeros++;
    }
}
Console.WriteLine($"Total de números positivos: {numeros}");