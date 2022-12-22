using LanchesTop.Areas.Admin.Services;
using Microsoft.AspNetCore.Mvc;

namespace LanchesTop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminGraficoController : Controller
    {
        private readonly GraficoVendasService _graficoVendas;

        public AdminGraficoController(GraficoVendasService graficoVendas)
        {
            _graficoVendas = graficoVendas ?? throw new ArgumentNullException(nameof(graficoVendas));
        }

        public JsonResult VendasLanches(int dias)
        {
            var lanchesVendasTotais = _graficoVendas.GetVendasLanches(dias);
            return Json(lanchesVendasTotais);
 
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasSemanal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult VendasGraficoNotFound(int dias)
        {
            ViewData["Mensagem"] = $"Não foi possível localizar vendas nos últimos {dias} dias para montar o gráfico.";
            return View(dias);
        }

        
    }
}
