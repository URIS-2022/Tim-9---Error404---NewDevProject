using CustomerService1.Models;

namespace CustomerService1.ServiceCalls
{
    public interface IUplataService
    {
        Task<UplataDto> getUplata(Guid uplataId);
    }
}
