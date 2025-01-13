using GymManagement.Application.Common.Interfaces;
using GymManagement.Domain.Subscriptions;

namespace GymManagement.Infrastructure.Subscriptions.Persistence;

public class SubscriptionRepository : ISubscriptionRepository
{
    private static readonly List<Subscription> Subscriptions = new();
    public Task AddSubscriptionAsync(Subscription subscription)
    {
        Subscriptions.Add(subscription);
        return Task.CompletedTask;
    }

    public Task<Subscription?> GetSubscriptionByIdAsync(Guid requestSubscriptionId, CancellationToken cancellationToken)
    {
        return Task.FromResult(Subscriptions.FirstOrDefault(s => s.Id == requestSubscriptionId));
    }
}