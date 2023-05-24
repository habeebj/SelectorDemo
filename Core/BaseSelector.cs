namespace SelectorDemo.Core
{
    public abstract record BaseSelector
    // : IEquatable<BaseSelector>
    {
        // TODO: Type name check
        public virtual string Key =>
            string.Join("_",
                GetType()
                .GetProperties()
                .Where(x => x.Name != nameof(BaseSelector.Key))
                .Select(x => x.GetValue(this)).Prepend(GetType()));
    }

    public abstract record BaseSelector<T>
    {
        public virtual string Key =>
            string.Join("_",
                typeof(T)
                .GetProperties()
                .Where(x => x.Name != nameof(BaseSelector.Key))
                .Select(x => x.GetValue(this)).Prepend(GetType()));
    }
}