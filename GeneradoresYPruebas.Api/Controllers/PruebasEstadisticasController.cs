using GeneradoresYPruebas.Api.Helpers;
using GeneradoresYPruebas.Dominio.Generadores;
using GeneradoresYPruebas.Dominio.Pruebas;
using GeneradoresYPruebas.Dominio.ViewModel;
using GeneradoresYPruebas.Generadores;
using Microsoft.AspNetCore.Mvc;

namespace GeneradoresYPruebas.Api.Controllers;

[ApiController]
[Route("prueba")]
public class PruebasEstadisticasController : ControllerBase
{
    [HttpPost("promedios")]
    public IActionResult PruebaDePromedios([FromBody] DatosPruebaPromedio datosPruebaPromedio)
    {
        try
        {
            var resultado = Promedios.EsAleatorio(datosPruebaPromedio.Comparador, datosPruebaPromedio.ValoresU);
            var response = new
            {
                EsAleatorio = resultado.esAleatorio,
                Estadistico = resultado.estadistico,
            };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("frecuencia")]
    public IActionResult PruebaDeFrecuencia([FromBody] DatosPruebaFrecuencia datosPruebaFrecuencia)
    {
        try
        {
            var resultado = Frecuencia.EsAleatorio(datosPruebaFrecuencia.X, datosPruebaFrecuencia.Comparador, datosPruebaFrecuencia.ValoresU);
            var response = new
            {
                EsAleatorio = resultado.esAleatorio,
                Estadistico = resultado.estadistico,
            };
            return Ok(response);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
