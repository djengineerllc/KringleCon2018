using System.ComponentModel;
using Caliburn.Micro;

namespace KringleCon2018
{
    public interface IMainScreenTabItem : IScreen
    {
    }
    public class BaseViewModel : Screen, IMainScreenTabItem, INotifyPropertyChanged
    {
        string _displayTitle;
        public string DisplayTitle
        {
            get => _displayTitle;
            set
            {
                if (value == null || value.Equals(_displayTitle)) { return; }
                _displayTitle = value;
                NotifyOfPropertyChange(() => DisplayName);
            }
        }
        /// <summary>
        /// Stores the events aggregator
        /// </summary>
        internal readonly IEventAggregator _events;
        internal readonly IWindowManager _windowManager;
        internal bool _isEnabled; public bool IsEnabled
        {
            get => _isEnabled;
            set
            {
                if (value.Equals(_isEnabled)) { return; }
                _isEnabled = value;
                NotifyOfPropertyChange(() => IsEnabled);
            }
        }
        public BaseViewModel(IEventAggregator events, IWindowManager windowManager)
        {
            _events = events;
            _windowManager = windowManager;            
            _events.Subscribe(this);
        }
    }
}