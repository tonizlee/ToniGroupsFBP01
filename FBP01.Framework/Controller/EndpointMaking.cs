using System;
using System.Collections.Generic;
using System.Text;

namespace FBP01.Framework.Controller
{
    public class EndpointMaking
    {
        public string TeamSelect(int token)
        {
            string retval = "competitions";
            string league = null;

            switch (token)
            {
                case 0:
                    league = "/WC";
                    break;
                case 1:
                    league = "/CL";
                    break;
                case 2:
                    league = "/BL1";
                    break;
                case 3:
                    league = "/BL2";
                    break;
                case 4:
                    league = "/PL";
                    break;
                case 5:
                    league = "/ELC";
                    break;
                case 6:
                    league = "/SA";
                    break;
                case 7:
                    league = "/SB";
                    break;
                case 8:
                    league = "/PD";//restricted
                    break;
                case 9:
                    league = "/FL1";
                    break;
                case 10:
                    league = "/DED";//restricted
                    break;
                case 11:
                    league = "/PPL";
                    break;
            }

            return retval + league;
        }

        public string Endpoint_Team(int token)
        {
            string retval = TeamSelect(token);

            return retval  + "/teams";
        }

        public string Endpoint_Standing(int token)
        {
            string retval = TeamSelect(token);

            return retval + "/standings";
        }

        public string Endpoint_Squad(string id)
        {
            string retval = "teams";
            string idToStr = id;

            return retval + "/" + idToStr;
        }
    }
}
