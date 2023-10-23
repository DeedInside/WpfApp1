using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.Model;

namespace WpfApp1.ViewModel
{
    public class MyMain: PropChange
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Group> Groups { get; set; }
        private Group selectGroup;
        public Group SelectGroup 
        { 
            get 
            {
                return selectGroup;
            } 
            set 
            {
                ChoouseStudent(value.NumberGroup);
                selectGroup = value;
                OnPropertyChanged(nameof(SelectGroup));
            } 
        }
        private ObservableCollection<Student> chouseStudent;
        public ObservableCollection<Student> ChouseStudent
        {
            get
            {
                return chouseStudent;
            }
            set
            {
                chouseStudent = value;
                OnPropertyChanged(nameof(ChouseStudent));
            }
        }
        private Student choouseStydent;
        public Student ChoouseStydent
        {
            get
            {
                return choouseStydent;
            }
            set
            {
                choouseStydent = value;
                OnPropertyChanged(nameof(ChoouseStydent));
            }
        }
        private RelayCommand removeCommand;
        public RelayCommand RemoveCommand
        {
            get
            {
                return removeCommand ??
                  (removeCommand = new RelayCommand(obj =>
                  {
                      Students.Remove(ChoouseStydent);
                      ChouseStudent.Remove(ChoouseStydent);
                  }));
            }
        }
        public MyMain() 
        {
            Groups = new ObservableCollection<Group>(DataContext.DataBase.groups);
            Students = new ObservableCollection<Student>(DataContext.DataBase.students);
        }

        private void ChoouseStudent(string group)
        {
            ChouseStudent = new ObservableCollection<Student>(Students.Where(q => q.Group == group));
        }

    }
}
