namespace OpenClose
{
//creamos la nueva que hereda de empleado 
    public class trabajandoConMiInterfazCreada : IEmpleadoContrato
    {
        public string Fullname  { get; set; } = "arley suarez"; 

        public decimal CalcularSalarioInter()
        {
            decimal hourValue = 5000000;
            decimal salary = hourValue ;
            return salary;
        }
    }
}


