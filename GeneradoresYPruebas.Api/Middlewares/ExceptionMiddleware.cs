using System.Text.Json;

namespace GeneradoresYPruebas.Api.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger<ExceptionMiddleware> _logger;

    public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context); // Ejecuta el resto del pipeline (controlador y más)
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);

            context.Response.StatusCode = 500;
            context.Response.ContentType = "application/json";
            await context.Response.WriteAsync(JsonSerializer.Serialize(new
            {
                StatusCode = 500,
                Message = ex.Message
            }));
        }
    }
}
