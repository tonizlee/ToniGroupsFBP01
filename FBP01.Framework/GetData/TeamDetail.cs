using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace FBP01.Framework.GetData
{
    public class TeamDetail
    {
        public void GetSquadList(string url)
        {
            JObject tempObj = JObject.Parse(url);

            var team1 = tempObj["squad"];

            foreach (JObject tempElement in team1)
            {
                //팀이름 가져오기
                if (tempElement["role"].ToString() == "PLAYER")
                {
                    var backNum = tempElement["shirtNumber"];
                    var position = tempElement["position"];
                    var playername = tempElement["name"] ?? "<NULL>";
                    Console.WriteLine(backNum + " - "+ playername + "  [ " + position + " ]");
                }
            }
        }
    }
}
