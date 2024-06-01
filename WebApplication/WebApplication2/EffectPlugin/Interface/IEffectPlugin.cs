namespace WebApplication2.EffectPlugin.Interface
{
    public interface IEffectPlugin
    {
        string Name { get; }
        void Apply(ref byte[] imageData);
    }
}
