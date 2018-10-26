using FBP01.Framework.Controller;
using FBP01.Framework.GetData;
using FBP01.Framework.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace FBP01.FormClient.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            SettingLeagueList();
        }

        private Rest RestTest = new Rest();
        private TeamList tl = new TeamList();
        private Standings st = new Standings();
        private EndpointMaking ep = new EndpointMaking();

        SelectTeam selectTeamWin;
        StandingExtend standingExtend;

        public ObservableCollection<LeagueListModel> LeagueList;

        private ObservableCollection<string> _LeagueListStr;
        public ObservableCollection<string> LeagueListStr { get { return _LeagueListStr; } set { _LeagueListStr = value; OnPropertyChanged("LeagueListStr"); } }

        private int _LeagueSelected;
        public int LeagueSelected { get { return _LeagueSelected; } set { _LeagueSelected = value; OnPropertyChanged("LeagueSelected"); } }

        private ObservableCollection<TeamListModel> _teamList;
        public ObservableCollection<TeamListModel> teamList { get { return _teamList; } set { _teamList = value; OnPropertyChanged("teamList"); } }

        private int _TeamSelected;
        public int TeamSelected { get { return _TeamSelected; } set { _TeamSelected = value; OnPropertyChanged("TeamSelected"); } }

        private ObservableCollection<StandTableModel> _LeagueStandTable;
        public ObservableCollection<StandTableModel> LeagueStandTable { get { return _LeagueStandTable; } set { _LeagueStandTable = value; OnPropertyChanged("LeagueStandTable"); } }


        private ICommand _LoadTeamList;
        public ICommand LoadTeamList
        {
            get
            {
                if (_LoadTeamList == null)
                    _LoadTeamList = new RelayCommand(p => this.GetTeamList(p));
                return _LoadTeamList;
            }
        }

        private ICommand _SetMainTeam;
        public ICommand SetMainTeam
        {
            get
            {
                if (_SetMainTeam == null)
                    _SetMainTeam = new RelayCommand(p => this.SettingMainTeam(p));
                return _SetMainTeam;
            }
        }

        private ICommand _OpenTeamSelect;
        public ICommand OpenTeamSelect
        {
            get
            {
                if (_OpenTeamSelect == null)
                    _OpenTeamSelect = new RelayCommand(p => this.OpenWindow_SelectTeam(1));
                return _OpenTeamSelect;
            }
        }

        private ICommand _OpenStandingEx;
        public ICommand OpenStandingEx
        {
            get
            {
                if (_OpenStandingEx == null)
                    _OpenStandingEx = new RelayCommand(p => this.OpenWindow_ViewStanding(1));
                return _OpenStandingEx;
            }
        }

        private ICommand _GetStandView;
        public ICommand GetStandView
        {
            get
            {
                if (_GetStandView == null)
                    _GetStandView = new RelayCommand(p => this.GetStandList(p));
                return _GetStandView;
            }
        }

        private void OpenWindow_SelectTeam(int p)
        {
            //SelectTeamWin.Content = p;
            selectTeamWin = new SelectTeam();
            selectTeamWin.Show();
        }

        private void OpenWindow_ViewStanding(int p)
        {
            //SelectTeamWin.Content = p;
            standingExtend = new StandingExtend();
            standingExtend.Show();
        }


        private void SettingLeagueList()
        {
            SetLeague setLeague = new SetLeague();
            LeagueList = setLeague.SettingLeagueLists();
            ObservableCollection<string> tempLeagueList = new ObservableCollection<string>();
            foreach (LeagueListModel LeagueModel in LeagueList)
            {
                tempLeagueList.Add(LeagueModel.league_name);
            }
            LeagueListStr = tempLeagueList;
        }

        private void GetTeamList(object p = null)
        {
            ObservableCollection<TeamListModel> tempTeamList = new ObservableCollection<TeamListModel>();
            tempTeamList = tl.GetTeamListModel(RestTest.GetRequestResult(ep.Endpoint_Team(LeagueSelected)));

            teamList = tempTeamList;
        }

        private void SettingMainTeam(object p = null)
        {
            SetMainTeam setMainTeam = new SetMainTeam();
            setMainTeam.SettingMainTeam(teamList[TeamSelected]);
        }

        private void GetStandList(object p = null)
        {
            ObservableCollection<StandTableModel> tempTeamList = new ObservableCollection<StandTableModel>();
            tempTeamList = st.GetStandingList(RestTest.GetRequestResult(ep.Endpoint_Standing(LeagueSelected)));

            LeagueStandTable = tempTeamList;
        }

    }
}
