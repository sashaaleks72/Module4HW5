using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorkingWithDB.Models;

namespace WorkingWithDB.Configs.DBConfigs
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasData(
               new Order
               {
                   Id = 1,
                   OrderStatusId = 1,
                   OrderDate = DateTime.Now,
                   UserId = 2
               },
               new Order
               {
                   Id = 2,
                   OrderStatusId = 2,
                   OrderDate = DateTime.Now,
                   UserId = 3
               },
               new Order
               {
                   Id = 3,
                   OrderStatusId = 2,
                   OrderDate = DateTime.Now,
                   UserId = 2
               });
        }
    }
}
