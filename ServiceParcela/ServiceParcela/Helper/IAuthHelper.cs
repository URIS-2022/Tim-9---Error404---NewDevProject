using ServiceParcela.DtoModels;

namespace ServiceParcela.Helper
{
    public interface IAuthHelper
    {
        public bool authenticatePrincipal(Principal principal);
        public string generateJWT(Principal principal);
    }
}
