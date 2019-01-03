using System;
using System.IO;

namespace KringleCon2018.Objectives
{
    public class Objective7ViewModel : ObjectiveViewModel
    {
        private string _gitCommit1, _gitCommit2, _docxDownload, _krampus1, _krampus2;
        public Objective7ViewModel()
        {
            GitCommit1 = @"../../Resources/Objectives/Objective7/Commit60a2ffea7520ee980a5fc60177ff4d0633f2516b.png";
            GitCommit2 = @"../../Resources/Objectives/Objective7/Commitd99d465d5b9711d51d7b455584af2b417688c267.png";
            DocxDownload = Path.Combine(Environment.CurrentDirectory, @"Resources\Objectives\Objective7\candidate_evaluation.docx");
            Krampus1 = @"../../Resources/Objectives/Objective7/Krampus1.png";
            Krampus2 = @"../../Resources/Objectives/Objective7/Krampus2.png";
        }
    public string GitCommit1
        {
            get => _gitCommit1;
            set => SetProperty(ref _gitCommit1, value);
        }
        public string GitCommit2
        {
            get => _gitCommit2;
            set => SetProperty(ref _gitCommit2, value);
        }
        public string DocxDownload
        {
            get => _docxDownload;
            set => SetProperty(ref _docxDownload, value);
        }
        public string Krampus1
        {
            get => _krampus1;
            set => SetProperty(ref _krampus1, value);
        }
        public string Krampus2
        {
            get => _krampus2;
            set => SetProperty(ref _krampus2, value);
        }
    }
}