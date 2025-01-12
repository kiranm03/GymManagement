using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionRepository : ISubscriptionRepository
{
    public async Task AddSubscriptionAsync(Subscription subscription)
    {
        await Task.CompletedTask;
    }
}