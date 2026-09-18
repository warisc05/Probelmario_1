using System;
namespace Ejercicio1
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine();
Console.WriteLine("  EJERCICIO 1: POTENCIA DE UN MOTOR DC        ");
Console.WriteLine();
Console.WriteLine("Calcula la potencia electrica (P = V * I) y determina");
Console.WriteLine("si el motor opera dentro de un rango seguro.\n");
Console.Write("Ingrese el voltaje (V): ");
double voltaje = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la corriente (A): ");
double corriente = Convert.ToDouble(Console.ReadLine());
double potencia = voltaje * corriente;
Console.WriteLine($"\nPotencia Electrica: {potencia:F2} W");

if (potencia <= 120)
{
Console.WriteLine("Estado: CONSUMO NORMAL");
}
else
{
Console.WriteLine("Estado: ADVERTENCIA: CONSUMO ELEVADO");
}

Console.ReadKey();
}
}
}

