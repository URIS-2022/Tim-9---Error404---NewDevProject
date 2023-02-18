using CustomerService1.Models;

namespace CustomerService1.ServiceCalls
{
    public interface IAdresaService
    {
        Task<AdresaDto> getAdresa(Guid adresaId);
    }
}
