using System.Collections.Generic;
using Web_DomainClasses.Entities.School;

namespace Web_DomainClasses.ViewModels
{
    public class ClassroomCreateVM
    {
        public Classroom Classroom { get; set; }
        public int SelectedSchoolID { get; set; }
        public ICollection<School> Schools { get; set; }
        public int SelectedTeacherID { get; set; }

        public ICollection<Teacher> Teachers { get; set; }

    }
}
