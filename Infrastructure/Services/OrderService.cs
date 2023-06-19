public class OrderService
{
            readonly DataContext context;
            public OrderService(  DataContext context)
            {
                this.context=context;
            }
     public async Task<List<Order>> GetOrders()
    {
        return await context.Groups.Select(g => new GetGroupDto()
        {
           Id = g.Id,
           ChallengeId = g.ChallengeId,
           CreatedAt = g.CreatedAt,
           GroupNick = g.GroupNick,
           TeamSlogan = g.TeamSlogan,
           MinimumNumberOfMembers = g.MinimumNumberOfMembers,
           ChallengeTitle = g.Challenge.Title,
           Participans = g.Participants.Select(p=>new ParticipantDto()
           {
               Id = p.Id,
               CreatedAt = p.CreatedAt,
               LocationId = p.LocationId,
               Email = p.Email,
               Fullname = p.Fullname,
               Password = p.Password,
               GroupId = p.GroupId,
               Phone = p.Phone,
               GroupName = p.Group.GroupNick,
               LocationName = p.Location.Name
           }).ToList()
        }).ToListAsync();
    }

}


  