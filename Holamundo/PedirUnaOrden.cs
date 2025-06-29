using System;

public static class PedirUnaOrden
{
    public static void Ordenar()
    {
        Console.Write("Menú Principal \n 1. Sandwich $80 \n 2. Pizza $120 \n 3. Juguito $40 \n");
        Console.WriteLine("Ingrese una orden:");
        int orden = int.Parse(Console.ReadLine()!);
        Console.WriteLine("Ingrese el billete con el que va a pagar");
        int billete = int.Parse(Console.ReadLine()!);
        int cambio;
        string producto = "";

        switch (orden)
        {
            case 1: producto = "Sandwich";
                cambio = billete - 80; break;
            case 2: producto = "Pizza";
                cambio = billete - 120; break;
            case 3: producto = "Juguito";
                cambio = billete - 40; break;
            default: Console.WriteLine("Orden inválida"); return;
        }
        Console.WriteLine("Usted ha ordenado " + producto);
        Console.WriteLine("Su cambio es $" + cambio); 
    }
}
   