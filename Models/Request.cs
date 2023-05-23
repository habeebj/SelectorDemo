using SelectorDemo.Enums;

namespace SelectorDemo.Models
{
    public class ApiRequest
    {
        public CountryCode CountryCode { get; set; }
        public string PhoneNumber { get; set; } = null!;
    }
}