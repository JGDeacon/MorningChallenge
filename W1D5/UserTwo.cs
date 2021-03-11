using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D5
{
    class UserTwo:User
    {
        public UserTwo()
        {
            //you can not edit an inherited property that doesn't have a "set" method
           int numbID = ID;
            GetUserFullName("Collin", "Marone");
        }
    }
}
