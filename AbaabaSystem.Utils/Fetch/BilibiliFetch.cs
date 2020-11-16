using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace AbaabaSystem.Utils
{
    /// <summary>
    /// 爬取B站资源
    /// </summary>
    public class BilibiliFetch
    {
        private string api_GetBilibiliPopular = "https://api.bilibili.com/x/web-interface/popular?ps=8&pn=";

        HttpRequest request = new HttpRequest();

        /// <summary>
        /// 获取B站热门的视频,一次获取8条
        /// </summary>
        /// <param name="index">索引范围1-25</param>
        /// <returns></returns>
        public JObject GetBilibiliPopularVideo(int? index)
        {
            index = index == 0 ? 1 : index;

            JObject resultJson = JObject.Parse(request.GetSourceCodeByUrl(api_GetBilibiliPopular + index));

            JArray jArray = new JArray();
            foreach (var item in resultJson["data"]["list"])
            {
                jArray.Add(new JObject()
                {
                    {"title",item["title"] },
                    {"pic",item["pic"] },
                    {"desc",item["desc"] },
                    {"typename",item["tname"] },
                    {"url","https://player.bilibili.com/player.html?aid="+item["aid"]+"&cid="+item[""]+"&page=1" },
                });
            }

            JObject reslut = new JObject();
            reslut.Add("data", jArray);
            return reslut;
        }
    }
}
