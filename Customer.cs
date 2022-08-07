using System;
using System.Collections.Generic;
using System.Text;


namespace PTSLibrary
{
    [Serializable]
  public class Customer : User
    {
        public Customer() { }
        public Customer(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
    }
}
