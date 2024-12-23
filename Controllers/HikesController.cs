using Microsoft.AspNetCore.Mvc;
using HikeService.Models;
using HikeService.Data;

namespace HikeService.Controllers;

[ApiController]
[Route("[controller]")]
public class HikesController : ControllerBase
{
    
    private readonly IHikeRepository _hikeRepository;

    public HikesController(IHikeRepository hikeRepository)
    {
        _hikeRepository = hikeRepository;
    }

    [HttpGet("")]
    public IEnumerable<Hike> ListHikes(int? userId)
    {
        return _hikeRepository.ListHikes(userId);
    }
    
    [HttpGet("{id}")]
    public Hike GetHike(int id)
    {
        return _hikeRepository.GetHike(id);
    }
}