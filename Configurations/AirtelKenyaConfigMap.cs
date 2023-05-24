using SelectorDemo.Core;
using SelectorDemo.Enums;
using SelectorDemo.Models;
using SelectorDemo.Models.OmniCore;

namespace SelectorDemo.Configurations
{
    public class AirtelKenyaConfigMap : ConfigMap<AirtelKenyaRequest, ApiRequest>
    {
        public override BaseSelector Selector => new SimSwapSelector(CountryCode.KE, Telco.Airtel);

        public override AirtelKenyaRequest OnMap(ApiRequest input)
            => new() { PhoneNumber = input.PhoneNumber };
    }
}