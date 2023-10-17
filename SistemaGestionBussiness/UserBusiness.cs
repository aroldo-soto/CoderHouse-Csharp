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
        public static void CreateUser(Usuario user)
        {
            UserData.CreateUser(user);
        }
        public static void UpdateUser(Usuario user)
        {
            UserData.UpdateUser(user);
        }
        public static void DeleteUser(int userId)
        {
            UserData.DeleteUser(userId);
        }
    }
}
