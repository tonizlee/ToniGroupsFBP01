using FBP01.Framework.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FBP01.Framework.Controller
{
    public class SetMainTeam
    {
        public void SettingMainTeam(TeamListModel selectedTeamModel)
        {
            string teamid = selectedTeamModel.id;
            string teamName = selectedTeamModel.team_name;
            string teamSname = selectedTeamModel.team_short_name;

            string[] lines = {teamid, teamSname, teamName };

            using (StreamWriter mainTeam = new StreamWriter(@"D:\DevToniGroups\ToniGroupsFBP01\MainTeam.txt"))
            {
                foreach (string line in lines)
                {
                    mainTeam.WriteLine(line);
                }
            }
            
        }

        public string ReadingMainTeamID()
        {
            string[] lines = File.ReadAllLines(@"D:\DevToniGroups\ToniGroupsFBP01\MainTeam.txt");
            string team_id = lines[0];

            return team_id;

        }

    }
}
