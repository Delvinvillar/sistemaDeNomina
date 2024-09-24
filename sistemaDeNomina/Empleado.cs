using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaDeNomina
{
   public abstract  class Empleado
   {
        private string primerNombre;
        private string apellidopaterno;
        private string numeroSeguroSocial;

        public Empleado(string nombre, string apellido, string nss)
        { 
         primerNombre = nombre;
            apellidopaterno= apellido;
            numeroSeguroSocial = nss;
        }
        public string PrimerNombre
        { 
         get { return primerNombre; }
        }
        public string Apellidopaterno
        {
            get { return apellidopaterno; }
        }
        public string NumeroseguroSocial
        {
            get { return numeroSeguroSocial; }
        }
        public override string ToString()
        {
            return string.Format("{0}{1}\n numero de seguro social : {2}",
                primerNombre,apellidopaterno,numeroSeguroSocial);         
        }
        public abstract decimal ingreso();

    }
}
