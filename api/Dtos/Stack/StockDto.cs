using System.ComponentModel.DataAnnotations.Schema;

namespace api.Dtos.Stack
{
    public class StockDto
    {
        public int Id { get; set; }
        public String Symbol { get; set; } = String.Empty;
        public String CompanyName { get; set; } = String.Empty;
        public decimal Purchase { get; set; }
        public decimal LastDiv { get; set; }
        public String Industry { get; set; } = String.Empty;
        public long MarketCap { get; set; }
    }
}
