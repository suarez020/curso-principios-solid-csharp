namespace Liskov
{
    public class EmployeeFullTime : Employee //subtipo ·2 los cuales heredan de contractor 
    {
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked, extrahours)
        {
        }
    }
}