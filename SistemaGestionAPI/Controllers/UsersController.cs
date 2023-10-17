using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaGestionBusiness;
using SistemaGestionEntities;

namespace SistemaGestionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<Usuario> Get()
        {
            return UserBusiness.GetUsers();
        }
        [HttpPost(Name = "CreateUser")]
        public void Post([FromBody] Usuario user)
        {
            UserBusiness.CreateUser(user);
        }
        [HttpPut(Name = "UpdateUser")]
        public void Put([FromBody] Usuario user)
        {
            UserBusiness.UpdateUser(user);
        }
        [HttpDelete(Name = "DeleteUser")]
        public void Delete([FromBody] int userId)
        {
            UserBusiness.DeleteUser(userId);
        }
    }
}
