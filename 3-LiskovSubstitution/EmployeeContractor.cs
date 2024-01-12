namespace Liskov
{
    public class EmployeeContractor : Employee  // el tipo padre es Employee
    {                                          //los subtipos EmployeeContractor
        public EmployeeContractor(string fullname, int hoursWorked) : base(fullname, hoursWorked)
        {
              
        }
        /*
         public virtual decimal CalculateSalary ()           ///puede que cresca y hayan otro tipo de contrato 
        {                                                   /// cada clase lo deberia hacer por separado 
            decimal hourValue = 40;
            return hourValue * (HoursWorked );
        }
        */
        
        
        public override decimal CalculateSalary()
        {
                                                                               /// nos dice que se debe implementar override de la class abstract   
                                                                              ///puede que cresca y hayan otro tipo de contrato 
                                                                             /// cada clase lo deberia hacer por separado 
             decimal hourValue = 40;                                        /// solo lo implementamos en full time
             return hourValue * (HoursWorked);
         
        }
    }
}