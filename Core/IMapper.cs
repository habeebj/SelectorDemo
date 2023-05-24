using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    public interface IMapper
    {
        dynamic Map<SourceType>(SourceType source, BaseSelector selector);
        TargetType Map<TargetType,SourceType>(SourceType source, BaseSelector<TargetType> selector);
    }
}