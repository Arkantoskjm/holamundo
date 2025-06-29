using System;

public static class Multiplicacion
{
    public static void Multiplicar()
    {
        int tabla, iterador;
        Console.WriteLine("Ingrese el número para generar una tabla correspondiente:");
        tabla = int.Parse(Console.ReadLine());

        // Para iterador = 1 Hasta 10 Con Paso 1 Hacer
        for (iterador = 1; iterador <= 10; iterador++)
        {
            Console.WriteLine($"{tabla} x {iterador} = {tabla * iterador}");
        }

        Console.WriteLine("*** Ejecución Finalizada. ***");
        Console.WriteLine("Presione cualquier tecla para continuar...");
        Console.ReadKey();
    }
}