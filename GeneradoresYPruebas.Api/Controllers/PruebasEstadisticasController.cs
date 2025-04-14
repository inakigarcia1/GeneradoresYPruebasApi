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
            var (esAleatorio, estadistico) = Frecuencia.EsAleatorio(datosPruebaFrecuencia.X, datosPruebaFrecuencia.Comparador, datosPruebaFrecuencia.ValoresU);
            var response = new
            {
                EsAleatorio = esAleatorio,
                Estadistico = estadistico,
            };
            return Ok(response);
        }
        catch(Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("series")]
    public IActionResult PruebaDeLaSerie([FromBody] DatosPruebaSerie datosPruebaSerie)
    {
        try
        {
            var (esAleatorio, estadistico) = Series.EsAleatorio(datosPruebaSerie.X, datosPruebaSerie.Comparador, datosPruebaSerie.N, datosPruebaSerie.ValoresU);
            var response = new
            {
                EsAleatorio = esAleatorio,
                Estadistico = estadistico,
            };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("ks")]
    public IActionResult PruebaDeKs([FromBody] DatosPruebaKs datosPruebaKs)
    {
        try
        {
            var (esAleatorio, estadistico) = Ks.EsAleatorio(datosPruebaKs.Comparador, datosPruebaKs.ValoresU);
            var response = new
            {
                EsAleatorio = esAleatorio,
                Estadistico = estadistico,
            };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }

    [HttpPost("corrida")]
    public IActionResult PruebaDeCorrida([FromBody] DatosPruebaCorrida datosPruebaCorrida)
    {
        try
        {
            var (esAleatorio, estadistico) = CorridaDeLaMedia.EsAleatorio(datosPruebaCorrida.Comparador, datosPruebaCorrida.ValoresU);
            var response = new
            {
                EsAleatorio = esAleatorio,
                Estadistico = estadistico,
            };
            return Ok(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}
