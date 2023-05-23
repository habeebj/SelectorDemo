using SelectorDemo.Enums;

namespace SelectorDemo.Services
{
    public interface ITelcoResolver
    {
        Telco Resolve(CountryCode countryCode, string phoneNumber);
    }
}