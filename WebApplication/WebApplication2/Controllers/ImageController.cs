using Microsoft.AspNetCore.Mvc;
using WebApplication2.EffectPlugin;
using WebApplication2.EffectPlugin.Interface;
using WebApplication2.Models;
using WebApplication2.Services;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : Controller
    {
        private readonly PluginManager _pluginManager;
        private readonly EffectProcessor _effectProcessor;

        public ImageController(PluginManager pluginManager, EffectProcessor effectProcessor)
        {
            _pluginManager = pluginManager;
            _effectProcessor = effectProcessor;
        }

        [HttpPost("applyEffects")]
        public IActionResult ApplyEffects([FromBody] List<Image> images)
        {
            foreach (var image in images)
            {
                var effects = new List<IEffectPlugin>();
                foreach (var effectModel in image.Effects)
                {
                    var effect = _pluginManager.CreatePlugin(effectModel.Name);
                    effects.Add(effect);
                }

                _effectProcessor.ProcessEffects(image);
            }

            return Ok("Effects applied successfully.");
        }
    }
}
