using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class StudentValidation
    {
        public static Student IsThereStudent(User usr)
        {
            return StudentData.GetStudentByNumber(usr.FacNumber);
        }
        public static bool InsertStudentIfValid(Student s)
        {

            if (s.FirstName == "" || s.SecondName == "" || s.LastName == "" ||
                s.Faculty == "" || s.Specialty == "" || s.FacNumber == "" || s.Group== 0 ||
                  s.Potok == "" || s.OKS == 0 || s.StudentStatus == 0 || s.Course == 0)
            {
                return false;
            }
            if (StudentData.InsertStudent(s) == false)
            {
                return false;
            }
            return true;
            
        }
        public static string ValidateData(string name,string secondName,string lastName,string fakulty,string speciality,short OKS, short StudentStatus,string facNumber, short Course,string potok,string group)
        {
            string errData = String.Empty;
            
            if (name == string.Empty) 
            {
                errData += "Невалидна информация относно първото име!\n";
            }
            if (secondName == string.Empty)
            {
                errData += "Невалидна информация относно второто  име!\n";
            }
            if (lastName == string.Empty)
            {
                errData += "Невалидна информация относно фамилията !\n";
            }
            if (fakulty == string.Empty)
            {
                errData += "Невалидна информация относно факултета !\n";
            }
            if (speciality == string.Empty)
            {
                errData += "Невалидна информация относно специалността !\n";
            }
            if (OKS < 1 || OKS > 3)
            {
                errData += "Невалидна информация относно ОКС!\n";
            }
            if (StudentStatus < 1 || StudentStatus > 2)
            {
                errData += "Невалидна информация относно студентския статус!\n";
            }
            int tempFacNumber;
            bool temp=int.TryParse(facNumber,out tempFacNumber);
            if (facNumber.Length != 9 || temp==false)
            {
                errData += "Невалидна информация относно факултетния номер !\n";
            }
            if (Course < 1 || Course > 4)
            {
                errData += "Въвели сте невалидна информация относно курса!\n";
            }
            if (potok.Length > 5 || potok == string.Empty)
            {
                errData += "Невалидна информация относно потока!\n";
            } foreach (char a in name)
            {
                if (char.IsDigit(a))
                {
                    errData += "Моля ваведете коректно първо име,без цифри!\n";
                    break;
                }
            }
            foreach (char a in secondName)
            {
                if (char.IsDigit(a))
                {
                    errData += "Моля ваведете коректно второ име,без цифри!\n";
                    break;
                }
            }
            foreach (char a in lastName)
            {
                if (char.IsDigit(a))
                {
                    errData += "Моля ваведете коректно трето име,без цифри!\n";
                    break;
                }
            }
            foreach (char a in fakulty)
            {
                if (char.IsDigit(a))
                {
                    errData += "Моля ваведете коректен факултет,без цифри!\n";
                    break;
                }
            }
            foreach (char a in speciality)
            {
                if (char.IsDigit(a))
                {
                    errData += "Моля ваведете коректна специалност,без цифри!\n";
                    break;
                }
            }
            foreach (char a in potok)
            {
                if (char.IsLetter(a))
                {
                    errData += "Моля въведете коректен поток ,без букви!\n";
                    break;
                }
            }
            int tempGroup;
            bool tempGr=int.TryParse(group,out tempGroup);
            if (tempGr == false)
            {
                errData += "Невалидна информация относно групата!\n";
            }
            
            
            if (errData ==string.Empty)
            {
                return errData;
            }
            return errData;
        }
    }
      
}
