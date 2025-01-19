using GymManagement.Application.Subscriptions.Commands;
using GymManagement.Application.Subscriptions.Queries;
using GymManagement.Contracts.Subscriptions;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace GymManagement.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class SubscriptionsController : ControllerBase
{
    private readonly ISender _sender;

    public SubscriptionsController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSubscription(CreateSubscriptionRequest request)
    {
        var createSubscriptionCommand = new CreateSubscriptionCommand(request.SubscriptionType.ToString(), request.AdminId);
        var createSubscriptionResult = await _sender.Send(createSubscriptionCommand);

        return createSubscriptionResult.MatchFirst(
            subscription =>
                Created($"/subscriptions/{subscription.Id}", new SubscriptionResponse(subscription.Id, request.SubscriptionType)),
            _ => Problem());
    }

    [HttpGet("{subscriptionId}")]
    public async Task<IActionResult> GetSubscription(Guid subscriptionId)
    {
        var getSubscriptionQuery = new GetSubscriptionQuery(subscriptionId);
        var getSubscriptionResult = await _sender.Send(getSubscriptionQuery);

        return getSubscriptionResult.MatchFirst(
            subscription => 
                Ok(new SubscriptionResponse(subscription.Id, Enum.Parse<SubscriptionType>(subscription.SubscriptionType.ToString()))),
            _ => Problem());
    }
}