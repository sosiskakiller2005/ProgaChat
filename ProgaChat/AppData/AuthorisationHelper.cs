using ProgaChat.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgaChat.AppData
{
    internal class AuthorisationHelper
    {
        private static ProgaChatDbEntities _context = App.GetContext();
        public static User selectedUser;
        public static bool isLoggedIn = false;
        /// <summary>
        /// Авторизует пользователя
        /// </summary>
        /// <param name="login"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public static bool Authorise(string login, string password)
        {
            List<User> users = _context.User.ToList();

            if (login == "" && password == "")
            {
                MessageBoxHelper.Error("Введите логин и пароль");
                isLoggedIn = false;
                return false;
            }
            else if (login == "")
            {
                MessageBoxHelper.Error("Введите логин");
                isLoggedIn = false;
                return false;

            }
            else if (password == "")
            {
                MessageBoxHelper.Error("Введите пароль");
                isLoggedIn = false;
                return false;
            }
            else
            {
                foreach (User user in users)
                {
                    if (user.Login == login && user.Password == password)
                    {
                        selectedUser = user;
                        isLoggedIn = true;
                        return true;
                    }
                }
                if (selectedUser != null)
                {
                    return true;
                }
                else
                {
                    MessageBoxHelper.Error("Неправильно введен логин или пароль");
                    isLoggedIn = false;
                    return false;
                }
            }
        }
    }
}
