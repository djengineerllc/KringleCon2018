using Caliburn.Micro;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace KringleCon2018
{
    public class KringleConObjectivesViewModel : BaseViewModel
    {
        internal readonly IAppConfigs _configs;
        public KringleConObjectivesViewModel(IEventAggregator events, IWindowManager windowManager, IAppConfigs configs, string name) : base(events, windowManager)
        {
            DisplayName = name;
            IsEnabled = true;
            _configs = configs;
            _events.Subscribe(this);
        }
    }
}