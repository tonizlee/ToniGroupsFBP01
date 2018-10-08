using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace FBP01.Framework.GetData
{
    public class Standings
    {
        public void GetStandingList(string url)
        {
            JObject tempObj = JObject.Parse(url);

            var standingList = tempObj["standings"];
            
            foreach (JObject tempElement in standingList)
            {
                if (tempElement["type"].ToString() == "TOTAL")
                {
                    var teamLists = tempElement["table"];
                    foreach (JObject tempteam in teamLists)
                    {
                        //순위 가져오기 
                        var rank = tempteam["position"];
                        //팀이름 가져오기
                        var teamname = tempteam["team"]["name"] ?? "<NULL>";
                        Console.WriteLine(rank + " " + teamname);
                    }
                }
            }
        }
    }
}
