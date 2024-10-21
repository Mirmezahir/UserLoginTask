namespace User_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cixis= false;
            bool deyisen = false;
            User user1= null;
            do
            {
                
                Console.WriteLine("                           [ USER LOGIN ]                       ");

                Console.Write("Fullname : ");
                string name = Console.ReadLine();
                name.Trim();
                Console.Write("E-mail : ");
                string email = Console.ReadLine();
                email.Trim();
                Console.WriteLine("Sifre teyin edin !\n-Sifre en az 8 simvol ibaret olmalidir\n-En az bir reqem olmalidir\n-En az bir boyuk" +
                    "herf olmalidir\n-En az bir kicik herf olmalidir\n-En az bir reqem olmalidir!!!");
                Console.Write("Password : ");
                do
                {
                    string password = Console.ReadLine();
                    password.Trim();
                   user1 = new User(name, email, password);
                    user1.PasswordCheck(password);
                   
                } while (!user1.IsPasswordCorrect);
                User user = user1;
              
                Console.WriteLine("Press 0 for EXIT\nPress 1 for Information about User");
                int secim;
                do
                {
                  deyisen = int.TryParse(Console.ReadLine(), out secim);

                    switch (secim)
                    {
                        case 0: cixis = true;     deyisen = true; break;



                            case 1:
                            user.ShowfullInfo(user);
                    break;
                    
                    
                    }




                } while (!deyisen);














            } while (!cixis);
            
        }
    }
}
