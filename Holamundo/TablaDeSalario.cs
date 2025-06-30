using System;

public static class TablaDeSalario
{
    public static void CalcularSalario()
    {
        int[] SalarioBase = new int[4];

        for (int i = 1; i <= 4; i++)
        {
            Console.WriteLine($"Ingrese el {i}° Salario base");
            SalarioBase[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine(SalarioBase[i]);
        }

    }
}
