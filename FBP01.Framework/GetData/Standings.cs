using System;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using FBP01.Framework.Model;

namespace FBP01.Framework.GetData
{
    public class Standings
    {
        public ObservableCollection<StandTableModel> GetStandingList(string url)
        {
            ObservableCollection<StandTableModel> retval = new ObservableCollection<StandTableModel>();

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
                        var position = tempteam["position"];
                        //팀이름 가져오기
                        var teamname = tempteam["team"]["name"] ?? "<NULL>";
                        var teamid = tempteam["team"]["id"] ?? "<NULL>";
                        var attempt = tempteam["playedGames"] ?? "<NULL>";
                        var win = tempteam["won"] ?? "<NULL>";
                        var lost = tempteam["lost"] ?? "<NULL>";
                        var draw = tempteam["draw"] ?? "<NULL>";
                        var goal = tempteam["goalsFor"] ?? "<NULL>";
                        var loss = tempteam["goalsAgainst"] ?? "<NULL>";
                        var goaldif = tempteam["goalDifference"] ?? "<NULL>";
                        var points = tempteam["points"] ?? "<NULL>";

                        StandTableModel tempModel = new StandTableModel(position.ToString(), teamname.ToString(), teamid.ToString(), attempt.ToString(), win.ToString(), draw.ToString(), lost.ToString(), goal.ToString(), loss.ToString(), goaldif.ToString(), points.ToString());

                        retval.Add(tempModel);
                    }
                }
            }
            return retval;
        }


    }
}
