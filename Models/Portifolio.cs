using System.ComponentModel.DataAnnotations;
namespace Api_Compra_e_Venda.Models;

public class PortfolioAsset {
    [Key]
    public int Id { get; set; }
    public string Ticker { get; set; } = string.Empty;
    public int Quantity { get; set; }
    public decimal AverageCost { get; set; }
}