using Soenneker.Responses.Entities.Named;
using Soenneker.Utils.AutoBogus.Context;
using Soenneker.Utils.AutoBogus.Override;

namespace Soenneker.AutoFaker.Overrides.Responses.Entities.Named;

/// <summary>
/// An AutoFaker (AutoBogus) override for the NamedEntityResponse object
/// </summary>
public class NamedEntityResponseOverride : AutoFakerOverride<NamedEntityResponse>
{
    public override bool CanOverride(AutoFakerContext context)
    {
        return context.GenerateType.IsSubclassOf(typeof(NamedEntityResponse));
    }

    public override void Generate(AutoFakerOverrideContext context)
    {
    }
}
