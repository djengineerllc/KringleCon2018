using System.Windows;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Configuration;
using KringleCon2018.Objectives;

namespace KringleCon2018
{
    public class KringleCon2018Bootstrapper : BootstrapperBase
    {
        readonly SimpleContainer _container = new SimpleContainer();
        public KringleCon2018Bootstrapper() => Initialize();
        protected override void Configure()
        {
            _container.Singleton<IWindowManager, KringleCon2018WindowManager>();
            _container.Singleton<IEventAggregator, EventAggregator>();
            _container.RegisterHandler(typeof(IAppConfigs), "AppConfigs", (sc) => {
                return new AppConfigs {
                    KringleCon2018Key = ConfigurationManager.AppSettings.Get("KringleCon2018Key")
                };
            });
            _container.PerRequest<IShell, ShellViewModel>();
        }
        protected override object GetInstance(Type service, string key)
        {
            var instance = _container.GetInstance(service, key);
            if (instance != null) { return instance; }
            throw new InvalidOperationException("Could not locate any instances.");
        }
        protected override IEnumerable<object> GetAllInstances(Type service) => _container.GetAllInstances(service);
        protected override void BuildUp(object instance) => _container.BuildUp(instance);
        protected override void OnStartup(object sender, StartupEventArgs e) => DisplayRootViewFor<IShell>();
        protected override IEnumerable<Assembly> SelectAssemblies() => new[] { Assembly.GetExecutingAssembly() };
    }
}