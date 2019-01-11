using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective9ViewModel : ObjectiveViewModel
    {
        public Objective9ViewModel()
        {
            NMSleighBellLotto = File.ReadAllText(@"../../Resources/Objectives/Objective9/nm_sleighbell-lotto.txt");
            ShinyUpatree = @"../../Resources/Objectives/Objective9/ShinyUpatree.png";
        }
        private string _nMSleighBellLotto, _shinyUpatree;
        public string NMSleighBellLotto
        {
            get => _nMSleighBellLotto;
            set => SetProperty(ref _nMSleighBellLotto, value);
        }
        public string ShinyUpatree
        {
            get => _shinyUpatree;
            set => SetProperty(ref _shinyUpatree, value);
        }
    }
}