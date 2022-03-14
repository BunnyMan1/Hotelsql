using Microsoft.AspNetCore.Mvc;
using Hotelsql.Models;
using Hotelsql.Repositories;
using Hotelsql.DTOs;

namespace Hotelsql.Controllers;

[ApiController]
[Route("api/room")]
public class RoomController : ControllerBase
{
    private readonly ILogger<RoomController> _logger;
    private readonly IRoomRepository _room;

    public RoomController(ILogger<RoomController> logger, IRoomRepository _room)
    {
        _logger = logger;
        this._room = _room;
    }

    // [HttpGet]
    // public async Task<ActionResult> GetList()
    // {

    // }

    [HttpGet("{id}")]
    public async Task<ActionResult<RoomDTO>> GetById([FromRoute] int id)
    {
        var res = await _room.GetById(id);

        if (res is null)
            return NotFound();

        return Ok(res.asDto);
    }

    // [HttpPost]
    // public async Task<ActionResult> Create([FromRoute] int id)
    // {

    // }

    // [HttpPut("{id}")]
    // public async Task<ActionResult> Update([FromRoute] int id)
    // {

    // }

    // [HttpDelete("{id}")]
    // public async Task<ActionResult> Delete([FromRoute] int id)
    // {

    // }
}
