using System;

namespace prubebaDenomina
{

    internal  class Program
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
        }
    }
}

   