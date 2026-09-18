using System;

namespace Ejercicio4
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine();
Console.WriteLine("   EJERCICIO 4: PRUEBA DE CORRIENTE ACTUADOR     ");
Console.WriteLine();
Console.WriteLine("Evaluacion de 8 muestras de corriente electrica.\n");

double sumaCorriente = 0;
int normales = 0;
int sobrecorrientes = 0;
int totalMuestras = 8;

for (int i = 1; i <= totalMuestras; i++)
{
Console.Write($"Ingrese la medicion de corriente #{i} (A): ");
double I = Convert.ToDouble(Console.ReadLine());
sumaCorriente += I;

if (I <= 5)
{
Console.WriteLine(" -> MEDICIÓN NORMAL");
normales++;
}
else
{
Console.WriteLine(" -> SOBRECORRIENTE DETECTADA");
sobrecorrientes++;
}
}

double promedio = sumaCorriente / totalMuestras;

Console.WriteLine("\n RESUMEN ");
Console.WriteLine($"Corriente Promedio: {promedio:F2} A");
Console.WriteLine($"Mediciones normales: {normales}");
Console.WriteLine($"Mediciones con sobrecorriente: {sobrecorrientes}");

if (sobrecorrientes == 0)
{
Console.WriteLine("\nResultado General: ACTUADOR APROBADO");
}
else
{
Console.WriteLine("\nResultado General: EL ACTUADOR REQUIERE REVISIÓN");
}

Console.ReadKey();
}
}
}
