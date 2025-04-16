namespace GeneradoresYPruebas.Api.Helpers;

public class RespuestaPruebaEstadistica
{
    public bool EsAleatorio { get; set; }
    public double Estadistico { get; set; }

    public RespuestaPruebaEstadistica(bool esAleatorio, double estadistico)
    {
        EsAleatorio = esAleatorio;
        Estadistico = estadistico;
    }
}
