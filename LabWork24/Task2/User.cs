using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class User
    {
        private string _login;
        private string _password;

        public bool IsCorrectUserData(string login, string password, string passwordConfirmation)
        {
            bool isLoginCorrect = !string.IsNullOrWhiteSpace(login);
            bool isPasswordCorrect = !string.IsNullOrWhiteSpace(password);
            bool isConfirmCorrect = password == passwordConfirmation;

            return isLoginCorrect && isPasswordCorrect && isConfirmCorrect;
        }
    }
}
