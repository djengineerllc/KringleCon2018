using Caliburn.Micro;

namespace KringleCon2018
{
    internal class KringleConNarrativeViewModel : BaseViewModel
    {
        internal readonly IAppConfigs _configs;

        public KringleConNarrativeViewModel(IEventAggregator events, IWindowManager windowManager, IAppConfigs configs, string name) : base(events, windowManager)
        {
            DisplayName = name;
            IsEnabled = true;
            _configs = configs;
            _events.Subscribe(this);
        }
    }
}