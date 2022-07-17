using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class OrderProductConfiguration : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasData(
                new OrderProduct { Id = 1, TeapotId = 1, OrderId = 1, Quantity = 3 },
                new OrderProduct { Id = 2, TeapotId = 2, OrderId = 1, Quantity = 4 },
                new OrderProduct { Id = 3, TeapotId = 1, OrderId = 2, Quantity = 2 },
                new OrderProduct { Id = 4, TeapotId = 3, OrderId = 3, Quantity = 9 });
        }
    }
}
