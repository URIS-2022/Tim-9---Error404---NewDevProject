using CustomerService1.Models;

namespace CustomerService1.ServiceCalls
{
    public interface IJavnoNadmetanjeService
    {
        Task<JavnoNadmetanjeDto> getJavnoNadmetanje(Guid javnoNadmetanjeId);
    }
}
