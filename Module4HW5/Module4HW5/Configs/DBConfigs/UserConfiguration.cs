using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasCheckConstraint("Age", "Age >= 0 AND Age <= 110");
            builder.Property(u => u.Email).HasMaxLength(100);
            builder.Property(u => u.FirstName).HasMaxLength(20);
            builder.Property(u => u.SurName).HasMaxLength(30);
            builder.Property(u => u.Password).HasMaxLength(30);

            builder.HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Aleksandr",
                    SurName = "Kucheryaiev",
                    Email = "sashakucheryaev1@gmail.com",
                    Password = "qwerty123",
                    Age = 20,
                    RoleId = 1
                },
                new User
                {
                    Id = 2,
                    FirstName = "Vladimir",
                    SurName = "Petrov",
                    Email = "vladimirpetrov2001@gmail.com",
                    Password = "Q_1_w_2_e_3_r_4_t_5_y",
                    Age = 19,
                    RoleId = 2
                },
                new User
                {
                    Id = 3,
                    FirstName = "Diana",
                    SurName = "Suhomlinskaya",
                    Email = "suhomlinskaya132656@gmail.com",
                    Password = "Suhom__D__132",
                    Age = 21,
                    RoleId = 2
                });
        }
    }
}
