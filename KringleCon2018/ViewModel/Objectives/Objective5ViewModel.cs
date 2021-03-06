﻿namespace KringleCon2018.Objectives
{
    public class Objective5ViewModel : ObjectiveViewModel
    {
        private string _slingShot, _kerbToDA, _pathFromKerbToDA, _hollyEvergreen;
        public Objective5ViewModel() {
            SlingShot = @"../../Resources/Objectives/Objective5/SlingShot.png";
            KerbToDA = @"../../Resources/Objectives/Objective5/KerberoastableToDomainAdmins.png";
            PathFromKerbToDA = @"../../Resources/Objectives/Objective5/PATH_KerberoastableToDomainAdmins.png";
            HollyEvergreen = @"../../Resources/Objectives/Objective5/HollyEvergreen.png";
        }
        public string SlingShot
        {
            get => _slingShot;
            set => SetProperty(ref _slingShot, value);
        }
        public string KerbToDA
        {
            get => _kerbToDA;
            set => SetProperty(ref _kerbToDA, value);
        }
        public string PathFromKerbToDA
        {
            get => _pathFromKerbToDA;
            set => SetProperty(ref _pathFromKerbToDA, value);
        }
        public string HollyEvergreen
        {
            get => _hollyEvergreen;
            set => SetProperty(ref _hollyEvergreen, value);
        }
    }
}