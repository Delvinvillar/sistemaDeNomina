using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaDeNomina
{
    public class EmpleadosPorComision : Empleado
    {
        private decimal ventasBrutas;
        private decimal tarifacomision;

        public EmpleadosPorComision(string nombre, string apellido, string nss,
            decimal ventas, decimal tarifa) : base(nombre, apellido, nss)
        {
            ventasBrutas = ventas;
            tarifacomision = tarifa;
        }
        public decimal TarifaComision
        {
            get { return tarifacomision; }
            set
            {
                tarifacomision = (value > 0 && value < 1) ? value : 0;
            }
        }
        public decimal VentasBrutas
        {
            get { return ventasBrutas; } 
            set {ventasBrutas = (value>=0 )? value : 0; }
        }
        public override decimal ingreso()
        {
            return TarifaComision * ventasBrutas;
        }
        public override string ToString()
        {
            return string.Format("{0}: {1} \n {2}: {3:c}\n {4}: {5:F2}",
                "empleados por comision ", base.ToString(), " ventas brutas ",
                VentasBrutas, "tarifa dd comision ", TarifaComision);
        }



    }
}
