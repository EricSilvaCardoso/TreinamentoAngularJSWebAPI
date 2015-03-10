using NgTodoList.Domain.Repository;
using System.Linq;
using NgTodoList.Domain;
using NgTodoList.Data.Context;
using System.Data.Entity;

namespace NgTodoList.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private NgTodoListDataContext _context;

        public UserRepository(NgTodoListDataContext context)
        {
            _context = context; 
        }
        public User Get(string email)
        {
            return _context.Users.Where(x => x.Email.ToLower() == email.ToLower()).FirstOrDefault();
        }

        public void SaveOrUpdate(User user)
        {
            if (user.Id == 0)
            {
                _context.Users.Add(user);
            }
            else
            {
                _context.Entry<User>(user).State = EntityState.Modified;
            }

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Users.Remove(_context.Users.Find(id));
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
