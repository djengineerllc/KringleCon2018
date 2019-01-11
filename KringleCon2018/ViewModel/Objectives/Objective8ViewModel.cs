using System;
using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective8ViewModel : ObjectiveViewModel
    {
        private string _pythonCommandCheck, _pythonImportOS, _appJS, _pcapP1, _pcapP2, _sslLog1, _sslLog2, _alabasterSnowball;
        private string _loginHTML, _indexHTML, _secretPCAP, _secretEmail, _emailAttachment;
        public Objective8ViewModel()
        {
            PythonCommandCheck = @"../../Resources/Objectives/Objective8/Python-CheckCommandAccess.png";
            PythonImportOS = @"../../Resources/Objectives/Objective8/Python-ImportOS.png";
            AppJS = File.ReadAllText(@"../../Resources/Objectives/Objective8/app.js");
            PCAPP1 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\P1_00074743_1-1-2019_23-25-27.pcap");
            PCAPP2 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\P2_08265698_1-1-2019_23-49-15.pcap");
            SSLLog1 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\P1_packalyzer_clientrandom_ssl.log.txt");
            SSLLog2 = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\P2_packalyzer_clientrandom_ssl.log.txt");
            LoginHTML = File.ReadAllText(@"../../Resources/Objectives/Objective8/login.html");
            IndexHTML = File.ReadAllText(@"../../Resources/Objectives/Objective8/index.html");
            SecretPCAP = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\ALABASTER_super_secret_packet_capture.pcap");
            SecretEmail = File.ReadAllText(@"../../Resources/Objectives/Objective8/SecretEmailFromTCPStream.txt");
            EmailAttachment = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective8\mailattachment.pdf");
            AlabasterSnowball = @"../../Resources/Objectives/Objective8/AlabasterSnowball.png";
        }
        public string AlabasterSnowball
        {
            get => _alabasterSnowball;
            set => SetProperty(ref _alabasterSnowball, value);
        }
        public string PythonCommandCheck
        {
            get => _pythonCommandCheck;
            set => SetProperty(ref _pythonCommandCheck, value);
        }
        public string PythonImportOS
        {
            get => _pythonImportOS;
            set => SetProperty(ref _pythonImportOS, value);
        }
        public string AppJS
        {
            get => _appJS;
            set => SetProperty(ref _appJS, value);
        }
        public string PCAPP1
        {
            get => _pcapP1;
            set => SetProperty(ref _pcapP1, value);
        }
        public string PCAPP2
        {
            get => _pcapP2;
            set => SetProperty(ref _pcapP2, value);
        }
        public string SSLLog1
        {
            get => _sslLog1;
            set => SetProperty(ref _sslLog1, value);
        }
        public string SSLLog2
        {
            get => _sslLog2;
            set => SetProperty(ref _sslLog2, value);
        }
        public string LoginHTML
        {
            get => _loginHTML;
            set => SetProperty(ref _loginHTML, value);
        }
        public string IndexHTML
        {
            get => _indexHTML;
            set => SetProperty(ref _indexHTML, value);
        }
        public string SecretPCAP
        {
            get => _secretPCAP;
            set => SetProperty(ref _secretPCAP, value);
        }
        public string SecretEmail
        {
            get => _secretEmail;
            set => SetProperty(ref _secretEmail, value);
        }
        public string EmailAttachment
        {
            get => _emailAttachment;
            set => SetProperty(ref _emailAttachment, value);
        }
    }
}