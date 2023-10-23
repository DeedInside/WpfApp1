using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.DataContext
{
    public static class DataBase
    {
        public static ObservableCollection<Group> groups = new ObservableCollection<Group>()
        {
            new Group(1, "a1", 1, 1),
            new Group(2, "b1", 2, 1),
            new Group(3, "a2", 3, 2)
        };
        public static ObservableCollection<Student> students = new ObservableCollection<Student>(){
            new Student(1, "Ivan_1", groups[1].NumberGroup,17),
            new Student(2, "Ivan_2", groups[1].NumberGroup,16),
            new Student(3, "Ivan_3", groups[2].NumberGroup,17),
            new Student(4, "Ivan_4", groups[2].NumberGroup,18),
            new Student(5, "Ivan_5", groups[0].NumberGroup,17),
            new Student(6, "Ivan_6", groups[0].NumberGroup, 16)

        };
    }
}
