
namespace CryptoPricePredictorAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("/", () => "Crypto Price Predictor API is running!");

            app.Run();

        }
    }
}
