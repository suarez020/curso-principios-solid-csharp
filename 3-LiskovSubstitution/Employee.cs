namespace Liskov
{
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        public int ExtraHours {get;set;}

        public  Employee(string fullname, int hoursWorked, int ExtraHours)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  

        public virtual decimal CalculateSalary (bool IsFullTime)//puede que cresca y hayan otro tipo de contrato 
        {                                                      // cada clase lo deberia hacer por separado 
            decimal hourValue = IsFullTime ? 50 : 40;
            return hourValue * (HoursWorked + ExtraHours);
        } 
    }
}

// el texto dice solo el empleado fulltime tiene derecho a horas extras 