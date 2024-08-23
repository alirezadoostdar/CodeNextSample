namespace GetMehrData.Models
{
    public class AddItemToCatalogViewModel
    {
        public string name { get; set; }
        public string description { get; set; }
        public int catalogId { get; set; }
        public int brandId { get; set; }
        public int maxStockThreshold { get; set; }
    }
}


