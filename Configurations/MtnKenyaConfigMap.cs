using SelectorDemo.Core;
using SelectorDemo.Enums;
using SelectorDemo.Models;
using SelectorDemo.Models.OmniCore;
using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Configurations
{
    public class MtnKenyaConfigMap : ConfigMap<MtnKenyaRequest,ApiRequest>
    {
        public override BaseSelector Selector => new SimSwapSelector(CountryCode.KE, Telco.Mtn);

        public override MtnKenyaRequest OnMap(ApiRequest input)
        {
            return new MtnKenyaRequest { PhoneNumber = input.PhoneNumber };
        }
    }
}