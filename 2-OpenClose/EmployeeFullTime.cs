namespace OpenClose
{
    public class EmployeeFullTime : Empleado
    {
        //public string Fullname { get; set; }
        //public int HoursWorked { get; set; }//HORAS TRABAJADAS 

        public EmployeeFullTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalcularSalarioMensual()
        {
            decimal hourValue = 30000M;
            //EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee); ya no se necesita este objeto si no los valores de la propiedad
            //decimal salary = hourValue * employeeFullTime.HoursWorked;
            
            decimal salary = hourValue * HoursWorked;
            
            return salary;
            //Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
            //este console si lo voy a tirar desde alla 
        }
    }
}