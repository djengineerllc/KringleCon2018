using Caliburn.Micro;

namespace KringleCon2018
{
    public class HeaderViewModel : BaseViewModel
    {
        public HeaderViewModel(IEventAggregator events, IWindowManager windowManager, string name) : base(events, windowManager)
        {
            DisplayName = name;
            IsEnabled = true;
            _events.Subscribe(this);
        }
    }
}
