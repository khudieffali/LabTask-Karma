namespace LabTask_Karma.Models
{
	public class Product
	{
        public int Id { get; set; }
        public string  ProductName { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public string Description { get; set; }
        public decimal Raiting { get; set; }
        public decimal Discount { get; set; }
        public DateTime ProductionDate { get; set; }
        public int CategoryId { get; set; }
        public Category? Categories { get; set; }
    }
}
