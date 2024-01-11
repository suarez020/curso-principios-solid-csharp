using OpenClose;

//CalculateSalaryMonthly (new List<object>() {
  mostrarSalariomensual  (new List<Empleado>() {// aca tambien resive de tipo empleado                            ya no es un objeto solo es un Empleado
    new EmployeeFullTime("Pepito Pérez", 160),
    new EmployeePartTime("Manuel Lopera", 180),
    new EmpleadoContractor("Arley suarez agudelo", 400),

});

//CALCULAMOS CON EL CONSTRUCTOR VARIOS OBJETOS 
//void CalculateSalaryMonthly(List<object> employees) // aca ya cambiaria lo que se resive ya seria una lista empleado 
  
  void mostrarSalariomensual(List<Empleado> employees) // aca ya cambiaria lo que se resive ya seria una lista empleado 
                                                      //aca resivimos el empleado y haremos la lojica segun el empleado 
{
    foreach (var empleado in employees)//vamos a recorrer el empleado mi clase abstracta 
    {
        //if (employee is EmployeeFullTime) 
        //{
        // Console.WriteLine($"Empleado: {employeeFullTime.Fullname}, Pago: {salary:C1} ");                  // ya no seria necesaria 
           Console.WriteLine($"Empleado: {empleado.Fullname}, Pago: {empleado.CalcularSalarioMensual()} "); // toda la logica para este 
           
        //}
        // else 
        // {
        //     decimal hourValue = 20000M;
        //     EmployeePartTime employeePartTime = ((EmployeePartTime)employee);
        //     decimal salary = hourValue * employeePartTime.HoursWorked;
        //     if (employeePartTime.HoursWorked > 160) {
        //         decimal effortCompensation = 5000M;
        //         int extraDays = employeePartTime.HoursWorked - 160;
        //         salary += effortCompensation * extraDays;
        //     }
        //     Console.WriteLine($"Empleado: {employeePartTime.Fullname}, Pago: {salary:C1} ");
        // }
    } 
}