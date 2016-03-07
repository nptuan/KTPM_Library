using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class GoldUser : Users
    {
        protected override bool ConfirmUser(string Type)
        {
            if ("EBook" == Type || "Audio" == Type || "Film" == Type)
            {
                return true;
            }
            return false;
        }
    }
}