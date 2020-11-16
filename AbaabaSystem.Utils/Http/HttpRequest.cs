using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace AbaabaSystem.Utils
{
    /// <summary>
    /// HTTP请求工具类
    /// </summary>
    public class HttpRequest
    {
        /// <summary>
        /// Get方式获取源码通过Url
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        public string GetSourceCodeByUrl(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Get";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.25 Safari/537.36 Core/1.70.3775.400 QQBrowser/10.6.4209.400";
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                return reader.ReadToEnd();
            }
        }

        /// <summary>
        /// Post方式获取源码通过Url
        /// </summary>
        /// <param name="url"></param>
        /// <param name="param">参数</param>
        /// <param name="header">请求头（允许装一个键值对“：”）</param>
        /// <returns></returns>
        public string PostSourceCodeByUrl(string url, string param, string header)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "Post";
            request.ContentType = "application/x-www-form-urlencoded;charset=UTF-8";
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.25 Safari/537.36 Core/1.70.3775.400 QQBrowser/10.6.4209.400";
            string headerKey = header.Split(':')[0];
            string headerValue = header.Split(':')[1];
            request.Headers.Add(headerKey, headerValue);
            using (StreamWriter writer = new StreamWriter(request.GetRequestStream()))
            {
                writer.Write(param);
            }
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                return reader.ReadToEnd();
            }

        }
    }
}
