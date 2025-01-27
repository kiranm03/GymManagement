namespace GymManagement.Domain.Subscriptions;

public class Subscription
{
    public Guid Id { get; }
    public SubscriptionType SubscriptionType { get; }
    
    private readonly Guid _adminId;
    
    public Subscription(SubscriptionType subscriptionType, Guid adminId, Guid? id = null)
    {
        Id = id ?? Guid.NewGuid();
        SubscriptionType = subscriptionType;
        _adminId = adminId;
    }
}

public enum SubscriptionType
{
    Free,
    Basic,
    Premium
}