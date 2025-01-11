namespace GymManagement.Application.Services;

public interface ISubscriptionsWriteService
{
    public Guid CreateSubscription(string subscriptionType, Guid adminId);
}