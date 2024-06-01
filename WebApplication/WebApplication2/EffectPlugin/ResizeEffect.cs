using WebApplication2.EffectPlugin.Interface;

namespace WebApplication2.EffectPlugin
{
    public class ResizeEffect : IEffectPlugin
    {
        public string Name => "Resize";
        private int _size;

        public ResizeEffect(int size)
        {
            _size = size;
        }

        public void Apply(ref byte[] imageData)
        {
            //Console.WriteLine($"Applying {Name} effect with size {_size}");
        }
    }
}
