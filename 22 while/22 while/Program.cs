Console.WriteLine("Ingrese su contraseña: ");
string contra = Console.ReadLine();
while (true)
{
    if (contra == "Mi1234")
    {
        Console.WriteLine("Contraseña correcta. Acceso concedido.");
        break;
    }
    else
    {
        Console.WriteLine("Contraseña incorrecta. Intente nuevamente: ");
        contra = Console.ReadLine();
    }

}