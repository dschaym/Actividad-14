Console.WriteLine("Suma números hasta que el total supere 100.");
int suma = 0;
while (suma <= 100)
{
    Console.Write("Ingresa un entero: ");
    int num;
    while (!int.TryParse(Console.ReadLine(), out num))
    {
        Console.Write("Entrada inválida. Ingresa un entero: ");
    }
    suma += num;
    Console.WriteLine($"Suma parcial: {suma}");
}
Console.WriteLine($"¡Listo! La suma superó 100. Total: {suma}");