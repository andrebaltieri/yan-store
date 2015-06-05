using System.Data.Entity;
using YanStore.Domain.Model;

namespace YanStore.Infra.Context
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext()
            : base("CnnStr")
        { }

        public DbSet<User> Users { get; set; }
    }
}
