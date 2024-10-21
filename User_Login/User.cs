using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Login
{
    internal class User:IAccount
    {
        User[] Users= new User[0];
       private int _id;
        public int ID { get; set; }
        public string FullName;
        public string Email;
        public string Password;
        public bool IsPasswordCorrect;

        public User(string fullName, string email, string password)
        {
            ++_id;
            ID = _id;
            FullName = fullName;
            Email = email;
            Password = password;
            
        }
        public void UserADD(User user)
        {
            Array.Resize(ref Users, +1);
            Users[Users.Length-1] = user;
        }
        
        public void ShowfullInfo(User user)
        {
            Console.WriteLine($"ID :{user.ID}\nFULLNAME : {user.FullName}\nEMAIL :{user.Email}\nPASSWORD:{user.Password}");
            
        }

        public bool PasswordCheck(string password)
        {
            bool correctpassword=false;
            int boyukherf = 0;
            int kicikherf = 0;
            int reqem = 0;
            
            
                
                
                for (int i = 0;i<password.Length;i++)
                {
                    
                    if (Char.IsDigit(password[i]))
                    {
                        reqem ++;
                    }
                    if (Char.IsUpper(password[i]))
                    {
                        boyukherf ++;
                    }
                    if(Char.IsLower(password[i]))
                    {
                        kicikherf ++;
                    }
                    
                }
            if (password.Length < 7)
            {
                Console.WriteLine("Sifre de minimum 8 simvol olmalidir");


            }
            else if (reqem < 1)
            {
                Console.WriteLine("Sifrede en az bir reqem olmalidi");
               
            }
            else if (boyukherf < 1)
            {
                Console.WriteLine("Sifrede en az bir boyuk herf olmalidi");
                
            }
            else if (kicikherf < 1)
            {
                Console.WriteLine("Sifrede en az bir kicik herf olmalidi");
                
            }
            else
            {
                Console.WriteLine("Sifreniz teyin olundu");
                correctpassword = true;
               
            }
            IsPasswordCorrect=correctpassword;  


            return IsPasswordCorrect;
        }
    }
}
