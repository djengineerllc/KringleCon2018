using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using Prism.Mvvm;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Input;

namespace KringleCon2018.Objectives
{
    public abstract class ObjectiveViewModel : BindableBase
    {
        public ObjectiveViewModel() { }
        private ICommand _navigateCommand, _downloadFileCommand;
        public ICommand NavigateCommand => _navigateCommand = _navigateCommand ?? (_navigateCommand = new RelayCommand<string>((url) =>
                                                                        {
                                                                            try { Process.Start(url); }
                                                                            catch (Exception) { }
                                                                        }, (url) => { return true; }));
        public ICommand DownloadFileCommand => _downloadFileCommand = _downloadFileCommand ?? (_downloadFileCommand = new RelayCommand<string>((url) =>
                                                                        {
                                                                            var uri = new Uri(url);
                                                                            var fi = new FileInfo(uri.AbsolutePath);
                                                                            var ext = fi.Extension;
                                                                            var fileName = string.Empty;
                                                                            if (uri.IsFile) { fileName = Path.GetFileName(uri.LocalPath); }
                                                                            var save = new SaveFileDialog {
                                                                                CheckFileExists = false,
                                                                                CheckPathExists = false,
                                                                                OverwritePrompt = true,
                                                                                AddExtension = true,
                                                                                ValidateNames = false,
                                                                                DefaultExt = ext,
                                                                                RestoreDirectory = true,
                                                                                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                                                                                FileName = fileName,
                                                                                Filter = "All(*.*)|*"
                                                                            };
                                                                            if (save.ShowDialog().GetValueOrDefault()) { File.WriteAllBytes(save.FileName, File.ReadAllBytes(url)); }
                                                                        }, (url) => { return true; }));
    }
}