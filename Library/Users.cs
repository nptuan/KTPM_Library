using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public abstract class Users
    {
        protected Dictionary<string, Resource> prototypes = new Dictionary<string, Resource>();
        public void InitResourcePrototype()
        {
            prototypes.Add("EBook", new EBook("EBook Prototype"));
            prototypes.Add("Audio", new Audio("Audio Prototype"));
            prototypes.Add("Film", new Film("Film Prototype"));
            prototypes.Add("Software", new Software("Software Prototype"));
        }
        public Resource UploadResource(string Type,string Name)
        {
            if (ConfirmUser(Type))
            {
                if (IsInPrototypes(Type))
                    return prototypes[Type].Clone(Name);
            }
            return null;
        }
        protected abstract bool ConfirmUser(string Type);
        private bool IsInPrototypes(string Type)
        {
            return prototypes.ContainsKey(Type);
        }        
    }
}