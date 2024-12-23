using HotChocolate.ApolloFederation.Types;

namespace HikeService.Models;

[ExtendServiceType]
public class User
{
    [ID]
    [Key]
    public int Id { get; set; }
}