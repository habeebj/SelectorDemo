using SelectorDemo.Core;
using SelectorDemo.Enums;

namespace SelectorDemo

{
    public record SimSwapSelector(CountryCode CountryCode, Telco Telco) : BaseSelector { }
}