﻿using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ingrese la clase a la que desea acceder");
        Console.WriteLine("1. Multiplicación");
        Console.WriteLine("2. Pedir una orden");
        Console.WriteLine("3. Tabla de Salarios");
        int clase = int.Parse(Console.ReadLine()!);

        switch (clase)
        {
            case 1:
                Multiplicacion.Multiplicar();
                break;
            case 2:
                PedirUnaOrden.Ordenar();
                break;
            case 3:
                TablaDeSalario.CalcularSalario();
                break;
            default:
                Console.WriteLine("Rango inválido"); 
                return;
        }
       
    }
}