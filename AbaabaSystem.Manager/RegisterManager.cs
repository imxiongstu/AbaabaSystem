using System;
using AbaabaSystem.Service;
using AbaabaSystem.Models;
namespace AbaabaSystem.Manager
{
    public class RegisterManager
    {
        RegisterService registerService = new RegisterService();

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public string SendAuthCode(string tel) => registerService.SendAuthCode(tel);

        /// <summary>
        /// 增加新用户
        /// </summary>
        /// <param name="myUser"></param>
        /// <returns></returns>
        public bool AddUser(User myUser) => registerService.AddUser(myUser);
    }
}
