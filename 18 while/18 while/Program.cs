Console.Write("Ingresa un entero no negativo: ");
int n = int.Parse(Console.ReadLine());
long resultado = 1;
int p = n;
while (p > 1)
{
    resultado *= p;
    p--;
}
Console.WriteLine($"{n}! = {resultado}");