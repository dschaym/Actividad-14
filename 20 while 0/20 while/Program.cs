Console.WriteLine("Ingrese un número para saber cuántos dígitos tiene:");
long n;
while (!long.TryParse(Console.ReadLine(), out n))
{
    Console.Write("Entrada inválida. Ingresa un entero: ");
}
long valor = Math.Abs(n); //es el valor absoluto por si usan uno negativo
if (valor == 0)
{
    Console.WriteLine("Dígitos: 1");
}
int digitos = 0;
while (valor > 0)
{
    valor /= 10;
    digitos++;
}
Console.WriteLine($"Hay {digitos} dígitos");