namespace WorkingWithDB.Models
{
    public class Teapot
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public int Quantity { get; set; }

        public string Color { get; set; } = string.Empty;

        public string Material { get; set; } = string.Empty;

        public double Price { get; set; }

        public int Warranty { get; set; }

        public int Power { get; set; }

        public double Capacity { get; set; }

        public string ProducingCountry { get; set; } = string.Empty;

        public string Manufacturer { get; set; } = string.Empty;

        public virtual List<OrderProduct>? OrderProducts { get; set; }
    }
}
