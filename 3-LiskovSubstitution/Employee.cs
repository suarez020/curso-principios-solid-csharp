namespace Liskov
{// tipo padre la clase principal tiene una que contractor no lo esta utilizando 
    public abstract class Employee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }
        
        //public int ExtraHours {get;set;}                                             /// esto solo lo usa Una Clase la vamos a eliminar ya que no debe estar en todas las clases

        public  Employee(string fullname, int hoursWorked)
        {
            Fullname = fullname;
            HoursWorked = hoursWorked;
        }  
                public  Employee(string fullname, int hoursWorked, int ExtraHours) ///ESTA SOBRA YA QUE ES RESPONSABILIDAD DE CADA QUIEN 
        {                                                                         /// la dejare por ahora pero no se implementa...
            Fullname = fullname; 
            HoursWorked = hoursWorked;
        }  
        
         public abstract decimal CalculateSalary ();                           /// este metodoo sera abstractes adoptado

        /*
        public virtual decimal CalculateSalary (bool IsFullTime)//puede que cresca y hayan otro tipo de contrato 
         {                                                      // cada clase lo deberia hacer por separado 
             decimal hourValue = IsFullTime ? 50 : 40;
             return hourValue * (HoursWorked + ExtraHours);
         }
        */ 
    }
}


 // el texto dice solo el empleado fulltime tiene derecho a horas extras 
// este solo estara en full time.






