using CustomerService1.Models;

namespace CustomerService1.ServiceCalls
{
    public interface IOvlascenoLiceService
    {
        Task<OvlascenoLiceDto> getOvlascenoLice(Guid ovlascenoLice);
    }
}
