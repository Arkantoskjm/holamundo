using System;

public static class TablaDeSalario
{
    public static void CalcularSalario()
    {
        int[] SalarioBase = new int[4];
        string[] BonoTex = new string[4];
        int[] BonoNum = new int[4];
        int[] SalarioTotal = new int[4];

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"Ingrese el {i + 1}° Salario base");
            SalarioBase[i] = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Ingrese el {BonoTex[i] + 1}° Bono");
            BonoTex[i] = Console.ReadLine()!;

            switch (BonoTex[i].ToLower())
            {
                case "high":
                    BonoNum[i] = 20;
                    break;
                case "mid":
                    BonoNum[i] = 10;
                    break;
                case "low":
                    BonoNum[i] = 5;
                    break;
                default:
                    Console.WriteLine("Bono no reconocido, no se aplicará ningún bono.");
                    break;
            }
            SalarioTotal[i] = SalarioBase[i] + (SalarioBase[i] * BonoNum[i] / 100);
        }
       
        Console.Clear();
        Console.WriteLine("#\tSalario\tBono\tSalario Total");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{i + 1}\t{SalarioBase[i]}\t{BonoNum[i]}%\t{SalarioTotal[i]}");
        }
        Console.ReadKey();
    }
}