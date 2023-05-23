using SelectorDemo.Core;
using SelectorDemo.Enums;
using SelectorDemo.Models;
using SelectorDemo.Models.OmniCore;
using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Configurations
{
    public class MtnKenyaConfigMap : ConfigMap<ApiRequest>
    {
        public override BaseSelector Selector => new SimSwapSelector(CountryCode.KE, Telco.Mtn);

        public override IFeatureRequest OnMap(ApiRequest input)
        {
            return new MtnKenyaRequest { PhoneNumber = input.PhoneNumber };
        }
    }
}