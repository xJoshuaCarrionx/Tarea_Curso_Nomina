using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Nomina
{
    public class Deducciones : Empleado
    {
        private decimal _deduccionINSS;
        private decimal _deduccionIR;
        private decimal _deduccionOtros;

        public Deducciones()
        {

        }

        public Deducciones(int numeroEmpleado, string numeroCedula, string numeroINSS, string numeroRUC, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido, DateTime fechaNacimiento, string sexo, string estadoCivil, string direccion, string telefono, string celular, DateTime fechaContratacion, DateTime fechaCierreContrato, decimal salarioOrdinario, bool activo, decimal deduccionINSS, decimal deduccionIR, decimal deduccionOtros)
        {

            base.NumeroEmpleado = numeroEmpleado;
            base.NumeroCedula = numeroCedula;
            base.NumeroINSS = numeroINSS;
            base.NumeroRUC = numeroRUC;
            base.PrimerNombre = primerNombre;
            base.SegundoNombre = segundoNombre;
            base.PrimerApellido = primerApellido;
            base.SegundoApellido = segundoApellido;
            base.FechaNacimiento = fechaNacimiento;
            base.Sexo = sexo;
            base.EstadoCivil = estadoCivil;
            base.Direccion = direccion;
            base.Telefono = telefono;
            base.Celular = celular;
            base.FechaContratacion = fechaContratacion;
            base.FechaCierreContrato = fechaCierreContrato;
            base.SalarioOrdinario = salarioOrdinario;
            base.Activo = activo;

            _deduccionINSS = deduccionINSS;
            _deduccionIR = deduccionIR;
            _deduccionOtros = deduccionOtros;
        }

        public decimal DeduccionINSS
        {
            get { return _deduccionINSS; }
            set { _deduccionINSS = value; }
        }

        public decimal DeduccionIR
        {
            get { return _deduccionIR; }
            set { _deduccionIR = value; }
        }

        public decimal DeduccionOtros
        {
            get { return _deduccionOtros; }
            set { _deduccionOtros = value; }
        }
    }
}

