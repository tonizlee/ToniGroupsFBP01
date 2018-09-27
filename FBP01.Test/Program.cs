using System;
using FBP01.Framework.Controller;
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
            EndpointMaking ep = new EndpointMaking();

            string temp = ep.Endpoint_Team(1);

            //Console.WriteLine(RestTest.GetRequestResult(ep.Endpoint_Team(1)));

            tl.GetTeamList(RestTest.GetRequestResult(ep.Endpoint_Team(1)));


        }
    }
}
