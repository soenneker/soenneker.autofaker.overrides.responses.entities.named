using Soenneker.Responses.Entities.Named;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Responses.Entities.Named;

/// <summary>
/// An AutoFaker (AutoBogus) override for the NamedEntityResponse object
/// </summary>
public class NamedEntityResponseOverride : AutoFakerOverride<NamedEntityResponse>
{
    /// <summary>
    /// Executes the can override operation.
    /// </summary>
    /// <param name="context">The context.</param>
    /// <returns>A value indicating whether the operation succeeded.</returns>
    public override bool CanOverride(AutoFakerContext context)
    {
        return typeof(NamedEntityResponse).IsAssignableFrom(context.GenerateType);
    }

    /// <summary>
    /// Executes the generate operation.
    /// </summary>
    /// <param name="context">The context.</param>
    public override void Generate(AutoFakerOverrideContext context)
    {
        var target = (context.Instance as NamedEntityResponse)!;
        target.Name = context.Faker.Commerce.ProductName();
    }
}
