using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StudentInfoSystem.Data;

namespace StudentInfoSystem.Logic
{
    class LoginValidation
    {
        private string _username;
        private string _password;


        public string errText { get; private set; }
        public LoginValidation(string username, string pass)
        {
            _username = username;
            _password = pass;
            errText = string.Empty;
        }
        private bool isEmpty(string s)
        {
            if (s.Length > 0)
            {
                return false;
            }
            else 
            {
                return true;
            }
            
        }//validaciq dali e prazen
        private bool isShorterThan(string s, int minLenght)
        {
            if (s.Length < minLenght)
            {
                return true;

            }
            else
                return false;
        }
        public bool ValidateUserInput(out User user)
        {
            User queryResult = UserData.IsUserPassCorrect(_username, _password);
            // returns the user role
            user = queryResult;
            if (queryResult == null)
            {
                errText += "Въвели сте грешно потребителско име или парола!";
                return false;
            }
            
            
            if (isEmpty(_username))
            {
                errText = "Ne ste vaveli username!";
                return false;
            }
            else if (isEmpty(_password))
            {
                errText = "Ne ste vaveli password!";
                return false;
            }
            else if (isShorterThan(_username, 4))
            {
                errText = "Molq vavedete po dalgo username!";
                return false;
            }
            else if (isShorterThan(_password, 6))
            {
                errText = "Molq vavedete po dalga parola!";
                return false;
            }
           
            return true;
        }
        
    }
}
    

