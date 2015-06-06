using System.Data.Entity.ModelConfiguration;
using YanStore.Domain.Model;

namespace YanStore.Infra.Mapping
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(x => x.Id);
            Property(x => x.Username).IsRequired();
            Property(x => x.Password).IsRequired();
        }
    }
}
