using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective2ViewModel : ObjectiveViewModel
    {
        private string _menuPS1, _rejectedTalksCSV, _mintyCandycane;
        public Objective2ViewModel()
        {
            MenuPS1 = File.ReadAllText("../../Resources/Objectives/Objective2/menu.ps1");
            RejectedTalksCSV = File.ReadAllText("../../Resources/Objectives/Objective2/rejected-talks.csv");
            MintyCandycane = @"../../Resources/Objectives/Objective2/MintyCandycane.png";
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
        public string MintyCandycane
        {
            get => _mintyCandycane;
            set => SetProperty(ref _mintyCandycane, value);
        }
    }
}