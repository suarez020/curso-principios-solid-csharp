using System;

public class Fruta
{
    public string Nombre { get; set; }

    public virtual string ObtenerColor()
    {
        return "Desconocido";
    }
}