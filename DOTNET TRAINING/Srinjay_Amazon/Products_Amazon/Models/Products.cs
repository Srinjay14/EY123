using System.Globalization;

namespace Products_Amazon.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image {  get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public int Discounted_Price { get; set; }

    }
}
