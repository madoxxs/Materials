using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace StudentInfoSystem.Data
{
    class StudentData
    {
        public static Student GetStudentByNumber(string fakNumber)
        {
            StudentsDataContext dc = new StudentsDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where (students.FacNumber == fakNumber)
                               select students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return queryResult[0];
            }
            else
            {
                return null;
            }
        }
        public static bool InsertStudent(Student s)
        {
            StudentsDataContext dc = new StudentsDataContext();
            try
            {
                dc.AddNewStudent(s.FirstName, s.SecondName, s.LastName, s.Faculty, s.Specialty, s.OKS, s.StudentStatus,
                s.FacNumber, s.Course, s.Potok, s.Group);
                dc.SubmitChanges();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool _IfFacNumberExist(string facNumber)
        {
            StudentsDataContext dc = new StudentsDataContext();
            var queryResult = (from students in dc.GetTable<Student>()
                               where (students.FacNumber == facNumber)
                               select students).ToArray<Student>();
            if (queryResult.Count<Student>() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<int> GetGroups()
        {
            StudentsDataContext dc = new StudentsDataContext();
            var res = (from Student in dc.GetTable<Student>()
                       select Student.Group).Distinct().ToList<int>();
            return res;
        }
        
    }
}
