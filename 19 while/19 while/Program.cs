Console.WriteLine("Ingrese un número para sacar su tabla de multiplicar");
int numero;
while (!int.TryParse(Console.ReadLine(), out numero))
{
    Console.WriteLine("Ingrese un número válido. Buena onda");
}
int p = 1;
while (p <= 10)
{
    Console.WriteLine($"{numero} x {p} = {numero * p}");
    p++;
}