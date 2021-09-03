using Blackboard.ViewModels.Base;
using BlackBoard.Model;
using System.Collections.ObjectModel;

namespace Blackboard.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private ObservableCollection<Entry> _blackboard;
        private User? _currentUser;
        private DateTimeOffset _currentTime;

        public MainViewModel(IServiceProvider serviceProvider) : base(serviceProvider)
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
