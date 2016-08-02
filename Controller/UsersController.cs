using Microsoft.AspNetCore.Mvc;
using WebApiFrame.Models;
namespace WebApiFrame.Controller
{
    [RouteAttribute("api/[controller]")]
    public class UsersController: Microsoft.AspNetCore.Mvc.Controller
    {
        [HttpGetAttribute("{id}")]
        public  IActionResult Get(int id)
        {
            var user =new User(){ID=id, Name="Name:" + id, Sex="Male"};
            return new ObjectResult(user);
        }
    }
}