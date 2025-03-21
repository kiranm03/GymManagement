using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;
using GymManagement.Infrastructure.Common.Persistence;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionRepository : ISubscriptionRepository
{
    private readonly GymManagementDbContext _dbContext;

    public SubscriptionRepository(GymManagementDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task AddSubscriptionAsync(Subscription subscription)
    {
        await _dbContext.Subscriptions.AddAsync(subscription);
    }

    public async Task<Subscription?> GetSubscriptionByIdAsync(Guid requestSubscriptionId, CancellationToken cancellationToken)
    {
        return await _dbContext.Subscriptions.FindAsync(requestSubscriptionId, cancellationToken);
    }
}