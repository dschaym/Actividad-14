Console.WriteLine("Patrón de filas númericas repetidas");
for (int fila = 1; fila <= 9; fila++)
{
    for(int columna = 0; columna < fila; columna++)
    {
        Console.Write(fila);
    }
    Console.WriteLine();
}