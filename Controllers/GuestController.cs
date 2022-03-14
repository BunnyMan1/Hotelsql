using Microsoft.AspNetCore.Mvc;
using Hotelsql.Models;

namespace Hotelsql.Controllers;

[ApiController]
[Route("api/guest")]
public class GuestController : ControllerBase
{
    private readonly ILogger<GuestController> _logger;

    public GuestController(ILogger<GuestController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult> GetList()
    {

    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetById([FromRoute] int id)
    {

    }

    [HttpPost]
    public async Task<ActionResult> Create([FromRoute] int id)
    {

    }

    [HttpPut("{id}")]
    public async Task<ActionResult> Update([FromRoute] int id)
    {

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete([FromRoute] int id)
    {

    }
}
