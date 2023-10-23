using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Model
{
    public class Group : PropChange
    {
        private int id;
        private string numberGroup;
        private int headId;
        private int course;

        public Group(int id, string numberGroup, int headId, int course)
        {
            this.id = id;
            this.numberGroup = numberGroup;
            this.headId = headId;
            this.course = course;
        }

        public int Id {  get { return id; } 
            set 
            { 
                OnPropertyChanged(nameof(Id));
                id = value; 
            } 
        }
        public string NumberGroup { get {  return numberGroup; } 
            set 
            {  
                OnPropertyChanged(nameof(NumberGroup));
                numberGroup = value; 
            } 
        }
        public int HeadId { get { return headId; } 
            set 
            { 
                OnPropertyChanged(nameof(HeadId));
                headId = value; 
            } 
        }
        public int Course { get {  return course; } 
            set 
            { 
                OnPropertyChanged(nameof(Course));
                course = value; 
            } 
        }
    }
}
