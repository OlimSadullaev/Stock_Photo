using StockPhoto.Data;
using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public class AltPhotoService : IAltPhotoService
    {
        private readonly StockPhotoDbContext _ctx;

        public AltPhotoService (StockPhotoDbContext context)
        {
            _ctx = context;
        }

        public Task<AltPhoto> GetPhotoByIdAsync(int id)
        => _ctx.Photos.FirstOrDefaultAsync(m => m.Id == id);

        public async Task<(bool IsSuccess, Exception? Exception)> InsertPhotoAsync(AltPhoto photo)
        {
            try
            {
                await _ctx.Photos.AddAsync(photo);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }

        public Task<bool> PhotoExistsAsync(int id)
        => _ctx.Photos.AnyAsync(m => m.Id == id);

        public async Task<(bool IsSuccess, Exception Exception)> UpdatePhotoAsync(AltPhoto altPhoto)
        {
            try
            {
                _ctx.Photos.Update(altPhoto);
                await _ctx.SaveChangesAsync();
                return (true, null);
            }
            catch(Exception e)
            {
                return (false, e);
            }
        }

    }
}
