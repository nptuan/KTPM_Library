using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace Library
{
    public abstract class Resource
    {
        protected bool _isPublic { get; set; }
        protected string _name { get; set; }
                   
        public abstract Resource Upload(string Name);
        public abstract Resource Clone(string Name);
        public Resource Share()
        {
            if (_isPublic)
                return this;
            return null;
        }
        protected void EnableSharing()
        {
            _isPublic = true;
        }
    }
}