using System;

namespace Ejercicio3
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine();
Console.WriteLine("  EJERCICIO 3: SIMULACION DE CARGA DE BATERIA    ");
Console.WriteLine();
Console.WriteLine("Simula la carga hasta alcanzar o superar los 12.6 V.\n");

Console.Write("Ingrese el voltaje inicial de la bateria (V): ");
double vActual = Convert.ToDouble(Console.ReadLine());

Console.Write("Ingrese el incremento de voltaje por ciclo (V): ");
double incremento = Convert.ToDouble(Console.ReadLine());

if (incremento <= 0)
{
Console.WriteLine("\n[ERROR]: El incremento introducido debe ser mayor a 0 V. Simulacion abortada.");
}
else
{
int ciclo = 0;
Console.WriteLine("\n--- Inicio del Proceso de Carga ---");

while (vActual < 12.6)
{
ciclo++;
vActual += incremento;
Console.WriteLine($"Ciclo {ciclo}: Voltaje actual = {vActual:F2} V");
}

Console.WriteLine("\n¡Carga de bateria completada exitosamente!");
}

Console.ReadKey();
}
}
}
