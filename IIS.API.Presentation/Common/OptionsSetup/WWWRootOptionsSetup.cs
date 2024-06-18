using IIS.API.Application.Common.Options;
using Microsoft.Extensions.Options;

namespace IIS.API.Presentation.Common.OptionsSetup;

public class WWWRootOptionsSetup : IConfigureOptions<WWWRootOptions>
{
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IConfiguration _configuration;

    public WWWRootOptionsSetup(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
    {
        _webHostEnvironment = webHostEnvironment;
        _configuration = configuration;
    }

    public void Configure(WWWRootOptions options)
    {
        options.WebRootPath = _webHostEnvironment.WebRootPath;

        // KEEP launchSettings.json and applicatoinSettings.json in SYNC
        options.Host = _configuration["ApplicationUrl"]!;
    }
}
