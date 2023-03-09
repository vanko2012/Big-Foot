namespace big_foot.Data
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }
        //1:M
        public ICollection<Product> Products { get; set;}
    }
}
