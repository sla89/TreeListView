using System.Collections.Generic;
using System.Windows;

namespace TreeListViewApp
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var persons = new List<Person>();

            for (int i = 0; i < 1000; i++)
            {
                var person = new Person
                {
                    FirstName = string.Format("{0} {1}", "Hans", i),
                    LastName = "Wurst",
                    Contacts = new List<Contact>()
                };

                for (int j = 0; j < 100; j++)
                {
                    person.Contacts.Add(new Contact { FirstName = string.Format("{0} {1}", "Contact", j), LastName = "-" });
                }

                persons.Add(person);
            }

            DataContext = persons;
        }
    }
}
