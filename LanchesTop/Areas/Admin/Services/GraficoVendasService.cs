using LanchesTop.Context;
using LanchesTop.Models;

namespace LanchesTop.Areas.Admin.Services
{
    public class GraficoVendasService
    {
        private readonly AppDbContext _context;

        public GraficoVendasService(AppDbContext context)
        {
            _context = context;
        }

        public List<LancheGrafico> GetVendasLanches(int dias=360)
        {
            var data = DateTime.Now.AddDays(-dias);

            var lanches = (from pd in _context.PedidoDetalhes
                           join l in _context.Lanches on pd.LancheId equals l.LancheId
                           where pd.Pedido.PedidoEnviado >= data
                           group pd by new { pd.LancheId, l.Nome }
                           into g
                           select new
                           {
                               LancheNome = g.Key.Nome,
                               LanchesQuantidade = g.Sum(q=> q.Quantidade),
                               LanchesValorTotal = g.Sum(p=>p.Preco)
                           });

            var listaLanchesGrafico = new List<LancheGrafico>();

            foreach(var item in lanches)
            {
                var lancheGrafico = new LancheGrafico();
                lancheGrafico.LancheNome = item.LancheNome;
                lancheGrafico.LanchesQuantidade = item.LanchesQuantidade;
                lancheGrafico.LanchesValorTotal = item.LanchesValorTotal;
                listaLanchesGrafico.Add(lancheGrafico);
            }

            if (listaLanchesGrafico.Any())
            {
                return listaLanchesGrafico;
            }
            return listaLanchesGrafico;
        }
    }
}
