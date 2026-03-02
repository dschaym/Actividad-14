Console.WriteLine("MENÚ");
int opcion = 0;
while (opcion != 4)
{
    Console.WriteLine("1. Arroz");
    Console.WriteLine("2. Frijoles");
    Console.WriteLine("3. Pollo");
    Console.WriteLine("4. Salir");
    Console.WriteLine("Ingrese el número del platillo que desea ordenar:");
    opcion = int.Parse(Console.ReadLine());
    switch (opcion)
    {
        case 1:
            Console.WriteLine("Has ordenado Arroz.");
            break;
        case 2:
            Console.WriteLine("Has ordenado Frijoles.");
            break;
        case 3:
            Console.WriteLine("Has ordenado Pollo.");
            break;
        case 4:
            Console.WriteLine("Gracias por su orden. ¡Hasta luego!");
            break;
        default:
            Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
            break;
    }

    if (opcion != 4)
    {
        Console.Write("Presiona una tecla para continuar...");
        Console.ReadKey(true);
        Console.Clear();
    }
}