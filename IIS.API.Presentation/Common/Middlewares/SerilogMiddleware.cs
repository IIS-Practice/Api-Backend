using Serilog;

namespace IIS.API.Presentation.Common.Middlewares;

public class SerilogMiddleware
{
    private readonly RequestDelegate _next;

    public SerilogMiddleware(RequestDelegate next)
    {
        _next = next ?? throw new ArgumentNullException("Request delegate is null");
    }

    public async Task InvokeAsync(HttpContext context)
    {
        try
        {
            await _next(context);
            
            if (context.Response.StatusCode >= 400 && context.Response.StatusCode < 500)
                WarningHandle(context.Request, context.Response);
        }
        catch (Exception ex)
        {
            ErrorHandle(context.Request, context.Response, ex);
        }
    }

    private static void WarningHandle(HttpRequest request, HttpResponse response)
    {
        var method = request.Method;
        var requestPath = request.Path + request.Query;
        var responseCode = response.StatusCode;
        
        Log.Warning("HTTP {Method} {RequestPath} responsed {ResponseCode}", method, requestPath, responseCode);
    }

    private static void ErrorHandle(HttpRequest request, HttpResponse response, Exception ex)
    {
        var method = request.Method;
        var requestPath = request.Path + String.Join('/', request.Query);
        var responseCode = response.StatusCode;

        Log.Error("HTTP {Method} {RequestPath} responsed {ResponseCode} with error: {ExMessage}", method, requestPath, responseCode, ex);
    }
}
