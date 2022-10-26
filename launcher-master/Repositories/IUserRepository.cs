using launcher_master.Models;
using System.Collections.Generic;
using System.Net;

namespace launcher_master.Repositories
{
    public interface IUserRepository
    {
        bool AuthenticateUser(NetworkCredential credential);
        void Add(UserModel userModel);
        void Edit(UserModel userModel);
        void Remove(int id);
        UserModel GetById(int id);
        UserModel GetBySurname(string username);
        IEnumerable<UserModel> GetByAll();
    }
}
