using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AbaabaSystem.Manager;
using AbaabaSystem.Models;
namespace AbaabaSystem.API.Controllers
{
    [EnableCors("AbaabaSystemCors")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        RegisterManager registerManager = new RegisterManager();

        /// <summary>
        /// 发送验证码API
        /// </summary>
        /// <param name="tel"></param>
        [HttpGet]
        [Route("{id}")]
        public void SendAuthCode(string tel)
        {
            registerManager.SendAuthCode(tel);
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        [HttpPost]
        [Route("{id}")]
        public bool AddUser(User myUser)
        {
            myUser.UserID = new Random().Next(1000, 9999);

            return registerManager.AddUser(myUser);
        }
    }
}
