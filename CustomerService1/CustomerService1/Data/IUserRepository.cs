namespace CustomerService1.Data
{
    public interface IUserRepository
    {
        bool checkIfUserExists(string username, string password);

    }
}
