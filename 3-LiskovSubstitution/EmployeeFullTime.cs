namespace Liskov
{
    public class EmployeeFullTime : Employee //subtipo ·2 los cuales heredan de contractor 
    {
        public int ExtraHours {get;set;}
        public EmployeeFullTime(string fullname, int hoursWorked, int extrahours) : base(fullname, hoursWorked, extrahours)
        {
          //CalculateSalary();
        }
                                                                  //* nos dice que se debe implementar override de la class abstract   
        public override decimal CalculateSalary ()               //* puede que cresca y hayan otro tipo de contrato 
         {                                                      //* cada clase lo deberia hacer por separado 
             decimal hourValue = 50;                           //* solo lo implementamos en full time
             return hourValue * (HoursWorked + ExtraHours);
         }
    }
}   






