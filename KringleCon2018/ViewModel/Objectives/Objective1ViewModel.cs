namespace KringleCon2018.Objectives
{
    public class Objective1ViewModel : ObjectiveViewModel
    {
        public Objective1ViewModel()
        {
            BushEvergreen = @"../../Resources/Objectives/Objective1/BushEvergreen.png";
        }
        private string _bushEvergreen;
        public string BushEvergreen
        {
            get => _bushEvergreen;
            set => SetProperty(ref _bushEvergreen, value);
        }
    }
}