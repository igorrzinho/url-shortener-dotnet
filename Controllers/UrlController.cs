using Microsoft.AspNetCore.Mvc;
using url_shortener_dotnet.Services;

namespace url_shortener_dotnet.Controllers;

[ApiController]
[Route("url")]
public class UrlController : ControllerBase
{

    private readonly UrlService _service;

    public UrlController(UrlService service)
    {
        _service = service;
    }

    [HttpGet("helth")]
    public string Health()
    {
        return "Hello World!";
    }

    [HttpPost]
    public object Create()
    {
        return "Hello World!";
    }

    [HttpGet("{id}")]
    public object Details()
    {
        return "Hello World!";
    }

    [HttpPatch("{id}")]
    public object Update()
    {
        return "Hello World!";
    }

    [HttpDelete("{id}")]
    public object Remove(string id)
    {
        return "Hello World!";
    }

    [HttpGet]
    public object GetAll([FromQuery] int page, [FromQuery] int per_page)
    {
        return "Hello World!";
    }

    [HttpGet("{code}")]
    public object Redirect()
    {
        return "Hello World!";
    }

    [HttpGet("{id}/stats")]
    public object GetStats()
    {
        return "Hello World!";
    }

    [HttpGet("{id}/qr")]
    public object QrCode()
    {
        return _service.GenerateQrCode("Hello World!");
    }

}
