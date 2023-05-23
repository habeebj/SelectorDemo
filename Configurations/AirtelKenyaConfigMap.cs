using SelectorDemo.Core;
using SelectorDemo.Enums;
using SelectorDemo.Models;
using SelectorDemo.Models.OmniCore;
using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Configurations
{
    public class AirtelKenyaConfigMap : ConfigMap<ApiRequest>
    {
        public override BaseSelector Selector => new SimSwapSelector(CountryCode.KE, Telco.Airtel);

        public override IFeatureRequest OnMap(ApiRequest input) =>
            new AirtelKenyaRequest { PhoneNumber = input.PhoneNumber };
    }
}