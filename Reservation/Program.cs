using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservation
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        public class Reservation
        {
            public User MadeBy { get; set; }
            public bool CanBeCancelledBy(User user)
            {
                if (user.IsAdmin)
                    return true;
                if (user == MadeBy)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public class User
        {
            public bool IsAdmin { get; set; }
        }
    }
}
