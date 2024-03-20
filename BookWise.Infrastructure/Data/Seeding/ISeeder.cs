using Microsoft.Extensions.DependencyInjection;

namespace BookWise.Data.Seeding
{
    public interface ISeeder
    {
        Task SeedAsync(IServiceScope serviceScope);
    }
}
