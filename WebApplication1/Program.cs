namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // above initializes Asp.net core application and sets up services (middleware, configuration, logging)


            builder.Services.AddMvc();
            var app = builder.Build();
            // above after builder sets up services and configurations .Build() is called to create WebApplication object

            //app.MapGet("/", () => "Hello World!");
            // defines route for the application using MapGet();
            
            app.UseRouting();
            // to set up routing middleware

            app.UseEndpoints(endpoints => endpoints.MapControllerRoute("default", "{controller=home}/{action}/{id?}"));
            app.Run();
        }
    }
}
