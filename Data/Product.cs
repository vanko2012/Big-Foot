using System.ComponentModel.DataAnnotations.Schema;

namespace big_foot.Data
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "decimal(10, 2)")]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public int Size { get; set; }
        //M:1
        public int CategoryId { get; set; }
        public Category Categories { get; set; }
        
        public DateTime Register_On { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}
