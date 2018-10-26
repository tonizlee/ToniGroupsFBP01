using FBP01.Framework.Model;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        public ObservableCollection<TeamListModel> GetTeamListModel(string url)
        {
            ObservableCollection<TeamListModel> TeamLists = new ObservableCollection<TeamListModel>();

            JObject tempObj = JObject.Parse(url);

            var team1 = tempObj["teams"];

            foreach (JObject tempElement in team1)
            {
                //팀이름 가져오기

                var teamname = tempElement["name"] ?? "<NULL>";
                var teamsname = tempElement["shortName"] ?? "<NULL>";
                var teamid = tempElement["id"] ?? "<NULL>";
                var teamlogourl = tempElement["crestUrl"] ?? "<NULL>";

                TeamListModel tempmodel = new TeamListModel(teamname.ToString(), teamsname.ToString(), teamid.ToString(), teamlogourl.ToString());

                TeamLists.Add(tempmodel);
            }

            return TeamLists;
        }

    }

}