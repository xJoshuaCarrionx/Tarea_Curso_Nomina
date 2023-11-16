using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Nomina 
{
    public class Empleado
    {
        private int _numeroEmpleado;
        private string _numeroCedula;
        private string _numeroINSS;
        private string _numeroRUC;
        private string _primerNombre;
        private string _segundoNombre;
        private string _primerApellido;
        private string _segundoApellido;
        private DateTime _fechaNacimiento;
        private string _sexo;
        private string _estadoCivil;
        private string _direccion;
        private string _telefono;
        private string _celular;
        private DateTime _fechaContratacion;
        private DateTime _fechaCierreContrato;
        private decimal _salarioOrdinario;
        private bool _activo;
        private int _salarioporhora;
        private int _horastrabajadas;
        private int HHE;

        public Empleado()
        {

        }

        public Empleado(int numeroEmpleado, string numeroCedula, string numeroINSS, string numeroRUC, string primerNombre, string segundoNombre, string primerApellido, string segundoApellido,
            DateTime fechaNacimiento, string sexo, string estadoCivil, string direccion, string telefono, string celular, DateTime fechaContratacion, DateTime fechaCierreContrato, decimal salarioOrdinario,
            bool activo, int salarioporhora, int horastrabajadas, int HHE)
        {

            _numeroEmpleado = numeroEmpleado;
            _numeroCedula = numeroCedula;
            _numeroINSS = numeroINSS;
            _numeroRUC = numeroRUC;
            _primerNombre = primerNombre;
            _segundoNombre = segundoNombre;
            _primerApellido = primerApellido;
            _segundoApellido = segundoApellido;
            _fechaNacimiento = fechaNacimiento;
            _sexo = sexo;
            EstadoCivil = estadoCivil;
            Direccion = direccion;
            Telefono = telefono;
            Celular = celular;
            FechaContratacion = fechaContratacion;
            FechaCierreContrato = fechaCierreContrato;
            SalarioOrdinario = salarioOrdinario;
            Activo = activo;
            _salarioporhora = salarioporhora;
            _horastrabajadas = horastrabajadas;
            this.HHE = HHE;
        }

        public int NumeroEmpleado
        {
            get { return _numeroEmpleado; }
            set { _numeroEmpleado = value; }
        }

        public string NumeroCedula
        {
            get { return _numeroCedula; }
            set { _numeroCedula = value; }
        }

        public string NumeroINSS
        {
            get { return _numeroINSS; }
            set { _numeroINSS = value; }
        }

        public string NumeroRUC
        {
            get { return _numeroRUC; }
            set { _numeroRUC = value; }
        }
        public int HorasExtras
        {
            get => HHE;
            set => HHE = value;
        }

        public string PrimerNombre
        {
            get { return _primerNombre; }
            set { _primerNombre = value; }
        }

        public string SegundoNombre
        {
            get { return _segundoNombre; }
            set { _segundoNombre = value; }
        }

        public string PrimerApellido
        {
            get { return _primerApellido; }
            set { _primerApellido = value; }
        }

        public string SegundoApellido
        {
            get { return _segundoApellido; }
            set { _segundoApellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }

        public string Sexo
        {
            get { return _sexo; }
            set { _sexo = value; }
        }

        public string EstadoCivil
        {
            get => _estadoCivil;
            set => _estadoCivil = value;
        }
        public string Direccion
        {
            get => _direccion;
            set => _direccion = value;
        }
        public string Telefono
        {
            get => _telefono;
            set => _telefono = value;
        }
        public string Celular
        {
            get => _celular;
            set => _celular = value;
        }
        public DateTime FechaContratacion
        {
            get => _fechaContratacion;
            set => _fechaContratacion = value;
        }
        public DateTime FechaCierreContrato
        {
            get => _fechaCierreContrato;
            set => _fechaCierreContrato = value;
        }
        public decimal SalarioOrdinario
        {
            get => _salarioOrdinario;
            set => _salarioOrdinario = value;
        }
        public bool Activo
        {
            get => _activo;
            set => _activo = value;
        }
        public int Salarioporhora
        {
            get => _salarioporhora;
            set => _salarioporhora = value;
        }
        public int Horastrabajadas
        {
            get => _horastrabajadas;
            set => _horastrabajadas = value;
        }
    }
}

