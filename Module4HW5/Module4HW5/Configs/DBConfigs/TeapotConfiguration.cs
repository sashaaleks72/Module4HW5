using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class TeapotConfiguration : IEntityTypeConfiguration<Teapot>
    {
        public void Configure(EntityTypeBuilder<Teapot> builder)
        {
            builder.Property(t => t.Title).HasMaxLength(30);
            builder.Property(t => t.ProducingCountry).HasMaxLength(50);
            builder.Property(t => t.Color).HasMaxLength(30);
            builder.Property(t => t.Manufacturer).HasMaxLength(40);
            builder.Property(t => t.Material).HasMaxLength(40);

            builder.HasData(
                new Teapot
                {
                    Id = 1,
                    Title = "Teapot 1",
                    Capacity = 2.3,
                    Color = "Black",
                    Manufacturer = "Xiaomi",
                    Material = "Plastic + Metal",
                    Power = 2400,
                    Price = 2199,
                    ProducingCountry = "China",
                    Quantity = 10,
                    Warranty = 12
                },
                new Teapot
                {
                    Id = 2,
                    Title = "Teapot 2",
                    Capacity = 1.5,
                    Color = "Green",
                    Manufacturer = "Xiaomi",
                    Material = "Plastic",
                    Power = 1800,
                    Price = 1899,
                    ProducingCountry = "China",
                    Quantity = 5,
                    Warranty = 18
                },
                new Teapot
                {
                    Id = 3,
                    Title = "Teapot 3",
                    Capacity = 1.8,
                    Color = "White",
                    Manufacturer = "Tefal",
                    Material = "Plastic + Metal",
                    Power = 2400,
                    Price = 2199,
                    ProducingCountry = "China",
                    Quantity = 6,
                    Warranty = 24
                });
        }
    }
}
