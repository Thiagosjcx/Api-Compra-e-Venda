using Microsoft.AspNetCore.Mvc;
using Api_Compra_e_Venda.Services;


namespace Api_Compra_e_Venda.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PortfolioController : ControllerBase {
        private readonly PortfolioService _service;

        public PortfolioController(PortfolioService service) {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetPortfolio() {
            return Ok(_service.GetPortfolio());
        }
    }
}