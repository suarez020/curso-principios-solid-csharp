namespace OpenClose
{
    public class EmployeePartTime : Empleado
    {
        // public string Fullname { get; set; }
        // public int HoursWorked { get; set; }// MEDIO TIEMPO  HORAS TRABAJADAS   

        public EmployeePartTime(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }

        public override decimal CalcularSalarioMensual()
        {
            //      decimal hourValue = 20000M;
            //      EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
            //      decimal salary = hourValue * employeePartTime.HoursWorked;
            //      if (employeePartTime.HoursWorked > 160) {
            //          decimal effortCompensation = 5000M;
            //          int extraDays = employeePartTime.HoursWorked - 160;
            //          salary += effortCompensation * extraDays;
            // }salary;
            decimal hourValue = 20000M;
            //EmployeeFullTime employeeFullTime = ((EmployeeFullTime)employee); ya no se necesita este objeto si no los valores de la propiedad
            //decimal salary = hourValue * employeeFullTime.HoursWorked;

            decimal salary = hourValue * HoursWorked;

            return salary;
            //Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");
            //este console si lo voy a tirar desde alla 
        }
    }
}