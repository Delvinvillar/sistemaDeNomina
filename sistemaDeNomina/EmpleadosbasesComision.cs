using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaDeNomina
{
    public  class EmpleadosbasesComision:EmpleadosPorComision
    {
        private decimal salarioBases;

        public EmpleadosbasesComision(string nombre, string apellido, string nss,
            decimal ventas, decimal tarifa, decimal salario) : base(nombre, apellido, nss, ventas, tarifa)
        {
         salarioBases = salario;

        }
        public decimal SalarioBases
        {
            get { return salarioBases; }
            set { salarioBases = (value >= 0) ? value : 0; }
        }
        public override decimal ingreso()
        {
            return SalarioBases + base .ingreso();
        }
        public override string ToString()
        {


            return string.Format("{0} {1}; {2}: {3:c}", "salario base +", base.ToString(), "salario base ", SalarioBases);
                       
        }
    }
}
