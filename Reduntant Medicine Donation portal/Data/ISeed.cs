using System.Threading.Tasks;

namespace Data
{
    public interface ISeed
    {
        Task MigrateAsync();
        Task SeedAsync();
    }
}
