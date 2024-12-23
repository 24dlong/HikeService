using HikeService.Data;
using HotChocolate.ApolloFederation.Resolvers;
using HotChocolate.ApolloFederation.Types;

namespace HikeService.Models
{
    public class Hike
    {
        [ID]
        [Key]
        public int Id { get; set; }
        
        [GraphQLIgnore]
        public required int UserId { get; set; }
        public User GetUser() => new User { Id = UserId };
        
        [GraphQLIgnore]
        public required int TrailId { get; set; }
        public Trail GetTrail() => new Trail { Id = TrailId };
        
        public required double Length { get; set; }
        public required DateTime Date { get; set; }
        
        [ReferenceResolver]
        public static Hike? ResolveReference(
            int id,
            IHikeRepository hikeRepository
        )
        {
            return hikeRepository.GetHike(id);
        }
    }
}