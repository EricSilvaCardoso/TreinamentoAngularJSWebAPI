using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NgTodoList.Domain.Repository
{
    public interface IUserRepository : IDisposable
    {
        User Get(string email);
        void SaveOrUpdate(User user);
        void Delete(int id);
    }
}
