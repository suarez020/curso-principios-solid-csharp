namespace Liskov
{
    public class EmployeeContractor : Employee  // el tipo padre es Employee
    {                                          //los subtipos EmployeeContractor
        public EmployeeContractor(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked, extrahours)
        {
        }
    }
}