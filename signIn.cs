using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WelcomeApp
{
    public class signIn
    {
        public string Authenticate(string username, string password)
        {
            string msg;
            if ((string.IsNullOrEmpty(username)) || string.IsNullOrEmpty(password))
                {
                msg = "User name and Password required";

            }
            else
            {
                if ((username=="admin")&& (password=="admin@123"))
                {
                    msg = "Authentication Pass";
                }
                else
                {
                    msg = "Failed";
                }

            }
            return msg;
        }
    }
}
