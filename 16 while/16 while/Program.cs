Console.WriteLine("Ingrese un número");
int numero = 1;
int suma = 0;
while (numero !=0)
{
    numero = int.Parse(Console.ReadLine());
    suma += numero;
}
Console.WriteLine($"En total ingresaste {suma}");
Console.WriteLine();