using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Entities.School;
using WebApi_Entities.Avatar;

namespace WebApi_Services
{
    public class ServiceClearExtraData
    {
        public void CleanClassrooms(IQueryable<Classroom> classrooms)
        {
            foreach (var Classroom in classrooms)
            {
                foreach (var Student in Classroom.Students)
                {
                    Student.Avatar.Students = new List<Student>();
                    Student.Avatar.Hair.Avatar = new List<Avatar>();
                    Student.Avatar.Clothing.Avatar = new List<Avatar>();
                    Student.Avatar.Body.Avatar = new List<Avatar>();
                }
            }
        }
        public void CleanClassroom(Classroom classroom)
        {

            foreach (var Student in classroom.Students)
            {
                Student.Avatar.Students = new List<Student>();
                Student.Avatar.Hair.Avatar = new List<Avatar>();
                Student.Avatar.Clothing.Avatar = new List<Avatar>();
                Student.Avatar.Body.Avatar = new List<Avatar>();
            }

        }





        public void CleanSchools(IQueryable<School> schools)
        {
            foreach (var school in schools)
            {
                foreach (var classroom in school.Classrooms)
                {
                    foreach (var Student in classroom.Students)
                    {
                        Student.Avatar.Students = new List<Student>();
                        Student.Avatar.Hair.Avatar = new List<Avatar>();
                    Student.Avatar.Body.Avatar = new List<Avatar>();
                    Student.Avatar.Clothing.Avatar = new List<Avatar>();
                        Student.Avatar.Background.Avatar = new List<Avatar>();

                    }
                }
            }

        }
        public void CleanSchool(School school)
        {
            foreach (var classroom in school.Classrooms)
            {
                foreach (var Student in classroom.Students)
                {
                    Student.Avatar.Students = new List<Student>();
                    Student.Avatar.Hair.Avatar = new List<Avatar>();
                    Student.Avatar.Body.Avatar = new List<Avatar>();
                    Student.Avatar.Clothing.Avatar = new List<Avatar>();
                    Student.Avatar.Background.Avatar = new List<Avatar>();
                }
            }


        }

        public void CleanPaintings(IQueryable<Painting> paintings)
        {
            foreach (var painting in paintings)
            {
                painting.Student.Avatar.Students = new List<Student>();
                painting.Student.Avatar.Hair.Avatar = new List<Avatar>();
                painting.Student.Avatar.Background.Avatar = new List<Avatar>();
                painting.Student.Classroom.Students = new List<Student>();
               
            }

        }
        public void CleanPainting(Painting painting)
        {

            painting.Student.Avatar.Students = new List<Student>();
            painting.Student.Avatar.Hair.Avatar = new List<Avatar>();
            painting.Student.Avatar.Background.Avatar = new List<Avatar>();
            painting.Student.Classroom.Students = new List<Student>();



        }


        public void CleanStudents(IQueryable<Student> students)
        {
            foreach (var student in students)
            {
                student.Avatar.Students = new List<Student>();
                student.Avatar.Background.Avatar = new List<Avatar>();
                student.Avatar.Hair.Avatar = new List<Avatar>();
                student.Avatar.Body.Avatar = new List<Avatar>();
                student.Avatar.Clothing.Avatar = new List<Avatar>();
                student.Classroom.Students = new List<Student>();
                student.Classroom.School.Classrooms = new List<Classroom>();
            }

        }
        public void CleanStudent(Student student)
        {
            student.Avatar.Students = new List<Student>();
            student.Avatar.Hair.Avatar = new List<Avatar>();
            student.Avatar.Background.Avatar = new List<Avatar>();
            student.Avatar.Clothing.Avatar = new List<Avatar>();
            student.Avatar.Body.Avatar = new List<Avatar>();
            student.Classroom.Students = new List<Student>();
            student.Classroom.School.Classrooms = new List<Classroom>();
        }



        public void CleanAvatars(IQueryable<Avatar> avatars)
        {
            foreach (var avatar in avatars)
            {
                avatar.Hair.Avatar = new List<Avatar>();
                avatar.Body.Avatar = new List<Avatar>();
                avatar.Clothing.Avatar = new List<Avatar>();
                avatar.Background.Avatar = new List<Avatar>();
                foreach (var student in avatar.Students)
                {
                    student.Classroom.Students = new List<Student>();

                }

            }

        }
        public void CleanAvatar(Avatar avatar)
        {

            avatar.Hair.Avatar = new List<Avatar>();
            avatar.Body.Avatar = new List<Avatar>();
            avatar.Clothing.Avatar = new List<Avatar>();
            avatar.Background.Avatar = new List<Avatar>();
            foreach (var student in avatar.Students)
            {
                student.Classroom.Students = new List<Student>();

            }



        }


    }
}
