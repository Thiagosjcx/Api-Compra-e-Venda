using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Api_Compra_e_Venda.Context;
using Api_Compra_e_Venda.Models;

namespace Api_Compra_e_Venda.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class StocksController : ControllerBase {
        private readonly AppDbContext _context;

        public StocksController(AppDbContext context) {
            _context = context;
        }

        // GET: api/stocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Stock>>> GetStocks() {
            return await _context.Stocks.ToListAsync();
        }

        // GET: api/stocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Stock>> GetStock(int id) {
            var stock = await _context.Stocks.FindAsync(id);

            if (stock == null)
                return NotFound();

            return stock;
        }

        // POST
        [HttpPost]
        public async Task<ActionResult<Stock>> CreateStock(Stock stock) {
            _context.Stocks.Add(stock);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetStock), new { id = stock.Id }, stock);
        }

        // PUT
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStock(int id, Stock stock) {
            if (id != stock.Id)
                return BadRequest();

            _context.Entry(stock).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStock(int id) {
            var stock = await _context.Stocks.FindAsync(id);

            if (stock == null)
                return NotFound();

            _context.Stocks.Remove(stock);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}