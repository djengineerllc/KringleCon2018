﻿using System.Windows;
using Caliburn.Micro;
using Caliburn.Micro.Logging.NLog;

namespace KringleCon2018
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Initializes static members of the <see cref="App"/> class
        /// </summary>
        static App() => LogManager.GetLog = type => new NLogLogger(type);
        /// <summary>
        /// Initializes a new instance of the <see cref="App"/> class.
        /// </summary>
        public App() => LogManager.GetLog(GetType()).Info("##### Application starting");
    }
}