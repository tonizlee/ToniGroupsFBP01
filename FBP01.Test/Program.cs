using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FBP01.Framework.Controller;
using FBP01.Framework.GetData;
using FBP01.Framework.Model;
using Newtonsoft.Json.Linq;

namespace FBP01.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rest RestTest = new Rest();
            TeamList tl = new TeamList();
            Standings st = new Standings();
            TeamDetail td = new TeamDetail();
            EndpointMaking ep = new EndpointMaking();
            SetMainTeam settingTeam = new SetMainTeam();

            //string temp = ep.Endpoint_Team(1);

            //팀 ID get
            //string teamid = new GetID().getTeamID(RestTest.GetRequestResult(ep.Endpoint_Team(3)), "Newcastle");



            //Console.WriteLine(RestTest.GetRequestResult(ep.Endpoint_Team(1)));

            // tl.GetTeamList(RestTest.GetRequestResult(ep.Endpoint_Team(1)));



            
            ObservableCollection<TeamListModel> templist = new ObservableCollection<TeamListModel>();

            templist = tl.GetTeamListModel(RestTest.GetRequestResult(ep.Endpoint_Team(1)));

            int i = 1;
            List<string> teamNameList = new List<string>();
            TeamListModel finalTeam = new TeamListModel();

            foreach(TeamListModel mod in templist)
            {
                Console.WriteLine("{0}\t " + mod.id+" | "+ mod.team_name+" | "+ mod.team_short_name, i);
                teamNameList.Add(mod.id);
                i++;
            }

            //Console.WriteLine("Input the id");
            //string inputteam = Console.ReadLine();
            //int j = 0;

            //foreach(string temp in teamNameList)
            //{
            //    if (temp == inputteam)
            //    {
            //        finalTeam = templist[j];
            //    }
            //    else
            //        j++;
            //}

            //settingTeam.SettingMainTeam(finalTeam);

            //st.GetStandingList(RestTest.GetRequestResult(ep.Endpoint_Standing(1)));

    

            //Random rand = new Random();
            //int a = rand.Next(1, 803);
            //Console.WriteLine(a);
        }
    }
}
