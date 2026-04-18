using Api_Compra_e_Venda.DTOs;
using Api_Compra_e_Venda.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api_Compra_e_Venda.Controllers {
    [ApiController]
    [Route("api/trades")]
    public class TradesController(TradeService service) : ControllerBase {
        [HttpPost("buy")]
        public async Task<IActionResult> Buy([FromBody] TradeRequestDto dto) {
            var trade = await service.ExecuteBuyAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = trade.Id }, trade);
        }

        [HttpPost("sell")]
        public async Task<IActionResult> Sell([FromBody] TradeRequestDto dto) {
            var trade = await service.ExecuteSellAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = trade.Id }, trade);
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() =>
            Ok(await service.GetAllAsync());

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetById(Guid id) {
            var trade = await service.GetByIdAsync(id);
            return trade is null ? NotFound() : Ok(trade);
        }
    }
}