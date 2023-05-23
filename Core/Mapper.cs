using Microsoft.Extensions.DependencyInjection;
using SelectorDemo.OminCoreLib;

namespace SelectorDemo.Core
{
    public class Mapper : IMapper
    {
        private readonly IServiceProvider _serviceProvider;

        public Mapper(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TargetType Map<TargetType, SourceType>(BaseSelector selector, SourceType source)
        {
            ArgumentNullException.ThrowIfNull(source);

            dynamic configMap = _serviceProvider.GetServices<IConfigMap>()
                .FirstOrDefault(x => x.Selector.Key == selector.Key)
                ?? throw new InvalidOperationException("No Implementation for the selector " + selector.Key);
            
            return configMap.Map(source);
        }
    }
}