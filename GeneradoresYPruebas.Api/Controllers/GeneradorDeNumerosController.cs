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
    public string Mensaje {  get; set; } = string.Empty;

    [HttpGet("cuadradosMedios")]
    public IActionResult CuadradosMedios(int m, int n, int tot)
    {
        var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(m, n, tot);
        Mensaje = numeros.Last() == 0 ? "No se pueden generar más números." : "";
        return Ok(new MensajeCuadradoMedio(
            mensaje: Mensaje,
            numeros: numeros));
    }

    [HttpGet("lehmer")]
    public IActionResult CalcularLehmer(int m, int t, int k, int tot)
    {
        var numeros = Lehmer.ObtenerNumerosAleatorios(m, t, k, tot);
        return Ok(new MensajeCuadradoMedio(
            mensaje: Mensaje,
            numeros: numeros));
    }

    [HttpGet("congruencialMixto")]
    public IActionResult CalcularCongruencialMixto(double n, double a, double c, double m, int tot)
    {
        var numeros = CongruencialMixto.ObtenerNumerosAleatorios(n, a, c, m, tot);
        return Ok(new MensajeCuadradoMedio(
            mensaje: Mensaje,
            numeros: numeros));
    }

    [HttpGet("congruencialMultiplicativo")]
    public IActionResult CalcularCongruencialMultiplicativo(int n, int m, int a, int tot)
    {
        var numeros = CongruencialMultiplicativo.ObtenerNumerosAleatorios(n, a, m, tot);
        return Ok(new MensajeCuadradoMedio(
            mensaje: Mensaje,
            numeros: numeros));
    }

    [HttpPost("congruencialAditivo")]
    public IActionResult CalcularCongruencialMultiplicativo([FromBody] DatosCongruencialAditivo datos)
    {
        var numeros = ConguencialAditivo.ObtenerNumerosAleatorios(datos.M, datos.Tot, datos.Semillas);
        return Ok(new MensajeCuadradoMedio(
            mensaje: Mensaje,
            numeros: numeros));
    }
}
