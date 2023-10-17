using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class UserData
    {
        public static List<Usuario> GetUsers()
        {
            try
            {
                var db = new ApplicationDbContext();
                var users = db.Usuarios.OrderBy(x => x.Id).ToList();

                return users;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public static Usuario GetUserById(int userId, ApplicationDbContext context)
        {
            try
            {
                var user = context.Usuarios.Find(userId);

                return user;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void CreateUser(Usuario user)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Usuarios.Add(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void UpdateUser(Usuario user)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var userFound = GetUserById(user.Id, context);
                    context.Entry(userFound).CurrentValues.SetValues(user);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static void DeleteUser(int userId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = GetUserById(userId, context);

                    if (user != null)
                    {
                        context.Usuarios.Remove(user);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
