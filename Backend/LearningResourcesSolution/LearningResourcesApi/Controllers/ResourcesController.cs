using LearningResourcesApi.Adapters;
using LearningResourcesApi.Domain;
using LearningResourcesApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace LearningResourcesApi.Controllers;

public class ResourcesController :ControllerBase
{
    private readonly LearningResourcesDataContext _context;

    public ResourcesController(LearningResourcesDataContext context)
    {
        _context = context;
    }
    public record CreateResourceItem
    {
        [Required]
        public string Description { get; init; } = "";
        [Required]
        public LearningItemType Type { get; init; }
        [Required, MaxLength(100), MinLength(5)]
        public string Link { get; init; } = "";
    }

    [HttpPost("/resources")]
    public async Task<ActionResult> AddItem([FromBody] CreateResourceItem request)
    {
        if (ModelState.IsValid == false)
        {
            return BadRequest(ModelState);
        }
        // tomorrow - ADD IT TO THE DATABASE
        var response = new GetResourceItem
        {
            Id = Guid.NewGuid().ToString(),
            Description = request.Description,
            Link = request.Link,
            Type = request.Type,
        };
        return Ok(response);
    }

    [HttpGet("/resources")]
    public async Task<ActionResult> GetResources()
    {
        // Mapping - copying from a to b =
        var items = await _context.Items
 .Select(item => new GetResourceItem
 {
     Id = item.Id.ToString(),
     Description = item.Description,
     Link = item.Link,
     Type = item.Type
 }).ToListAsync(); var response = new GetResourcesResponse { Items = items };
        return Ok(response);
    }
}
