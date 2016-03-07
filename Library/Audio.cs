using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public class Audio : Resource
    {
        public Audio(string Name)
        {
            _name = Name;
            _isPublic = false;
        }
        public override Resource Upload(string Name)
        {
            Audio audio = new Audio(Name);
            audio.EnableSharing();
            return audio;
        }
        public override Resource Clone(string Name)
        {
            return new Audio(Name);
        }
    }
}