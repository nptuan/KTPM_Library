using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class EBook : Resource
    {
        public EBook(string Name)
        {
            _name = Name;
            _isPublic = false;
        }

        public override Resource Upload(string Name)
        {
            EBook ebook = new EBook(Name);
            ebook.EnableSharing();
            return ebook;
        }
        public override Resource Clone(string Name)
        {
            return new EBook(Name);
        }
    }
}