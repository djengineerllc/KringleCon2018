using System;
using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective4ViewModel : ObjectiveViewModel
    {
        private string _report, _truffleHog, _zipFilePath, _ventImg1, _ventImg2;
        public Objective4ViewModel()
        {
            Report = File.ReadAllText("../../Resources/Objectives/Objective4/report.txt");
            TruffleHog = File.ReadAllText("../../Resources/Objectives/Objective4/truffleHogResults.txt");
            ZipFilePath = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective4\schematics_ventilation_diagram.zip");
            VentImg1 = @"../../Resources/Objectives/Objective4/ventilation_diagram_1F.jpg";
            VentImg2 = @"../../Resources/Objectives/Objective4/ventilation_diagram_2F.jpg";
        }
        public string Report
        {
            get => _report;
            set => SetProperty(ref _report, value);
        }
        public string TruffleHog
        {
            get => _truffleHog;
            set => SetProperty(ref _truffleHog, value);
        }
        public string ZipFilePath
        {
            get => _zipFilePath;
            set => SetProperty(ref _zipFilePath, value);
        }
        public string VentImg1
        {
            get => _ventImg1;
            set => SetProperty(ref _ventImg1, value);
        }
        public string VentImg2
        {
            get => _ventImg2;
            set => SetProperty(ref _ventImg2, value);
        }
    }
}