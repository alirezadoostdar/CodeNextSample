namespace GetMehrData.Models
{
    public record GoodViewModel
    {
        public int goodSysCode { get; set; }
        public string title { get; set; }
        public decimal SalePrice1 { get; set; }
        public string categoryTitle { get; set; }
    }
}
