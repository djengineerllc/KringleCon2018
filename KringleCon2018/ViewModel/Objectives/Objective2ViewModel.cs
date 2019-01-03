using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective2ViewModel : ObjectiveViewModel
    {
        private string _menuPS1, _rejectedTalksCSV;
        public Objective2ViewModel()
        {
            MenuPS1 = File.ReadAllText("../../Resources/Objectives/Objective2/menu.ps1");
            RejectedTalksCSV = File.ReadAllText("../../Resources/Objectives/Objective2/rejected-talks.csv");
        }
        public string MenuPS1
        {
            get => _menuPS1;
            set => SetProperty(ref _menuPS1, value);
        }
        public string RejectedTalksCSV
        {
            get => _rejectedTalksCSV;
            set => SetProperty(ref _rejectedTalksCSV, value);
        }
    }
}