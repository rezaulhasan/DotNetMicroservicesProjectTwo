using PlatformService.Models;

namespace PlatformService.Data{
    public interface IPlatformRepo {
        bool SaveChanges();

        IEnumerable<Platform> GetAllPlatroms();
    }
}