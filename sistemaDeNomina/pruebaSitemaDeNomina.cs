using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaDeNomina
{
    public class pruebaSitemaDeNomina
    {
        static void Main(string[] args)
        {
           EmpleadoAsalariado EmpleadoAsalariado = new EmpleadoAsalariado(" delvin", "villar",
            "111-11-111", 800.00m);
        EmpleadosPorHoras EmpleadosPorHoras = new EmpleadosPorHoras("nicol", "sierra", "222-22-222", 16.75m, 40.00m);
        EmpleadosPorComision EmpleadosPorComision = new EmpleadosPorComision("junior ",
            "jimenez", "333-33-333", 10000.0m, 0.6m);
        EmpleadosbasesComision EmpleadosbasesComision = new EmpleadosbasesComision("melvin",
            "arroyo", "444-44-444", 5000.0m, 0.4m, 300.00m);
            Console.WriteLine("empleados procesado en forma individual:\n");
            Console.WriteLine("{0}\n:{1}:{2:c}\n",EmpleadoAsalariado,"ingresos ",
                EmpleadoAsalariado.ingreso());
            Console.WriteLine("{0}\n:{1}:{2:c}\n",EmpleadosPorHoras,"ingresos",EmpleadosPorHoras.ingreso());
            Console.WriteLine("{0}\n:{1}:{2:c}\n", EmpleadosPorComision,"ingreso",
                EmpleadosPorComision.ingreso());
            Console.WriteLine("{0}\n:{1}:{2:c}\n",EmpleadosbasesComision,"ingreso",
                EmpleadosbasesComision.ingreso());
            Empleado[] empleados = new Empleado[4];
            empleados[0] = EmpleadoAsalariado;
            empleados[1]= EmpleadosPorHoras;
            empleados[2] = EmpleadosPorComision;
            empleados[3] = EmpleadosbasesComision;
            Console.WriteLine("empleados procesado en forma de polimorfica :\n");
            foreach (Empleado empleadoActual in empleados)
            {
                Console.WriteLine(empleadoActual);
                if (empleadoActual is EmpleadosbasesComision)
                {
                 EmpleadosbasesComision empleado= (EmpleadosbasesComision) empleadoActual;
                    empleado.SalarioBases *= 1.1m;
                    Console.WriteLine("nuevo salariado base con ingrementos del 10%: {0:c}",
                        empleado.SalarioBases);

                }
                Console.WriteLine("ingresos {0:c}",empleadoActual.ingreso());
            }
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("empleado {0} es un{1}", i,
                    empleados[i].GetType());
            }
        }


    }
}
  
     