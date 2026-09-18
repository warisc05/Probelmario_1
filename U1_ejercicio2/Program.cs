using System;

namespace Ejercicio2
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine();
Console.WriteLine("   EJERCICIO 2: PROMEDIO DE TEMPERATURA MOTOR    ");
Console.WriteLine();
Console.WriteLine("Registra 10 lecturas de temperatura y evalua el promedio.\n");

double suma = 0;
int totalMediciones = 10;

for (int i = 1; i <= totalMediciones; i++)
{
Console.Write($"Ingrese la medicion de temperatura #{i} (°C): ");
double temp = Convert.ToDouble(Console.ReadLine());
suma += temp;
}

double promedio = suma / totalMediciones;

Console.WriteLine($"\nTemperatura promedio: {promedio:F2} °C");

if (promedio <= 70)
{
Console.WriteLine("Estado: TEMPERATURA NORMAL");
}
else
{
Console.WriteLine("Estado: ALERTA DE TEMPERATURA");
}

Console.ReadKey();
}
}
}
