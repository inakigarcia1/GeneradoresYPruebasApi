namespace GeneradoresYPruebas.Api.Helpers;

public class DatosCongruencialAditivo
{
    public int M {  get; set; }
    public int Tot {  get; set; }
    public int[] Semillas { get; set; }

    public DatosCongruencialAditivo(int m, int tot, params int[] semillas)
    {
        M = m;
        Tot = tot;
        Semillas = semillas;
    }
}
