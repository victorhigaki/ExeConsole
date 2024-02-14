using Services.Services.Interfaces;

namespace Services.Services
{
    public class App : IApp
    {
        public async Task Run()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
