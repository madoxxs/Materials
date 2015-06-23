using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class RegistarValidation
    {
       public static bool InsertUserIfValid(User user)
        {
            if (user.Username == "" || user.Username.Length < 4 || user.Password == "" ||
                user.Password.Length < 6 || user.FacNumber == "" || user.Role == 0)
            {
                return false;
            }
            else
            {
                if (UserData.InsertUserData(user))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
      
        public static string ValidateRegisterData(string username, string password,string facNumber)
        {
            string errData = String.Empty;
            if (username == string.Empty || username.Length<4)
            {
                errData += "Невалидна информация относно първото име!\n";
            }
            
            
            
            if (password == string.Empty ||  password.Length<6 )
            {
                errData += "Невалидна информация относно паролата";
            }
            int tempFacNumber;
            bool temp = int.TryParse(facNumber, out tempFacNumber);
            if (facNumber.Length != 9 || temp == false)
            {
                errData += "Невалидна информация относно факултетния номер !\n";
            }
            
           
            if (errData == string.Empty)
            {
                return errData;
            }
            return errData;
        }
    }
}
