namespace KringleCon2018.Objectives
{
    public class Objective6ViewModel : ObjectiveViewModel
    {
        private string _alabasterBadge, _qrCode1, _qrCode2, _qrCode3, _finalQRBadge, _pepperMinstix;
        public Objective6ViewModel()
        {
            AlabasterBadge = @"../../Resources/Objectives/Objective6/alabaster_badge.jpg";
            QRCode1 = @"../../Resources/Objectives/Objective6/QRCode1.png";
            QRCode2 = @"../../Resources/Objectives/Objective6/QRCode2.png";
            QRCode3 = @"../../Resources/Objectives/Objective6/QRCode3.png";
            FinalQRBadge = @"../../Resources/Objectives/Objective6/FinalQRBadge.png";
            PepperMinstix = @"../../Resources/Objectives/Objective6/PepperMinstix.png";
        }
        public string AlabasterBadge
        {
            get => _alabasterBadge;
            set => SetProperty(ref _alabasterBadge, value);
        }
        public string QRCode1
        {
            get => _qrCode1;
            set => SetProperty(ref _qrCode1, value);
        }
        public string QRCode2
        {
            get => _qrCode2;
            set => SetProperty(ref _qrCode2, value);
        }
        public string QRCode3
        {
            get => _qrCode3;
            set => SetProperty(ref _qrCode3, value);
        }
        public string FinalQRBadge
        {
            get => _finalQRBadge;
            set => SetProperty(ref _finalQRBadge, value);
        }
        public string PepperMinstix
        {
            get => _pepperMinstix;
            set => SetProperty(ref _pepperMinstix, value);
        }
    }
}