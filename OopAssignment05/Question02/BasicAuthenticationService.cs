using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05_OOP.Question02
{
    internal class BasicAuthenticationService : IAuthenticationService
    {

        private User[] users;

        public BasicAuthenticationService() {
            users = new User[]
            {
                new User("admin" , "1234" , "Administrator") ,
                new User("user" , "abcd" , "User")
            };
        }
        public bool AuthenticateUser(string username , string password)
        {
            foreach (var user in users) {    //var دي يعني خلي الكومبايلر هو الي يستنتج نوع المتغير من القيمه اللي بتحطها فيه 
                // (User user in users ) بدل دي استخدمنا var
              if (user.Username == username && user.Password==password) 
                    return true;
            }
              return false;
        }

        public bool AuthorizeUser(string usernamw , string role)
        {
            foreach (var user in users) { 
               if(user.Username == usernamw && user.Role == role)
                    return true;
            }
            return false;
        }

    }
}
