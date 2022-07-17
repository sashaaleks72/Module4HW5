namespace WorkingWithDB.Models
{
    public class OrderProduct
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public virtual Order? Order { get; set; }
        public int OrderId { get; set; }

        public virtual Teapot? Teapot { get; set; }
        public int TeapotId { get; set; }
    }
}
