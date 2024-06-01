using WebApplication2.EffectPlugin.Interface;

namespace WebApplication2.EffectPlugin
{
    public class BlurEffect : IEffectPlugin
    {
        public string Name => "Blur";
        private int _blurSize;

        public BlurEffect(int blurSize)
        {
            _blurSize = blurSize;
        }

        public void Apply(ref byte[] imageData)
        {
            Console.WriteLine($"Applying {Name} effect with blur size {_blurSize}");
        }
    }
}
