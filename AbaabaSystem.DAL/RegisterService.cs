using System;
using System.Collections.Generic;
using System.Text;
using AbaabaSystem.Utils;
using AbaabaSystem.Models;
using SqlSugar;
namespace AbaabaSystem.Service
{
    public class RegisterService
    {
        string sms_api = "https://sms-api.upyun.com/api/messages";
        string authorization = "En8O30odBQg9tKCQ6t0nJ9UCZIHJ0X";

        HttpRequest httpRequest = new HttpRequest();
        SqlSugarClient db = new DBContext().Instance;

        /// <summary>
        /// 发送验证码
        /// </summary>
        /// <param name="tel"></param>
        /// <returns></returns>
        public string SendAuthCode(string tel)
        {
            int autoCode = new Random().Next(1000, 9999);
            return httpRequest.PostSourceCodeByUrl(sms_api, "mobile=" + tel + "&template_id=3665&vars=" + autoCode, "Authorization:" + authorization);
        }

        /// <summary>
        /// 添加新用户
        /// </summary>
        /// <param name="myUser"></param>
        /// <returns></returns>
        public bool AddUser(User myUser)
        {
            return db.Insertable(myUser).ExecuteCommand() > 0;
        }
    }
}
