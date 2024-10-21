using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Login
{
    internal interface IAccount
    {
        public void ShowfullInfo(User user);
        public bool PasswordCheck(string password);
        
            
        
    }
}
