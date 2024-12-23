namespace HikeService.GraphQL;

using HikeService.Models;
using HikeService.Data;

public class Query
{
    private readonly IHikeRepository _hikeRepository;

    public Query(IHikeRepository hikeRepository)
    {
        _hikeRepository = hikeRepository;
    }

    public Hike GetHike(int id) =>
        _hikeRepository.GetHike(id);

    public IEnumerable<Hike> GetHikes(int? userId) =>
        _hikeRepository.ListHikes(userId);
}
