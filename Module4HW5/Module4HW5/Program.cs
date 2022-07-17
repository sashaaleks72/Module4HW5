using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WorkingWithDB.DBContexts;
using WorkingWithDB.Configs;
using WorkingWithDB.Models;

namespace WorkingWithDB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var connConfig = new ConnectionConfig();
            string? connectionString = connConfig.Build().GetConnectionString("DefaultConnection");

            if (connectionString != null)
            {
                var optionsBuilder = new DbContextOptionsBuilder<ApplicationContext>();
                var options = optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString).Options;

                // Запрос, который возвращает разницу между CreatedDate/HiredDate и сегодня
                using (var dbContext = new ApplicationContext(options))
                {
                    var order = dbContext.Orders.FirstOrDefault();

                    if (order != null)
                        Console.WriteLine($"Diff: {DateTime.Now - order.OrderDate}\n");
                }

                // Запрос, который выводит инфу из связанных сущностей 
                using (var dbContext = new ApplicationContext(options))
                {
                    var order = dbContext.Orders.FirstOrDefault(o => o.Id == 2);

                    if (order != null)
                    {
                        Console.WriteLine(
                            $"Date of creation: {order.OrderDate}\n" +
                            $"User which made the order: {order.User!.FirstName} {order.User!.SurName}\n" +
                            $"Order status: {order.OrderStatus!.Name}\nProducts:");

                        for (int i = 0; i < order.OrderProducts!.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}) Product name: {order.OrderProducts[i].Teapot!.Title}, quantity: {order.OrderProducts[i].Quantity}");
                        }
                    }

                    Console.WriteLine();
                }

                // Запрос, который группирует юзеров по ролям
                using (var dbContext = new ApplicationContext(options))
                {
                    var groupedUsersByRole = dbContext.Users
                        .GroupBy(u => u.Role!.Name, (role, users) => new { Role = role, Count = users.Count(), UsersInRole = users.ToList() });

                    foreach (var item in groupedUsersByRole)
                    {
                        Console.WriteLine($"Role name: {item.Role}\nQuantity of users in this group: {item.Count}\nUsers in group: ");
                        
                        foreach (var user in item.UsersInRole)
                        {
                            Console.WriteLine(user);
                            Console.WriteLine();
                        }
                    }
                }

                // Запрос, который обновляет 2 сущности. Сделать в одной  транзакции
                using (var dbContext = new ApplicationContext(options))
                {
                    var order = dbContext.Orders.FirstOrDefault(o => o.OrderStatus!.Name == "Waiting for accepting");
                    var user = order!.User;

                    Console.WriteLine(user);

                    order.OrderStatusId = dbContext.OrderStatuses.FirstOrDefault(s => s.Name == "Accepted")!.Id;
                    user!.FirstName = "Bill";

                    dbContext.SaveChanges();
                }

                // Запрос, который добавляет сущности
                using (var dbContext = new ApplicationContext(options))
                {
                    var newTeapot = new Teapot
                    {
                        Title = "Teapot 4",
                        Capacity = 1.8,
                        Color = "Green",
                        Manufacturer = "Tefal",
                        Material = "Plastic + Metal",
                        Power = 2299,
                        Price = 2199,
                        ProducingCountry = "China",
                        Quantity = 10,
                        Warranty = 12
                    };

                    dbContext.Teapots.Add(newTeapot);

                    var newUser = new User
                    {
                        FirstName = "Vladimir",
                        SurName = "Klimchenko",
                        Email = "vlad_k2001@gmail.com",
                        Password = "Vladik4el",
                        Age = 21,
                        RoleId = 2
                    };

                    dbContext.Users.Add(newUser);

                    var newOrder = new Order
                    {
                        OrderDate = DateTime.Now,
                        OrderStatusId = 1,
                        User = newUser
                    };

                    dbContext.Orders.Add(newOrder);

                    var cart = new OrderProduct
                    {
                        Order = newOrder,
                        Teapot = newTeapot,
                        Quantity = 3
                    };

                    dbContext.OrderProducts.Add(cart);
                    dbContext.SaveChanges();
                }

                // Запрос, который удаляет сущности Order & OrderProduct
                using (var dbContext = new ApplicationContext(options))
                {
                    var orderProducts = dbContext.OrderProducts.Where(op => op.OrderId == 1).ToList();
                    var order = dbContext.Orders.FirstOrDefault(o => o.Id == 1);

                    dbContext.OrderProducts.RemoveRange(orderProducts);
                    dbContext.Orders.Remove(order!);

                    dbContext.SaveChanges();
                }
            }
        }
    }
}