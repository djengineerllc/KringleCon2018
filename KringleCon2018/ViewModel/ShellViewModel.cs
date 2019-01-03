using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;
using Caliburn.Micro;
using KringleCon2018.Events;

namespace KringleCon2018
{
    [Export(typeof(IShell))]
    public class ShellViewModel : Conductor<Screen>.Collection.OneActive, IShell, IHandle<ChangeMainScreenEvent>, IHandle<OpenWindowMessage>, INotifyPropertyChangedEx
    {
        /// <summary>
        /// Stores the events aggregator
        /// </summary>
        public IEventAggregator _events = new EventAggregator();
        public IWindowManager _windowManager = new WindowManager();
        Screen _selectedTab;
        public Screen SelectedTab
        {
            get => _selectedTab;
            set
            {
                if (value == null || value.Equals(_selectedTab)) { return; }
                _selectedTab = value;
                DisplayName = $"KringleCon - {SelectedTab.DisplayName}";
                NotifyOfPropertyChange(() => SelectedTab);
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShellViewModel"/> class
        /// </summary>
        /// <param name="events">The event aggregator</param>
        [ImportingConstructor]
        public ShellViewModel(IEventAggregator events, IWindowManager windowManager, IAppConfigs configs)
        {
            _events = events;
            _windowManager = windowManager;
            Items.AddRange(new List<Screen> {
                new KringleConNarrativeViewModel(_events, _windowManager, configs, "Narrative"),
                new KringleConObjectivesViewModel(_events, _windowManager, configs, "Objectives")
            });
            LoadDefault();            
        }

        void LoadDefault() => SelectedTab = Items[0];
        
        /// <summary>
        /// Handles the change of screen
        /// </summary>
        /// <param name="message">The event message</param>
        public void Handle(ChangeMainScreenEvent message)
        {
            ActivateItem(message.Screen);
            Application.Current.MainWindow.Title = message.Screen.DisplayName;
        }
        public void Handle(OpenWindowMessage message) {
            _windowManager.ShowWindow(message.Screen);
        }
        protected override void OnActivate() => base.OnActivate();
        protected override void OnDeactivate(bool close) => base.OnDeactivate(close);
        public override void CanClose(Action<bool> callback)
        {
            if (MessageBox.Show($"Do you really want to close this window ({Application.Current.MainWindow.Title})",
                    "Close ?", MessageBoxButton.OKCancel, MessageBoxImage.Question) == MessageBoxResult.OK)
            {
                callback(true);
            }
        }
    }
}