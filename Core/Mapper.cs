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

        public IFeatureRequest Map<TInput>(BaseSelector selector, TInput input)
        {
            ArgumentNullException.ThrowIfNull(input);

            var configMap = _serviceProvider.GetServices<IConfigMap>()
                .FirstOrDefault(x => x.Selector.Key == selector.Key)
                ?? throw new InvalidOperationException("No Implementation for the selector " + selector.Key);
            
            return configMap.Map(input);
        }
    }
}