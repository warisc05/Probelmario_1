using System;

namespace Ejercicio5
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine();
Console.WriteLine("   EJERCICIO 5: ANALISIS DE VIBRACION EN MOTORES ");
Console.WriteLine();
Console.WriteLine("Evaluacion de niveles de vibracion (mm/s).\n");

int totalMotores = 0;
int motoresOK = 0;
int motoresMantenimiento = 0;
string continuar = "s";

while (continuar.ToLower() == "s")
{
totalMotores++;
Console.WriteLine($"\n--- EVALUACIÓN MOTOR #{totalMotores} ---");
Console.Write("Ingrese el nombre o ID del motor: ");
string nombre = Console.ReadLine();

double sumaVibracion = 0;
int medicionesPorMotor = 4;

for (int i = 1; i <= medicionesPorMotor; i++)
{
Console.Write($"  Ingrese medicion de vibracion #{i} (mm/s): ");
double vib = Convert.ToDouble(Console.ReadLine());
sumaVibracion += vib;
}

double promVib = sumaVibracion / medicionesPorMotor;
Console.WriteLine($"\n  -> Vibracion promedio para '{nombre}': {promVib:F2} mm/s");

if (promVib <= 4.5)
{
Console.WriteLine("  -> Estado: FUNCIONAMIENTO NORMAL DEL MOTOR");
motoresOK++;
}
else
{
Console.WriteLine("  -> Estado: EL MOTOR REQUIERE MANTENIMIENTO");
motoresMantenimiento++;
}

Console.Write("\n¿Desea analizar otro motor? (s/n): ");
continuar = Console.ReadLine();
}

Console.WriteLine("\n RESUMEN GENERAL ");
Console.WriteLine($"Total de motores evaluados: {totalMotores}");
Console.WriteLine($"Cantidad de motores con funcionamiento normal: {motoresOK}");
Console.WriteLine($"Cantidad de motores que requieren mantenimiento: {motoresMantenimiento}");

Console.ReadKey();
}
}
}