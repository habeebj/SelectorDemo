using Microsoft.Extensions.DependencyInjection;

namespace SelectorDemo.Core
{
    public class Mapper : IMapper
    {
        private readonly IServiceProvider _serviceProvider;

        public Mapper(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public dynamic Map<SourceType>(SourceType source, BaseSelector selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            dynamic configMap = _serviceProvider.GetServices<IConfigMap>()
                .FirstOrDefault(x => x.Selector.Key == selector.Key)
                ?? throw new InvalidOperationException("No Implementation for the selector " + selector.Key);

            return configMap.Map(source);
        }

        public TargetType Map<TargetType, SourceType>(SourceType source, BaseSelector<TargetType> selector)
        {
            ArgumentNullException.ThrowIfNull(source);

            dynamic configMap = _serviceProvider.GetServices<IConfigMap>()
                .FirstOrDefault(x => x.Selector.Key == selector.Key)
                ?? throw new InvalidOperationException("No Implementation for the selector " + selector.Key);

            return configMap.Map(source);
        }
    }
}