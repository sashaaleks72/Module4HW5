namespace WorkingWithDB.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public virtual User? User { get; set; }
        public int UserId { get; set; }

        public virtual OrderStatus? OrderStatus { get; set; }
        public int OrderStatusId { get; set; }

        public virtual List<OrderProduct>? OrderProducts { get; set; }
    }
}
