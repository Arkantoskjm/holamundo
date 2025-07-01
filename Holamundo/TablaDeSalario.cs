using System;

public static class TablaDeSalario
{
    public static void CalcularSalario()
    {
        int[] SalarioBase = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ingrese el {i + 1}° Salario base");
            SalarioBase[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine(SalarioBase[i]);
        }
        Console.WriteLine("Ingrese cualquier tecla para continuar...");
        Console.ReadKey();
    }
}