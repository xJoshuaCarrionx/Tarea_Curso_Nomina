namespace Clases_Nomina
{
    public class Calcular_Nomina : Empleado
    {
        public decimal CalcularSalario(Empleado empleado)
        {
            decimal salario = empleado.Salarioporhora * empleado.Horastrabajadas;

            return salario;
        }
        public decimal CalcularSalarioBruto(Empleado empleado)
        {
            decimal salarioBruto = (empleado.Salarioporhora * empleado.Horastrabajadas) + (empleado.HorasExtras * 1.5M *empleado.Salarioporhora);
            return salarioBruto;
        }
        public decimal CalcularSalarioMensual(Empleado empleado)
        {
            decimal salarioMensual = (empleado.Salarioporhora * empleado.Horastrabajadas) + (empleado.HorasExtras * 1.5M * empleado.Salarioporhora) * 28;
            return salarioMensual;
        }
        public decimal CalcularSalarioAnual(Empleado empleado)
        {
            decimal salarioAnual = CalcularSalarioMensual(empleado) * 12;
            return salarioAnual;
        }
        public decimal DeduccionDeIR(Empleado empleado)
        {
            decimal salarioAnual = CalcularSalarioAnual(empleado) ;
            decimal deduccionIR = 0;
            if (salarioAnual <= 100000)
            {
                deduccionIR = 0;
            }
            else if (salarioAnual <= 200000)
            {
                deduccionIR = ((salarioAnual - 100000) * 0.15M)/12;
            }
            else if (salarioAnual <= 350000)
            {
                deduccionIR = (((salarioAnual - 200000) + 15000) * 0.15M)/12;
            }
            else if (salarioAnual <= 500000)
            {
                deduccionIR = (((salarioAnual - 350000) + 45000) * 0.25M)/12;
            }
            else if (salarioAnual > 500000)
            {
                deduccionIR = (((salarioAnual - 500000) + 82500) * 0.30M) / 12;
            }
            return deduccionIR;
        }
        public decimal DeduccionInss(Empleado empleado)
        {
            decimal salario = CalcularSalarioBruto(empleado);
            decimal deduccionInss = 0;
            if (salario <= 10000)
            {
                deduccionInss = salario * 0.06M;
            }
            else if (salario <= 20000)
            {
                deduccionInss = salario * 0.08M;
            }
            else if (salario <= 30000)
            {
                deduccionInss = salario * 0.10M;
            }
            else if (salario <= 50000)
            {
                deduccionInss = salario * 0.12M;
            }
            else if (salario > 50000)
            {
                deduccionInss = salario * 0.15M;
            }
            return deduccionInss;
        }
        public decimal SalarioNeto(Empleado empleado)
        {
            decimal salarioNeto = CalcularSalarioBruto(empleado) - DeduccionInss(empleado) - DeduccionDeIR(empleado);
            return salarioNeto;
        }  
    }
}