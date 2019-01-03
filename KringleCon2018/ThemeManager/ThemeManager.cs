using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Windows;

namespace KringleCon2018.ThemeManager
{
    [Export(typeof(IThemeManager))]
    public class ThemeManager : IThemeManager
    {
        string _currentTheme = string.Empty;
        readonly Dictionary<string, ResourceDictionary> _themes = new Dictionary<string, ResourceDictionary>();

        public ResourceDictionary ThemeResources { get; private set; }

        public string CurrentTheme
        {
            get => _currentTheme;
            set
            {
                if (_themes.ContainsKey(value))
                {
                    _currentTheme = value;
                    ThemeResources = _themes[value];
                }
                else
                {
                    throw new KeyNotFoundException("Theme not found");
                }
            }
        }

        public void RegisterTheme(string name, string path)
        {
            var theme = new ResourceDictionary
            {
                Source = new Uri(path)
            };
            if (_themes.ContainsKey(name))
            {
                _themes[name] = theme;
            }
            else
            {
                _themes.Add(name, theme);
                if (_themes.Count == 1)
                {
                    _currentTheme = name;
                    ThemeResources = theme;
                }
            }
        }
    }
}