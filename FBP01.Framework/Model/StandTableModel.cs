using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FBP01.Framework.Model
{
    public class StandTableModel : ViewModelBase
    {
        public StandTableModel(string _position, string _team_name, string _id, string _attempts, string _won, string _draw, string _lost, string _goal, string _loss, string _goal_differents, string _points)
        {
            this.position = _position;
            this.team_name = _team_name;
            this.id =_id;
            this.attempts = _attempts;
            this.won = _won;
            this.draw =_draw;
            this.lost =_lost;
            this.goal =_goal;
            this.loss = _loss;
            this.goal_differents = _goal_differents;
            this.points = _points;
        }

        private string _position;
        public string position { get { return _position; } set { _position = value; OnPropertyChanged("position"); } }

        private string _team_name;
        public string team_name { get { return _team_name; } set { _team_name = value; OnPropertyChanged("team_name"); } }

        private string _id;
        public string id { get { return _id; } set { _id = value; OnPropertyChanged("team_id"); } }

        private string _attempts;
        public string attempts { get { return _attempts; } set { _attempts = value; OnPropertyChanged("attempts"); } }

        private string _won;
        public string won { get { return _won; } set { _won = value; OnPropertyChanged("won"); } }

        private string _draw;
        public string draw { get { return _draw; } set { _draw = value; OnPropertyChanged("draw"); } }

        private string _lost;
        public string lost { get { return _lost; } set { _lost = value; OnPropertyChanged("lost"); } }

        private string _goal;
        public string goal { get { return _goal; } set { _goal = value; OnPropertyChanged("goal"); } }

        private string _loss;
        public string loss { get { return _loss; } set { _loss = value; OnPropertyChanged("loss"); } }

        private string _goal_differents;
        public string goal_differents { get { return _goal_differents; } set { _goal_differents = value; OnPropertyChanged("goal_differents"); } }

        private string _points;
        public string points { get { return _points; } set { _points = value; OnPropertyChanged("points"); } }


    }
}
