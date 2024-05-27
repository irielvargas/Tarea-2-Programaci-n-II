using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AumentoSalarial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aumentos salariales
            Console.Write("Ingrese número de cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Ingrese nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese tipo de empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());
            if (tipoEmpleado < 1 || tipoEmpleado > 3)
            {
                Console.WriteLine("Tipo de empleado inválido.");
                return;
            }
            Console.Write("Ingrese cantidad de horas laboradas: ");
            double horasLaboradas = double.Parse(Console.ReadLine());

            Console.Write("Ingrese precio por hora: ");
            double precioPorHora = double.Parse(Console.ReadLine());

            double salarioOrdinario = horasLaboradas * precioPorHora;
            double aumento = 0;

            if (tipoEmpleado == 1)
            {
                aumento = salarioOrdinario * 0.15;
            }
            else if (tipoEmpleado == 2)
            {
                aumento = salarioOrdinario * 0.10;
            }
            else if (tipoEmpleado == 3)
            {
                aumento = salarioOrdinario * 0.05;
            }

            double salarioBruto = salarioOrdinario + aumento;
            double deduccionCCSS = salarioBruto * 0.0917;
            double salarioNeto = salarioBruto - deduccionCCSS;

            Console.WriteLine("\nDatos del empleado:");
            Console.WriteLine($"Cédula: {cedula}");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
            Console.WriteLine($"Salario por Hora: {precioPorHora}");
            Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
            Console.WriteLine($"Salario Ordinario: {salarioOrdinario}");
            Console.WriteLine($"Aumento: {aumento}");
            Console.WriteLine($"Salario Bruto: {salarioBruto}");
            Console.WriteLine($"Deducción CCSS: {deduccionCCSS}");
            Console.WriteLine($"Salario Neto: {salarioNeto}");
        }

    }
}

