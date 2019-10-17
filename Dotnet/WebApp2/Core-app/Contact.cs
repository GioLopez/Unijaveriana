using System;

namespace Core_app
{
    public class Contact
    {

        public String Name { get; set; }
        public String Email { get; set; }

        public Boolean SetName(String Name)
        {
            this.Name = Name;
            return true;
        }
    }
}
