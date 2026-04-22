using Api_Compra_e_Venda.Context;
using Api_Compra_e_Venda.DTOs;
using Api_Compra_e_Venda.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Compra_e_Venda.Services {
    public class TradeService(AppDbContext context, PortfolioService portfolioService) {
        private readonly PortfolioService _portfolioService = portfolioService;

        public async Task<Trade> ExecuteBuyAsync(TradeRequestDto dto) {
            var trade = CreateTrade(dto, TradeType.BUY);

            context.Trades.Add(trade);

            _portfolioService.Buy(dto.Ticker.ToUpper(), dto.Quantity, dto.PricePerUnit);//atualizar o portifollio

            await context.SaveChangesAsync();

            return trade;
        }

        public async Task<Trade> ExecuteSellAsync(TradeRequestDto dto) {
        
            _portfolioService.Sell(dto.Ticker.ToUpper(), dto.Quantity);// se nao tem nao vende

            var trade = CreateTrade(dto, TradeType.SELL);

            context.Trades.Add(trade);

            await context.SaveChangesAsync();

            return trade;
        }

        public async Task<IEnumerable<Trade>> GetAllAsync() =>
            await context.Trades.ToListAsync();

        public async Task<Trade?> GetByIdAsync(Guid id) =>
            await context.Trades.FindAsync(id);

        private static Trade CreateTrade(TradeRequestDto dto, TradeType type) => new() {
            Ticker = dto.Ticker.ToUpper(),
            Type = type,
            Quantity = dto.Quantity,
            PricePerUnit = dto.PricePerUnit,
            TotalValue = dto.Quantity * dto.PricePerUnit,
            ExecutedAt = DateTime.UtcNow
        };
    }
}