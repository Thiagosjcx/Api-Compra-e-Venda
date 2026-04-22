using Microsoft.EntityFrameworkCore;
using Api_Compra_e_Venda.Context;
using Api_Compra_e_Venda.Models;
using Api_Compra_e_Venda.DTOs;

namespace Api_Compra_e_Venda.Services 
{
    public class PortfolioService {
        private readonly AppDbContext _context;

        public PortfolioService(AppDbContext context) {
            _context = context;
        }

        public List<PortfolioResponseDTO> GetPortfolio() {
            return _context.PortfolioAssets
                .Select(a => new PortfolioResponseDTO {
                    Ticker = a.Ticker,
                    Quantity = a.Quantity,
                    AverageCost = a.AverageCost
                })
                .ToList();
        }

        public void Buy(string ticker, int qtdNova, decimal precoNovo) {
            var asset = _context.PortfolioAssets
                .FirstOrDefault(a => a.Ticker == ticker);

            if (asset == null) {
                _context.PortfolioAssets.Add(new PortfolioAsset {
                    Ticker = ticker,
                    Quantity = qtdNova,
                    AverageCost = precoNovo
                });
            }
            else {
                var qtdAtual = asset.Quantity;
                var precoMedioAtual = asset.AverageCost;

                asset.AverageCost =
                    (qtdAtual * precoMedioAtual + qtdNova * precoNovo)
                    / (qtdAtual + qtdNova);

                asset.Quantity += qtdNova;
            }

            _context.SaveChanges();
        }

        public void Sell(string ticker, int qtdVenda) {
            var asset = _context.PortfolioAssets
                .FirstOrDefault(a => a.Ticker == ticker);

            if (asset == null || asset.Quantity < qtdVenda)
                throw new Exception("Saldo insuficiente");

            asset.Quantity -= qtdVenda;

            if (asset.Quantity == 0)
                _context.PortfolioAssets.Remove(asset);

            _context.SaveChanges();
        }
    }
}