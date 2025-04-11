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
        try
        {
            var numeros = ParteCentralDelCuadrado.ObtenerNumerosAleatorios(m, n, tot);
            if(numeros.Last() == 0)
                return Ok(new Respuesta(mensaje: "No se pueden generar más números.", numeros: numeros));

            return Ok(new Respuesta(numeros: numeros));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }

    }

    [HttpGet("lehmer")]
    public IActionResult CalcularLehmer(double m, double t, double k, double tot)
    {
        try
        {
            var numeros = Lehmer.ObtenerNumerosAleatorios(m, t, k, tot);

            if (numeros.Last() < 0)
            {
                numeros.RemoveAt(numeros.Count - 1);
                return Ok(new Respuesta(mensaje: "No se pueden generar más números.", numeros: numeros));
            }

            return Ok(new Respuesta(numeros: numeros));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("congruencialMixto")]
    public IActionResult CalcularCongruencialMixto(double n, double a, double c, double m, double tot)
    {
        try
        {
            var numeros = CongruencialMixto.ObtenerNumerosAleatorios(n, a, c, m, tot);
            return Ok(new Respuesta(numeros: numeros));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpGet("congruencialMultiplicativo")]
    public IActionResult CalcularCongruencialMultiplicativo(double n, double m, double a, double tot)
    {
        try
        {
            var numeros = CongruencialMultiplicativo.ObtenerNumerosAleatorios(n, a, m, tot);
            return Ok(new Respuesta(numeros: numeros));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("congruencialAditivo")]
    public IActionResult CalcularCongruencialMultiplicativo([FromBody] DatosCongruencialAditivo datos)
    {
        try
        {
            var numeros = CongruencialAditivo.ObtenerNumerosAleatorios(datos.M, datos.Tot, datos.Semillas);
            return Ok(new Respuesta(numeros: numeros));
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
