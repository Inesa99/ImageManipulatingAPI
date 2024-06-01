//using WebApplication.EffectPlugin.Effects;
//using WebApplication.EffectPlugin.Manager;

using WebApplication2.EffectPlugin;
using WebApplication2.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddSingleton<PluginManager>();
            builder.Services.AddSingleton<EffectProcessor>();

            builder.Services.AddControllers();

            var pluginManager = new PluginManager();
            pluginManager.RegisterPlugin("Resize", typeof(ResizeEffect));
            pluginManager.RegisterPlugin("Blur", typeof(BlurEffect));
            builder.Services.AddSingleton(pluginManager);

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}