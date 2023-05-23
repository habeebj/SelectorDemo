using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Models.OmniCore
{
    public class AirtelKenyaRequest : IFeatureRequest
    {
        public string PhoneNumber { get; set; } = null!;
    }
}