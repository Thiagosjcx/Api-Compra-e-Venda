using System;

namespace Api_Compra_e_Venda.Models 
{
    public enum TradeType {
        BUY,
        SELL
    }

    public class Trade {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Ticker { get; set; } = string.Empty;
        public TradeType Type { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime ExecutedAt { get; set; } = DateTime.UtcNow;
    }
}