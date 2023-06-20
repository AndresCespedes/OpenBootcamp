class Program
{
    static void Main()
    {
        Console.WriteLine("----- Nombre -----");
        Console.Write("Ingrese su nombre: ");
        string? nombre = Console.ReadLine();
        Console.WriteLine("¡Hola, " + nombre + "!");

        Console.WriteLine("----- Hora Actual -----");
        DateTime horaActual = DateTime.Now;
        Console.WriteLine($"La hora actual es la siguiente {horaActual:HH:mm:ss}");
    }
}
