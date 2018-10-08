using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace FBP01.Framework.GetData
{
    public class TeamList
    {
        public void GetTeamList(string url)
        {
            JObject tempObj = JObject.Parse(url);

            var team1 = tempObj["teams"];

            foreach (JObject tempElement in team1)
            {
                //팀이름 가져오기
                var teamname = tempElement["name"] ?? "<NULL>";
                Console.WriteLine(teamname);
            }
        }

    }

}