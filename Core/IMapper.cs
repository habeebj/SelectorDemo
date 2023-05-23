using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    public interface IMapper
    {
        TargetType Map<TargetType, SourceType>(BaseSelector selector, SourceType source);
    }
}