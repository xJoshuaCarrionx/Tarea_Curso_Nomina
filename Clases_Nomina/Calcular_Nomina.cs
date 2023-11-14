namespace Clases_Nomina
{
    public class Calcular_Nomina
    {
        public decimal CalcularSalarioNeto(Deducciones deducciones)
        {
            // Calcula el total de deducciones
            decimal totalDeducciones = deducciones.DeduccionINSS + deducciones.DeduccionIR + deducciones.DeduccionOtros;

            // Calcula el salario neto
            decimal salarioNeto = deducciones.SalarioOrdinario - totalDeducciones;

            return salarioNeto;
        }

        public decimal CalcularDeduccionINSS(DedudccionesInss deducciones)
        {
            // Calcula la deducción del empleado
            decimal deduccionEmpleado = deducciones.SalarioOrdinario * deducciones.PorcentajeEmpleado / 100;

            // Calcula la deducción del empleador
            decimal deduccionEmpleador = deducciones.SalarioOrdinario * deducciones.PorcentajeEmpleador / 100;

            // Calcula la deducción total del INSS
            decimal deduccionINSS = deduccionEmpleado + deduccionEmpleador;

            return deduccionINSS;
        }
    }
}