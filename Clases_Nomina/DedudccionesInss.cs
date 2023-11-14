using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Nomina
{
    public class DedudccionesInss : Deducciones
    {
        private decimal _porcentajeEmpleado;
        private decimal _porcentajeEmpleador;

        public DedudccionesInss()
        {

        }

        public DedudccionesInss(int numeroEmpleado, string numeroCedula, string numeroINSS, string numeroRUC, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string sexo, string estadoCivil, string direccion, string telefono, string celular, DateTime fechaContratacion, DateTime fechaCierreContrato, decimal salarioOrdinario, bool activo, decimal deduccionINSS, decimal deduccionIR, decimal deduccionOtros, decimal porcentajeEmpleado, decimal porcentajeEmpleador)
        {

        }

        public decimal PorcentajeEmpleado { get => _porcentajeEmpleado; set => _porcentajeEmpleado = value; }
        public decimal PorcentajeEmpleador { get => _porcentajeEmpleador; set => _porcentajeEmpleador = value; }
    }
}
