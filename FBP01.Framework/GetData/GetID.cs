using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;

namespace FBP01.Framework.GetData
{
    public class GetID
    {
        public string getTeamID(string url, string team_name)
        {
            string retval = null;
            JObject tempObj = JObject.Parse(url);

            var team1 = tempObj["teams"];

            foreach (JObject tempElement in team1)
            {
                if (tempElement["name"].ToString() == team_name || tempElement["shortName"].ToString() == team_name)
                {
                    var teamid = tempElement["id"] ?? "<NULL>";
                    retval = teamid.ToString();
                }

            }
            return retval;
        }
    }
}
