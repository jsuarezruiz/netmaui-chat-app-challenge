using ChatApp.Models;
using ChatApp.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ChatApp.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        ObservableCollection<User> _users;
        ObservableCollection<Message> _recentChat;

        public HomeViewModel()
        {
            LoadData();
        }

        public ObservableCollection<User> Users
        {
            get { return _users; }
            set
            {
                _users = value;
                OnPropertyChanged();
            }
        }

        public ObservableCollection<Message> RecentChat
        {
            get { return _recentChat; }
            set
            {
                _recentChat = value;
                OnPropertyChanged();
            }
        }

        public ICommand DetailCommand => new Command<User>(OnNavigate);

        void LoadData()
        {
            Users = new ObservableCollection<User>(MessageService.Instance.GetUsers());
            RecentChat = new ObservableCollection<Message>(MessageService.Instance.GetChats());
        }

        void OnNavigate(User parameter)
        {
            NavigationService.Instance.NavigateToAsync<DetailViewModel>(parameter);
        }
    }
}