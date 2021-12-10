using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVM_Demo
{
    public class Person : ModelBase
    {
        string name;
        public string Name 
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }
        string vorname;
        public string Vorname
        {
            get { return vorname; }
            set
            {
                if (vorname != value)
                {
                    vorname = value;
                    OnPropertyChanged();

                }
            }
        }
    }
}
