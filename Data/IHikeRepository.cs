namespace HikeService.Data;

using HikeService.Models;

public interface IHikeRepository 
{
    public Hike GetHike(int id);
    public IEnumerable<Hike> ListHikes(int? userId);
}