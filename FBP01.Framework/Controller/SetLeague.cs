using FBP01.Framework.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FBP01.Framework.Controller
{
    public class SetLeague
    {
        private string[] leagueArray = { "FIFA WorldCup",
                "UEFA Champions League",
                "Bundes Liga 1 [Germany]",
                "Bundes Liga 2 [Germany]",
                "Premier League [England]",
                "England Championship [England]",
                "Serie A [Italy]",
                "Serie B [Italy]",
                "Primera Division [Spain]",
                "Ligue 1 [France]",
                "Eredivisie [Netherland]",
                "Primeira Liga [Portugal]" };

        public ObservableCollection<LeagueListModel> SettingLeagueLists()
        {
            ObservableCollection<LeagueListModel> leagueList = new ObservableCollection<LeagueListModel>();
            int i = 0;
            foreach (string leaguename in leagueArray)
            {
                LeagueListModel tempMod = new LeagueListModel();
                tempMod.league_name = leaguename;
                tempMod.league_token = i;
                i++;

                leagueList.Add(tempMod);
            }

            return leagueList;
        }

    }
}
