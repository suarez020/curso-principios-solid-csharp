using Liskov;

CalculateSalaryMonthly(new List<Employee>() {
    new EmployeeFullTime("Pepito Pérez", 160, 10),
    new EmployeeContractor("Manuel Lopera", 180)            ///la idea es ya solo mandarle dos parametros no tres como antes
});

void CalculateSalaryMonthly(List<Employee> employees) 
{
    foreach (var item in employees)
    {
    
       // decimal salary = item.CalculateSalary((item is EmployeeFullTime));  /// ya no se debe enviar ya que son los subtipos los que deben implementar eso 
         decimal salary = item.CalculateSalary();
        Console.WriteLine($"The {item.Fullname}'s salary is {salary}");
      
            ///En este proceso la idea es no pasar un cero en Horas la idea es que cada clase se encargue de su logica 
           ///
          ///
         ///
    }
}









 //!__________________________________________________________________________
    //*crt + k comentar  
    //*ctr + U descomentar
    //LINEA DE COMENTARIO
    /*
    BLOQUE DE COMMENT 
    */
    //todo:
    //FIXME:
    /**
      * Esta función realiza algo. MUESTRA CON COLOR 
      * @param {string} nombre - El nombre a procesar.
      * @returns {string} - El resultado procesado.
      */
  //!__________________________________________________________________________

/*!

"better-comments.tags": [
        {
            "tag": "!",
            "color": "#FF2D00", ROJO 
            "strikethrough": false,
            "underline": false,
            "backgroundColor": "transparent",
            "bold": false,
            "italic": false
        },
        {
            "tag": "?",
            "color": "#3498DB", AZUL 
            "strikethrough": false,
            "underline": false,
            "backgroundColor": "transparent",
            "bold": false,
            "italic": false
        },
        {
            "tag": "//",
            "color": "#474747",  BLANCO SUBRRADO
            "strikethrough": true,
            "underline": false,
            "backgroundColor": "transparent",
            "bold": false,
            "italic": false
        },
        {
            "tag": "todo",
            "color": "#FF8C00",  NARANJA 
            "strikethrough": false,
            "underline": false,
            "backgroundColor": "transparent",
            "bold": false,
            "italic": false
        },
        {
            "tag": "*",
            "color": "#98C379",       VERDE OSCURO 
            "strikethrough": false,
            "underline": false,
            "backgroundColor": "transparent",
            "bold": false,
            "italic": false
        }
    ]

*/

