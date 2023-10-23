using SistemaGestionData;
using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionBusiness
{
    public class UserBusiness
    {
        public static List<Usuario> GetUsers()
        {
            return UserData.GetUsers();
        }
        public static Usuario GetUserById(int userId)
        {
            return UserData.GetUserById(userId);
        }
        public static bool ValidateUserCredentials(string Mail, string Contraseña)
        {
            try
            {
                var user = UserData.GetUserByMail(Mail);

                if (user != null && user.Contraseña == Contraseña)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateUser(Usuario user)
        {
            UserData.CreateUser(user);
        }
        public static void UpdateUser(int userId, Usuario user)
        {
            UserData.UpdateUser(userId, user);
        }
        public static void DeleteUser(int userId)
        {
            UserData.DeleteUser(userId);
        }
    }
}
