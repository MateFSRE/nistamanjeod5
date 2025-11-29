using Microsoft.EntityFrameworkCore;
using ZooWeb.Data;

namespace ZooWeb.Services
{
    public class NastambaService
    {
        private readonly ZooDbContext _db;

        public NastambaService(ZooDbContext db)
        {
            _db = db;
        }

        public async Task<List<Nastamba>> GetAllAsync()
        {
            return await _db.Nastambe.ToListAsync();
        }

        public async Task<Nastamba?> GetByIdAsync(int id)
        {
            return await _db.Nastambe.FindAsync(id);
        }

        public async Task CreateAsync(Nastamba n)
        {
            _db.Nastambe.Add(n);
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Nastamba n)
        {
            _db.Nastambe.Update(n);
            await _db.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var n = await _db.Nastambe.FindAsync(id);
            if (n == null) return;

            _db.Nastambe.Remove(n);
            await _db.SaveChangesAsync();
        }
    }
}
