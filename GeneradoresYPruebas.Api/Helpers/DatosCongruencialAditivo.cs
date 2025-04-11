namespace GeneradoresYPruebas.Api.Helpers;

public class DatosCongruencialAditivo
{
    public double M {  get; set; }
    public double Tot {  get; set; }
    public double[] Semillas { get; set; }

    public DatosCongruencialAditivo(double m, double tot, params double[] semillas)
    {
        M = m;
        Tot = tot;
        Semillas = semillas;
    }
}
