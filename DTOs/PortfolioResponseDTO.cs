namespace Api_Compra_e_Venda.DTOs 
{
    public class PortfolioResponseDTO {
        public string Ticker { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public decimal AverageCost { get; set; }
    }
}