using GeneradoresYPruebas.Api.Helpers;
using GeneradoresYPruebas.Dominio.Generadores;
using GeneradoresYPruebas.Dominio.ViewModel;
using GeneradoresYPruebas.Generadores;
using Microsoft.AspNetCore.Mvc;

namespace GeneradoresYPruebas.Api.Controllers;

[ApiController]
[Route("aleatorio")]
public class GeneradorDeNumerosController : ControllerBase
{
    [HttpGet("cuadradosMedios")]
    public IActionResult CuadradosMedios(double m, double n, double tot)
    {
        var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(m, n, tot);

        if (numeros.Last() == 0)
            return CrearRespuesta(numeros, mensaje: "No se pueden generar más números.");

        return CrearRespuesta(numeros);
    }

    [HttpGet("lehmer")]
    public IActionResult CalcularLehmer(double m, double t, double k, double tot)
    {
        var numeros = Lehmer.ObtenerNumerosAleatorios(m, t, k, tot);

        if (numeros.Last() < 0)
        {
            numeros.RemoveAt(numeros.Count - 1);
            return CrearRespuesta(numeros, mensaje: "No se pueden generar más números.");
        }

        return CrearRespuesta(numeros);
    }

    [HttpGet("congruencialMixto")]
    public IActionResult CalcularCongruencialMixto(double n, double a, double c, double m, double tot)
    {
        var numeros = CongruencialMixto.ObtenerNumerosAleatorios(n, a, c, m, tot);
        return CrearRespuesta(numeros);
    }

    [HttpGet("congruencialMultiplicativo")]
    public IActionResult CalcularCongruencialMultiplicativo(double n, double m, double a, double tot)
    {
        var numeros = CongruencialMultiplicativo.ObtenerNumerosAleatorios(n, a, m, tot);
        return CrearRespuesta(numeros);
    }

    [HttpPost("congruencialAditivo")]
    public IActionResult CalcularCongruencialAditivo([FromBody] DatosCongruencialAditivo datos)
    {
        var numeros = CongruencialAditivo.ObtenerNumerosAleatorios(datos.M, datos.Tot, datos.Semillas);
        return CrearRespuesta(numeros);
    }

    private IActionResult CrearRespuesta(List<double> numeros, string mensaje = "")
    {
        return Ok(new Respuesta(numeros: numeros, mensaje: mensaje));
    }
}
