namespace SelectorDemo.Core
{
    public abstract record BaseSelector
    // : IEquatable<BaseSelector>
    {
        // TODO: Type name check
        public virtual string Key =>
            string.Join(",",
                GetType().GetProperties().Where(x => x.Name != nameof(BaseSelector.Key)).Select(x => x.GetValue(this)).Append(GetType()));
    }
}