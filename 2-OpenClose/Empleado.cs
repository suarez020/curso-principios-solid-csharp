namespace OpenClose
{
    public abstract class Empleado
    {
        public string Fullname { get; set; }

        public int HoursWorked { get; set; }

        public abstract decimal CalcularSalarioMensual();
    }
}

//son clases abstractas osea que la implementacion se va a realizar desde las clases que implementen esta interfaz