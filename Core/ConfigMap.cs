using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    public interface IConfigMap
    {
        BaseSelector Selector { get; }
        public abstract IFeatureRequest Map(object input);
    }

    public abstract class ConfigMap<TInput> : IConfigMap
    {
        public abstract BaseSelector Selector { get; }

        public IFeatureRequest Map(object input)
        {
            return OnMap((TInput)input);
        }

        public abstract IFeatureRequest OnMap(TInput input);
    }
}