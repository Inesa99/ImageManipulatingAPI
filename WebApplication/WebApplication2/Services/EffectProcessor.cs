using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class EffectProcessor
    {
        public void ProcessEffects(Image image)
        {
            byte[] ImageData = new byte[0];
            foreach (var effect in image.Effects)
            {
                effect.Apply(ref ImageData);
            }
        }
    }
}
