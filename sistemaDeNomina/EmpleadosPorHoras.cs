using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace sistemaDeNomina
{
   public class EmpleadosPorHoras : Empleado
    {
        private decimal sueldo;
        private decimal horas;
        public EmpleadosPorHoras(string nombre, string apellido, string nss, decimal sueldoPorHoras, decimal horasTranbajadas) : base(nombre, apellido, nss)
        {
            sueldo = sueldoPorHoras;
            horas = horasTranbajadas;

        }
        public decimal Sueldo
        {
            get { return sueldo; }
            set { sueldo = (value >= 0) ? value : 0; }
        }
        public decimal Horas
        {
            get { return horas; }
            set { horas = ((value >= 0) && (value <= 168)) ? value : 0; }

        }
        public override decimal ingreso()
        {
            if (Horas <= 40)
            {
                return sueldo * horas;

            }
            else
            {
                return (40 * sueldo) + ((horas - 40) * sueldo * 1.5m);
            }
        }
        public override string ToString ()
        {
            return string.Format("empleado por horas : {0}:\n {1}: {2:c} {3}: {4:F2}",
                base.ToString(), "sueldo por horas ", Sueldo, "horas trabajada ", Horas);
        }
     }
}
