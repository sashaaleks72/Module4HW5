using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.Property(s => s.Name).HasMaxLength(30);
            builder.HasData(
                new OrderStatus { Id = 1, Name = "Waiting for accepting" },
                new OrderStatus { Id = 2, Name = "Accepted" },
                new OrderStatus { Id = 3, Name = "Canceled" });
        }
    }
}
