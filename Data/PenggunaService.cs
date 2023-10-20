using PenggunaSampah.DataContext;
using PenggunaSampah.Models;
using Microsoft.EntityFrameworkCore;

namespace PenggunaSampah.Data
{
    public class PenggunaService
    {

        private readonly ApplicationDbContext _applicationDbContext;

        public PenggunaService(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        //List of Pengguna
        public async Task<List<PenggunaModel>> GetAllPengguna()
        {
            return await _applicationDbContext.Pengguna.ToListAsync();
        }

        //Add  Pengguna
        public async Task<bool> InsertPengguna(PenggunaModel pengguna)
        {
            await _applicationDbContext.Pengguna.AddAsync(pengguna);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Get Pengguna By Id  
        public async Task<PenggunaModel> GetPenggunaById(int id)
        {
            PenggunaModel pengguna = await _applicationDbContext.Pengguna.FirstOrDefaultAsync(c => c.Id.Equals(id));
            return pengguna;
        }

        //Update Pengguna
        public async Task<bool> UpdatePengguna(PenggunaModel pengguna)
        {
            _applicationDbContext.Pengguna.Update(pengguna);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

        //Delete Pengguna
        public async Task<bool> DeletePengguna(PenggunaModel pengguna)
        {
            _applicationDbContext.Pengguna.Remove(pengguna);
            await _applicationDbContext.SaveChangesAsync();
            return true;
        }

    }
}
