
using SignalRExample.API.Services;

namespace SignalRExample.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
;
            builder.Services.AddSignalR();
            
            var app = builder.Build();

            // Habilitar a utilização de arquivos estáticos
            app.UseStaticFiles();

            app.UseRouting();

            app.MapHub<ChatHub>("/chathub");
            
            app.MapGet("/", () => Results.Redirect("/index.html"));

            //app.UseHttpsRedirection();

           // app.UseAuthorization();

            //app.MapControllers();

            app.Run();
        }
    }
}
