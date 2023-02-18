using ServiceParcela.DtoModels;

namespace ServiceParcela.ServiceCalls
{
    public interface IKupacService
    {
        Task<KupacDto> getKupci(Guid kupacId);

    }
}
