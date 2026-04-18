using System.ComponentModel.DataAnnotations;

namespace Api_Compra_e_Venda.DTOs {
    public class TradeRequestDto {
        [Required]
        public string Ticker { get; set; } = string.Empty;

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be greater than zero.")]
        public int Quantity { get; set; }

        [Range(0.01, double.MaxValue, ErrorMessage = "Price per unit must be positive.")]
        public decimal PricePerUnit { get; set; }
    }
}