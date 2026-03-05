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

            services.AddHttpClient();

            // Services
            services.AddSingleton<BooksApiServices>();
            services.AddScoped<AuthorsApiService>();
            services.AddSingleton<AuthApiService>();

            

            // Forms
            services.AddSingleton<LoginForm>();
            services.AddSingleton<MainForm>();
            services.AddTransient<AddEditBookForm>();
            services.AddSingleton<BooksForm>();

            Services = services.BuildServiceProvider();

            Application.Run(Services.GetRequiredService<LoginForm>());

           
        }

      
    }
}