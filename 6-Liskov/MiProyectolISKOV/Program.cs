using System;

class Program
{
    static void Main()
    {
        // Crear instancias de las clases
        Fruta fruta = new Fruta();
        Manzana manzana = new Manzana();
        Banana banana = new Banana();

        // Utilizar las instancias en lugares donde se espera una Fruta
        MostrarInformacion(fruta);
        MostrarInformacion(manzana);
        MostrarInformacion(banana);
    }

    static void MostrarInformacion(Fruta fruta)
    {
        Console.WriteLine($"Nombre: {fruta.Nombre}");
        Console.WriteLine($"Color: {fruta.ObtenerColor()}");
        Console.WriteLine();
    }
}
