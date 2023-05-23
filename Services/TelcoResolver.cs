using SelectorDemo.Enums;
using SelectorDemo.Options;
using Microsoft.Extensions.Options;

namespace SelectorDemo.Services
{
    public class TelcoResolver : ITelcoResolver
    {
        private readonly TelcosPrefixAppSetting _telcosAppSetting;

        public TelcoResolver(IOptions<TelcosPrefixAppSetting> telcosAppSetting)
        {
            _telcosAppSetting = telcosAppSetting.Value;
        }

        public Telco Resolve(CountryCode countryCode, string phoneNumber)
        {
            var telco = _telcosAppSetting.TelcosPrefix
                .Where(x =>
                x.IsMatch(countryCode, phoneNumber))
                .FirstOrDefault()
                ?? throw new ArgumentException("Invalid Phone number");

            return Enum.Parse<Telco>(telco.Name, ignoreCase: true);
        }
    }
}