using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    public interface IMapper
    {
        IFeatureRequest Map<TInput>(BaseSelector selector, TInput input);
    }
}