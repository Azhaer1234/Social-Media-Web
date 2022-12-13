using Microsoft.EntityFrameworkCore;

namespace SocialWeb.Models
{
    public class SocialDBContext : DbContext
    {
        public SocialDBContext(DbContextOptions<SocialDBContext> options) : base(options)
        {

        }
        public DbSet<ContectDataModel> ContectDataModels { get; set; }
    }
}
