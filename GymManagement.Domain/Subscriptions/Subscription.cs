namespace GymManagement.Domain.Subscriptions;

public class Subscription
{
    public Guid Id { get; set; }
    public SubscriptionType SubscriptionType { get; set; }
}

public enum SubscriptionType
{
    Free,
    Basic,
    Premium
}