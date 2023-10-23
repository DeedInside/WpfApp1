using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Student : PropChange
    {
        private int id;
        private string name;
        private string group;
        private int age;

        public Student(int id, string name, string group, int age)
        {
            this.id = id;
            this.name = name;
            this.group = group;
            this.age = age;
        }

        public int Id { get { return id; } 
            set 
            {  
                OnPropertyChanged(nameof(Id));
                id = value; 
            } 
        }
        public string Name { get { return name; } 
            set 
            { 
                OnPropertyChanged(nameof(Name));
                name = value; 
            } 
        }
        public int Age { get { return age; } 
            set 
            { 
                OnPropertyChanged(nameof(Age));
                age = value; 
            } 
        }
        public string Group { get { return group; } 
            set 
            { 
                OnPropertyChanged(nameof(Group));
                group = value; 
            } 
        }

    }
}
