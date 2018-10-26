using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FBP01.Framework.Model
{
    public class TeamListModel : ViewModelBase
    {
        public TeamListModel()
        { }

        public TeamListModel(string _team_name, string _team_short_name, string _id, string _logo)
        {
            this.team_name = _team_name;
            this.team_short_name = _team_short_name;
            this.id = _id;
            this.logo = _logo;
        }

        private string _team_short_name;
        public string team_short_name { get { return _team_short_name; } set { _team_short_name = value; OnPropertyChanged("team_short_name"); } }

        private string _team_name;
        public string team_name { get { return _team_name; } set { _team_name = value; OnPropertyChanged("team_name"); } }

        private string _id;
        public string id { get { return _id; } set { _id = value; OnPropertyChanged("team_id"); } }

        public string logo { get; set; }
    }
}
