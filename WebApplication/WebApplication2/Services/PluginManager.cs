using WebApplication2.EffectPlugin.Interface;

namespace WebApplication2.Services
{
    public class PluginManager
    {
        private Dictionary<string, Type> _plugins;

        public PluginManager()
        {
            _plugins = new Dictionary<string, Type>();
        }

        public void RegisterPlugin(string name, Type pluginType)
        {
            if (typeof(IEffectPlugin).IsAssignableFrom(pluginType))
            {
                _plugins[name] = pluginType;
            }
            else
            {
                throw new ArgumentException("Plugin must implement IEffectPlugin interface");
            }
        }

        public IEffectPlugin CreatePlugin(string name)
        {
            if (_plugins.ContainsKey(name))
            {
                return (IEffectPlugin)Activator.CreateInstance(_plugins[name]);
            }
            else
            {
                throw new ArgumentException("Plugin not found");
            }
        }
    }
}
