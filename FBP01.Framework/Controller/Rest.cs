using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace FBP01.Framework.Controller
{
    public class Rest
    {
        public string GetRequestResult(string endpoint)
        {
            var retval = String.Empty;

            try
            {
                WebRequest request = null;

                request = WebRequest.Create("https://api.football-data.org/v2/" + endpoint);

                request.Headers.Add("x-Auth-Token", "178a76eb1e6a4ed6b6f7518b63bc0433");

                Stream dataStream = null;

                var response = request.GetResponse();
                dataStream = response.GetResponseStream();
                var reader = new StreamReader(dataStream);
                retval = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            string Beautify(string jsonString)
            {
                string jval = JValue.Parse(jsonString).ToString(Formatting.Indented);
                return jval;
            }

            return retval;
        }
    }
}
