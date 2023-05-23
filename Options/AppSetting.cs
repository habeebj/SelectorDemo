using System.Text.RegularExpressions;
using SelectorDemo.Enums;

namespace SelectorDemo.Options
{
    public class TelcoPrefix
    {
        public string Name { get; set; } = null!;
        public CountryCode CountryCode { get; set; }
        public string RegexExpression { get; set; } = null!;
        public bool IsMatch(CountryCode countryCode, string phoneNumber)
        {
            return new Regex(this.RegexExpression).IsMatch(phoneNumber) && this.CountryCode == countryCode;
        }
    }

    public class TelcosPrefixAppSetting
    {
        public const string KEY = "TelcosPrefix";
        public TelcoPrefix[] TelcosPrefix { get; set; } = null!;
    }
}