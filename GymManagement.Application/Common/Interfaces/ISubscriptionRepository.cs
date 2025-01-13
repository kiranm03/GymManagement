using GymManagement.Domain.Subscriptions;

namespace GymManagement.Application.Common.Interfaces;

public interface ISubscriptionRepository
{
    Task AddSubscriptionAsync(Subscription subscription);
    Task<Subscription?> GetSubscriptionByIdAsync(Guid requestSubscriptionId, CancellationToken cancellationToken);
}