using SelectorDemo.Core;
using SelectorDemo.Enums;
using SelectorDemo.Models;
using SelectorDemo.Models.OmniCore;
using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Configurations
{
    public class GloNigeriaConfigMap : ConfigMap<GloNigeriaRequest, ApiRequest>
    {
        public override BaseSelector Selector => new SimSwapSelector(CountryCode.NG, Telco.Glo);

        public override GloNigeriaRequest OnMap(ApiRequest input) =>
            new GloNigeriaRequest { PhoneNumber = input.PhoneNumber };
    }
}