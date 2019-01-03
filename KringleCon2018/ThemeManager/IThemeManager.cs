using System.Windows;

namespace KringleCon2018.ThemeManager
{
    public interface IThemeManager
    {
        string CurrentTheme { get; set; }
        ResourceDictionary ThemeResources { get; }
        void RegisterTheme(string name, string path);
    }
}