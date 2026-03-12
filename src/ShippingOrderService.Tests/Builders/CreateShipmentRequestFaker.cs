using Bogus;
using ShippingOrderService.Web.Features.Shipments;

namespace ShippingOrderService.Tests.Builders;

public class CreateShipmentRequestFaker : Faker<CreateShipmentRequest>
{
    public CreateShipmentRequestFaker()
    {
        RuleFor(x => x.CustomerName, f => f.Person.FullName);
        RuleFor(x => x.OriginZipCode, f => f.Address.ZipCode("#####-###"));
        RuleFor(x => x.DestinationZipCode, f => f.Address.ZipCode("#####-###"));
        RuleFor(x => x.TotalValue, f => f.Finance.Amount(100m, 50000m));
        
    }
}