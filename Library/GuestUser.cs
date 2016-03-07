using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class GuestUser : Users
    {
        protected override bool ConfirmUser(string Type)
        {
            if ( "EBook" == Type)
            {
                return true;
            }
            return false;
        }
    }
}