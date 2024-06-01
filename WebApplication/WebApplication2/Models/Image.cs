using WebApplication2.EffectPlugin.Interface;

namespace WebApplication2.Models
{
    public class Image
    {
        public string Name { get; set; }
        public List<IEffectPlugin> Effects { get; set; }

        public Image(string name)
        {
            Name = name;
            Effects = new List<IEffectPlugin>();
        }

        public void AddEffect(IEffectPlugin effect)
        {
            Effects.Add(effect);
        }

        public void RemoveEffect(IEffectPlugin effect)
        {
            Effects.Remove(effect);
        }
    }
}
