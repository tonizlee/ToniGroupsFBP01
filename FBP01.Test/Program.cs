using System;
using FBP01.Framework.Controller;

namespace FBP01.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Rest RestTest = new Rest();
            EndpointMaking ep = new EndpointMaking();

            string temp = ep.Endpoint_Team(1);

            Console.WriteLine(RestTest.GetRequestResult(ep.Endpoint_Team(1)));
        }
    }
}
