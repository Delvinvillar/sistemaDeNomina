using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaDeNomina
{
    public  class EmpleadoAsalariado:Empleado
    {
        private decimal salarioSemanal;

        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salario) : base (nombre,apellido,nss)
            
        {
         salarioSemanal = salario;
        }
        public decimal salarioSemanal1
        {
            get { return salarioSemanal; }
            set { salarioSemanal = ((value >= 0) ? value : 0); }
        }
        public override decimal ingreso ()
        {
            return salarioSemanal;
        }
        public override string ToString()
        {
            return string.Format("empleado a salariado :{0} \n {1}: {2:c}", base.ToString(),
                " salario semanal ", salarioSemanal1);
        }
    }
}
