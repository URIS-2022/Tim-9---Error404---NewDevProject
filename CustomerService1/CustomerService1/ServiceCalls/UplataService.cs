using CustomerService1.Models;

namespace CustomerService1.ServiceCalls
{
    public class UplataService : IUplataService
    {
        public UplataService() { }
        public Task<UplataDto> getUplata(Guid uplataId)
        {
            UplataDto uplata = new UplataDto();
            uplata.UplataID = Guid.Parse("a215e4cb-a427-40cf-88b2-8488d140a939");
            uplata.Iznos= 999;

            return Task.FromResult<UplataDto>(uplata);
        }
    }
}
