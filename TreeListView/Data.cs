using System.Collections.Generic;

namespace TreeListViewApp
{
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Contact> Contacts { get; set; }
    }


    public class Contact : Person
    {

        public bool Test { get; set; }
    }
}
