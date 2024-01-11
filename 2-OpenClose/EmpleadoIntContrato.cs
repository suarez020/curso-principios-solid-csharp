namespace OpenClose
{
    public interface IEmpleadoContrato 
    {
        public string Fullname { get; set; }
        public abstract decimal CalcularSalarioInter();
        
    }
}