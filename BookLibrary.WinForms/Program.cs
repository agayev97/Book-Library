using BookLibrary.WinForms.Forms;
using BookLibrary.WinForms.Services;
using Microsoft.Extensions.DependencyInjection;


namespace BookLibrary.WinForms
{
    public static class Program
    {
        public static IServiceProvider Services { get; private set; }

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            // Services
            services.AddSingleton<BooksApiServices>();
            services.AddSingleton<AuthApiService>(); 

            // Forms
            services.AddSingleton<LoginForm>();
            services.AddSingleton<MainForm>();

            Services = services.BuildServiceProvider();

            Application.Run(Services.GetRequiredService<LoginForm>());
        }

      
    }
}