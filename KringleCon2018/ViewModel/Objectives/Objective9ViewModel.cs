using System;
using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective9ViewModel : ObjectiveViewModel
    {
        public Objective9ViewModel()
        {
            InitObj9();
            InitCatchTheMalware();
            InitIdentifyTheDomain();
            InitStopTheMalware();
            InitRecoverAlabastersPassword();
        }
        private void InitObj9()
        {
            NMSleighBellLotto = File.ReadAllText(@"../../Resources/Objectives/Objective9/nm_sleighbell-lotto.txt");
            ShinyUpatree = @"../../Resources/Objectives/Objective9/ShinyUpatree.png";
        }
        private void InitIdentifyTheDomain() { }
        private void InitStopTheMalware() { }
        private void InitRecoverAlabastersPassword() { }
        private void InitCatchTheMalware()
        {
            MoreInfo = File.ReadAllText(@"../../Resources/Objectives/Objective9/CatchTheMalware/more_info.txt");
            PCAP1 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255048.4356453.pcap");
            PCAP2 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255095.3225539.pcap");
            PCAP3 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255127.5287354.pcap");
            PCAP4 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255167.4590678.pcap");
            PCAP5 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255214.5929677.pcap");
            PCAP6 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective9\CatchTheMalware\snort.log.1547255248.2398825.pcap");
            PCAP_Sigs = File.ReadAllText(@"../../Resources/Objectives/Objective9/CatchTheMalware/pcap_signature_samples.txt");
            SnortRunResults = File.ReadAllText(@"../../Resources/Objectives/Objective9/CatchTheMalware/SnortRunResults.txt");
            SnortAlerts = File.ReadAllText(@"../../Resources/Objectives/Objective9/CatchTheMalware/SnortAlerts.txt");
            SnortIDS = @"../../Resources/Objectives/Objective9/CatchTheMalware/SnortIDS.png";
        }
        private string _nMSleighBellLotto, _shinyUpatree;
        private string _moreInfo, _pCAP1, _pCAP2, _pCAP3, _pCAP4, _pCAP5, _pCAP6, _pCAP_Sigs, _snortRunResults, _snortAlerts, _snortIDS;
        private string _chocoZip, _chocoDoc;
        public string NMSleighBellLotto { get => _nMSleighBellLotto; set => SetProperty(ref _nMSleighBellLotto, value); }
        public string ShinyUpatree { get => _shinyUpatree; set => SetProperty(ref _shinyUpatree, value); }
        public string MoreInfo { get => _moreInfo; set => SetProperty(ref _moreInfo, value); }
        public string PCAP1 { get => _pCAP1; set => SetProperty(ref _pCAP1, value); }
        public string PCAP2 { get => _pCAP2; set => SetProperty(ref _pCAP2, value); }
        public string PCAP3 { get => _pCAP3; set => SetProperty(ref _pCAP3, value); }
        public string PCAP4 { get => _pCAP4; set => SetProperty(ref _pCAP4, value); }
        public string PCAP5 { get => _pCAP5; set => SetProperty(ref _pCAP5, value); }
        public string PCAP6 { get => _pCAP6; set => SetProperty(ref _pCAP6, value); }
        public string PCAP_Sigs { get => _pCAP_Sigs; set => SetProperty(ref _pCAP_Sigs, value); }
        public string SnortRunResults { get => _snortRunResults; set => SetProperty(ref _snortRunResults, value); }
        public string SnortAlerts { get => _snortAlerts; set => SetProperty(ref _snortAlerts, value); }
        public string SnortIDS { get => _snortIDS; set => SetProperty(ref _snortIDS, value); }
        public string ChocoZip { get => _chocoZip; set => SetProperty(ref _chocoZip, value); }
    }
}