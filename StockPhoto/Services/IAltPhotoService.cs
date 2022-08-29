using StockPhoto.Entities;

namespace StockPhoto.Services
{
    public interface IAltPhotoService
    {
        public Task<AltPhoto> GetPhotoByIdAsync(int id);

        public Task<(bool IsSuccess, Exception? Exception)> InsertPhotoAsync(AltPhoto photo);

        public Task<bool> PhotoExistsAsync(int id);
    }
}