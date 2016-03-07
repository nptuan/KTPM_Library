using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Film : Resource
    {
        public Film(string Name)
        {
            _name = Name;
            _isPublic = false;
        }
        public override Resource Upload(string Name)
        {
            Film film = new Film(Name);
            film.EnableSharing();
            return film;
        }
        public override Resource Clone(string Name)
        {
            return new Film(Name);
        }
    }
}