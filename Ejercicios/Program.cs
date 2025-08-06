using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        // Declaración de variables
        double costoHora, horasTrabajadas, totalDevengado;

        // Solicitar datos al usuario
        Console.Write("Ingrese el costo por hora trabajada: ");
        costoHora = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese la cantidad de horas trabajadas: ");
        horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        // Calcular el salario semanal
        totalDevengado = costoHora * horasTrabajadas;

        // Mostrar el resultado
        Console.WriteLine("\nEl salario semanal del trabajador es: L. " + totalDevengado);

        // Pausa para que no se cierre la consola automáticamente
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }
}
