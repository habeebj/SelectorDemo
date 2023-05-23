using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    //marker interface
    public interface IConfigMap
    {
        BaseSelector Selector { get; }
    }

    public interface IConfigMap<TargetType, SourceType> : IConfigMap
    {
        public abstract TargetType Map(SourceType source);
    }

    public abstract class ConfigMap<TargetType, SourceType> : IConfigMap<TargetType, SourceType>
    {
        public abstract BaseSelector Selector { get; }

        public TargetType Map(SourceType source)
        {
            return OnMap(source);
        }

        public abstract TargetType OnMap(SourceType source);
    }
}