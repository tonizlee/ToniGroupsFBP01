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
                    league = "/BL1";
                    break;
                case 2:
                    league = "/BL2";
                    break;
                case 3:
                    league = "/PL";
                    break;
                case 4:
                    league = "/ELC";
                    break;
                case 5:
                    league = "/SA";
                    break;
                case 6:
                    league = "/SB";
                    break;
                case 7:
                    league = "/PD";
                    break;
                case 8:
                    league = "/SD";
                    break;
                case 9:
                    league = "/FL1";
                    break;
                case 10:
                    league = "/FL2";
                    break;
                case 11:
                    league = "/DED";
                    break;
                case 12:
                    league = "/PPL";
                    break;
                case 13:
                    league = "/GSL";
                    break;
                case 14:
                    league = "/CL";
                    break;
                case 15:
                    league = "/EL";
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
    }
}
