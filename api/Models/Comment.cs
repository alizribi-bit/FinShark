
namespace api.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public String  Title { get; set; }= String.Empty;
        public String Content { get; set; } = String.Empty;
        public DateTime CreateOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }
        public Stock Stock { get; set; }
    }
}