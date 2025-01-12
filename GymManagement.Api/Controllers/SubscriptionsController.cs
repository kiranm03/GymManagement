using GymManagement.Application.Subscriptions.Commands;
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
            subscriptionId => 
                Created($"/subscriptions/{subscriptionId}", new SubscriptionResponse(subscriptionId, request.SubscriptionType)),
            _ => Problem());
    }
    
    [HttpGet]
    public IActionResult GetSubscriptions() => Ok();
}