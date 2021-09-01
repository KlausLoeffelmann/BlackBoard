using BlackBoard.Model;
using System.Collections.ObjectModel;

namespace Blackboard.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Entry> _blackboard;
        private User? _currentUser;
        private DateTimeOffset _currentTime;

        public MainViewModel()
        {
            _blackboard = new ObservableCollection<Entry>();
        }

        public ObservableCollection<Entry> Blackboard
        {
            get => _blackboard;
            set => SetProperty(ref _blackboard, value);
        }

        public User? CurrentUser
        {
            get => _currentUser;
            set => SetProperty(ref _currentUser, value);
        }

        public DateTimeOffset CurrentTime
        {
            get => _currentTime;
            set => SetProperty(ref _currentTime, value);
        }
    }
}
