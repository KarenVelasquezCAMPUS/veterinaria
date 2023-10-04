using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;
public class ApiVeterinariaContext : DbContext
{
    public ApiVeterinariaContext(DbContextOptions options) : base(options)
    {
    }
}