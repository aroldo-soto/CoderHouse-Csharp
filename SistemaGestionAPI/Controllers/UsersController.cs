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
        public class LoginRequest
        {
            public string Mail { get; set; }
            public string Contraseña { get; set; }
        }
        [HttpGet]
        public IActionResult GetUsers()
        {
            try
            {
                var users = UserBusiness.GetUsers();

                return Ok(users);
            } catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("{userId}")]
        public IActionResult GetUserById(int userId)
        {
            try
            {
                var user = UserBusiness.GetUserById(userId);
                if (user != null)
                {
                    return Ok(user);
                }
                else
                {
                    return NotFound("User not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpGet("Name/{userId}")]
        public IActionResult GetUserNameById(int userId)
        {
            try
            {
                var user = UserBusiness.GetUserById(userId);
                if (user != null)
                {
                    return Ok(user.Nombre);
                }
                else
                {
                    return NotFound("User not found.");
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost]
        public IActionResult CreateUser([FromBody] Usuario user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data.");
            }

            try
            {
                UserBusiness.CreateUser(user);

                return Ok("Usuario creado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest loginRequest)
        {
            try
            {
                if (string.IsNullOrEmpty(loginRequest.Mail) || string.IsNullOrEmpty(loginRequest.Contraseña))
                {
                    return BadRequest("Correo electrónico o contraseña no válidos");
                }

                bool loginSuccess = UserBusiness.ValidateUserCredentials(loginRequest.Mail, loginRequest.Contraseña);

                if (loginSuccess)
                {
                    return Ok(new { Message = "Inicio de sesión correcto." });
                }
                else
                {
                    return Unauthorized(new { Message = "Correo electrónico o contraseña no válidos." });
                }
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Internal Server Error" });
            }
        }
        [HttpPut("{userId}")]
        public IActionResult UpdateUser(int userId, [FromBody] Usuario user)
        {
            if (user == null)
            {
                return BadRequest("Invalid user data.");
            }

            try
            {
                UserBusiness.UpdateUser(userId, user);

                return Ok("Usuario actualizado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
        [HttpDelete("{userId}")]
        public IActionResult DeleteUserById(int userId)
        {
            try
            {
                var user = UserBusiness.GetUserById(userId);

                if (user == null)
                {
                    return NotFound();
                }

                UserBusiness.DeleteUser(userId);

                return Ok("Usuario eliminado satisfactoriamente.");
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal Server Error");
            }
        }
    }
}
