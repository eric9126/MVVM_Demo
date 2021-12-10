using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public class MainWindowViewModel
    {
        public Person Person { get; set; }
        public static ObservableCollection<Person> PersonList { get; set; }

        public MainWindowViewModel()
        {
            Person = new Person
            {
                Name = "Test",
                Vorname = "Tester"
            };

            PersonList = new ObservableCollection<Person>
            {                

                new Person()
                {
                    Name = "Muster",
                    Vorname = "Musterfrau"
                },

                new Person()
                {
                    Name = "Muster",
                    Vorname = "Mustermann"
                }
            };


        }

        
    }
}
