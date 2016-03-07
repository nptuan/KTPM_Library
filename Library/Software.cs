using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Software : Resource
    {
        public Software(string Name)
        {
            _name = Name;
            _isPublic = false;
        }
        public override Resource Upload(string Name)
        {
            Software software = new Software(Name);
            software.EnableSharing();
            return software;
        }
        public override Resource Clone(string Name)
        {
            return new Software(Name);
        }
    }
}