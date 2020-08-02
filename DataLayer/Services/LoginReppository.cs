using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class LoginReppository : ILoginRepository
    {
        MyCmsContext db ;
        public LoginReppository(MyCmsContext contex)
        {
            db = contex;
        }

        public bool IsExitUser(string username, string password)
        {
            return db.AdminLogins.Any(u => u.UserName == username && u.Password == password);
        }
    }
}
