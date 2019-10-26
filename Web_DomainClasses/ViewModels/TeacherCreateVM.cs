using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DomainClasses.Entities.School;

namespace Web_DomainClasses.ViewModels
{
    public class TeacherCreateVM
    {
        public Teacher Teacher { get; set; }
        public int SelectedClassroomID { get; set; }
        public ICollection<Classroom> Classrooms { get; set; } 
    }
}
