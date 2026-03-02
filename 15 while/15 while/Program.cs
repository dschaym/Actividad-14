Console.WriteLine("Sumar los números del 1 al 100");
int numero = 1;
int suma = 0;
while (numero <= 100)
{
    Console.WriteLine($"{suma} + {numero} = {suma+numero}");
    suma += numero;
    numero++;
}
Console.WriteLine($"Resultado {suma}");