// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Threading.Tasks;
// using Microsoft.AspNetCore.Mvc;
// using TechStoreAPI.Config;
// using TechStoreAPI.Models;

// namespace TechStoreAPI.Controllers
// {
//     [ApiController]
//     [Route("api/v1/auth")]
//     public class AuhtController: ControllerBase
//     {   
//         private readonly JWT _jwt;

//         public AuhtController(JWT jwt)
//         {
//             _jwt = jwt;
//         }
//         //Metodo para generar un token
//         [HttpPost]
//         public async Task<IActionResult> GenerateToken(User user)
//         {   
//             var token = _jwt.GenerateJwtToken(user);
//             return Ok($"Este es tu token: {token}");
//         }
//     }
// }