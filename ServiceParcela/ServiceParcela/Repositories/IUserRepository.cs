namespace ServiceParcela.Repositories
{
    public interface IUserRepository
    {
        bool checkIfUserExists(string username, string password);
    }
}
