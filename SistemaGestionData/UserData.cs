using Microsoft.EntityFrameworkCore;
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
        public static Usuario GetUserById(int userId)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = context.Usuarios.Find(userId);

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public static Usuario GetUserByMail(string Mail)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var user = context.Usuarios.FirstOrDefault(u => u.Mail == Mail);

                    return user;
                }
            }
            catch  (Exception ex)
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
        public static void UpdateUser(int userId, Usuario user)
        {
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    var userFound = context.Usuarios.Find(userId);

                    if (userFound != null)
                    {
                        userFound.Id = userFound.Id;
                        userFound.Nombre = user.Nombre;
                        userFound.Apellido = user.Apellido;
                        userFound.NombreUsuario = user.NombreUsuario;
                        userFound.Contraseña = user.Contraseña;
                        userFound.Mail = user.Mail;

                        context.SaveChanges();
                    }
                    else
                    {
                        throw new InvalidOperationException($"User with ID {user.Id} not found.");
                    }
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
                    var user = GetUserById(userId);

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
