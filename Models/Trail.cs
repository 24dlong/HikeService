using HotChocolate.ApolloFederation.Types;

namespace HikeService.Models;

[ExtendServiceType]
public class Trail
{
    [ID]
    [Key]
    public int Id { get; set; }
}