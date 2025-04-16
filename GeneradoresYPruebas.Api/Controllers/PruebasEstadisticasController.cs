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
        var (esAleatorio, estadistico) = Promedios.EsAleatorio(datosPruebaPromedio.Comparador, datosPruebaPromedio.ValoresU);
        return CrearRespuesta(esAleatorio, estadistico);
    }

    [HttpPost("frecuencia")]
    public IActionResult PruebaDeFrecuencia([FromBody] DatosPruebaFrecuencia datosPruebaFrecuencia)
    {
        var (esAleatorio, estadistico) = Frecuencia.EsAleatorio(datosPruebaFrecuencia.X, datosPruebaFrecuencia.Comparador, datosPruebaFrecuencia.ValoresU);
        return CrearRespuesta(esAleatorio, estadistico);
    }

    [HttpPost("series")]
    public IActionResult PruebaDeLaSerie([FromBody] DatosPruebaSerie datosPruebaSerie)
    {
        var (esAleatorio, estadistico) = Series.EsAleatorio(datosPruebaSerie.X, datosPruebaSerie.Comparador, datosPruebaSerie.N, datosPruebaSerie.ValoresU);
        return CrearRespuesta(esAleatorio, estadistico);
    }

    [HttpPost("ks")]
    public IActionResult PruebaDeKs([FromBody] DatosPruebaKs datosPruebaKs)
    {
        var (esAleatorio, estadistico) = Ks.EsAleatorio(datosPruebaKs.Comparador, datosPruebaKs.ValoresU);
        return CrearRespuesta(esAleatorio, estadistico);
    }
   

    [HttpPost("corrida")]
    public IActionResult PruebaDeCorrida([FromBody] DatosPruebaCorrida datosPruebaCorrida)
    {
        var (esAleatorio, estadistico) = CorridaDeLaMedia.EsAleatorio(datosPruebaCorrida.Comparador, datosPruebaCorrida.ValoresU);
        return CrearRespuesta(esAleatorio, estadistico);
    }

    private IActionResult CrearRespuesta(bool esAleatorio, double estadistico)
    {
        return Ok(new RespuestaPruebaEstadistica(esAleatorio: esAleatorio, estadistico: estadistico));
    }
}
