using Microsoft.EntityFrameworkCore;
using MVC2022.Context;
using MVC2022.Models;
using MVC2022.Repositories.Interfaces;

namespace MVC2022.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;

        public LancheRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.Where(p => p.IsLanchePreferido).Include(c => c.Categoria);
        public Lanche GetLancheById(int LancheId)
        {
            return _context.Lanches.FirstOrDefault(I => I.LancheId == LancheId);
        } 
       
    }
}
