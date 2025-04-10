namespace GeneradoresYPruebas.Api.Helpers;

public class RespuestaPruebaEstadistica
{
    public bool EsAleatorio { get; set; }
    public double Comparador { get; set; }

    public RespuestaPruebaEstadistica(bool esAleatorio, double comparador)
    {
        EsAleatorio = esAleatorio;
        Comparador = comparador;
    }
}
