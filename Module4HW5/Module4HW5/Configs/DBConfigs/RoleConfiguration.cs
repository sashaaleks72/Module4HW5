using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(r => r.Name).HasMaxLength(20);
            builder.HasData(new Role { Id = 1, Name = "admin" }, new Role { Id = 2, Name = "client" });
        }
    }
}
