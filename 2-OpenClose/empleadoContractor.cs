namespace OpenClose
{
//creamos la nueva que hereda de empleado 
    public class EmpleadoContractor : Empleado
    {
        //public string Fullname { get; set; }
        //public int HoursWorked { get; set; }//HORAS TRABAJADAS 

        public EmpleadoContractor(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalcularSalarioMensual()
        {
            decimal hourValue = 900000M;
            decimal salary = hourValue * HoursWorked;
            return salary;
        }
    }
}