namespace HikeService.Data;

using HikeService.Models;

public class HikeRepository : IHikeRepository
{
    private static readonly SortedDictionary<int, Hike> Hikes = new SortedDictionary<int, Hike>()
    {
        {1, new Hike() {Id = 1, UserId = 1, TrailId = 2, Length = 0.8d, Date = new DateTime(2023, 6, 5, 9, 23, 44)}},
        {2, new Hike() {Id = 2, UserId = 1, TrailId = 3, Length = 1.9d, Date = new DateTime(2023, 6, 30, 8, 56, 39)}},
        {3, new Hike() {Id = 3, UserId = 1, TrailId = 2, Length = 2.4d, Date = new DateTime(2023, 9, 29, 10, 1, 27)}},
        {4, new Hike() {Id = 4, UserId = 1, TrailId = 2, Length = 3.3d, Date = new DateTime(2024, 6, 11, 9, 32, 28)}},
        {5, new Hike() {Id = 5, UserId = 2, TrailId = 5, Length = 5.5d, Date = new DateTime(2024, 4, 8, 7, 8, 32)}},
    };

    public IEnumerable<Hike> ListHikes(int? userId)
    {
        var hikes = Hikes.Values.ToList();
        if (userId != null)
        {
            hikes.RemoveAll((hike) => hike.UserId != userId.Value);
        }

        return hikes;
    }

    public Hike GetHike(int id)
    {
        return Hikes[id];
    }
}