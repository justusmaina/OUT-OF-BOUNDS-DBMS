using System;
using System.Collections.Generic;
using System.Text;

namespace PTSLibrary
{
    [Serializable]
    public class User
    {
        protected string name;
        protected int id;

        public string Name
        {
            get { return name; }
        }
        public int Id
        {
            get { return id; }
        }
    }
}
