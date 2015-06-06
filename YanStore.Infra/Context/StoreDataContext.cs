using System.Data.Entity;
using YanStore.Domain.Model;
using YanStore.Infra.Mapping;

namespace YanStore.Infra.Context
{
    public class StoreDataContext : DbContext
    {
        public StoreDataContext()
            //: base("CnnStr")
        { }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
