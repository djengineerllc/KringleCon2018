using GalaSoft.MvvmLight.Command;
using MahApps.Metro.IconPacks;
using Newtonsoft.Json;
using System.IO;
using System.Net.Http;
using System.Windows;
using System.Windows.Input;

namespace KringleCon2018.Objectives
{
    public class DoorPassCodeResult
    {
        [JsonProperty("success")]
        public bool Success { get; set; }
        [JsonProperty("message")]
        public string Message { get; set; }
    }
    public class Objective3ViewModel : ObjectiveViewModel
    {
        private string _poem, _poemOriginal, _doorMessage, _tangleCoalbox;
        private PackIconFontAwesome _shape1, _shape2, _shape3, _shape4;
        private PackIconFontAwesome _triangle = new PackIconFontAwesome {
            Kind = PackIconFontAwesomeKind.PlaySolid,
            Rotation = 270,
            Width = 30,
            Height = 30
        };
        private PackIconFontAwesome _square = new PackIconFontAwesome
        {
            Kind = PackIconFontAwesomeKind.SquareFullSolid,
            Width = 30,
            Height = 30
        };
        private PackIconFontAwesome _circle = new PackIconFontAwesome
        {
            Kind = PackIconFontAwesomeKind.CircleSolid,
            Width = 30,
            Height = 30
        };
        private PackIconFontAwesome _star = new PackIconFontAwesome
        {
            Kind = PackIconFontAwesomeKind.StarSolid,
            Width = 30,
            Height = 30
        };
        public Objective3ViewModel()
        {
            Poem = File.ReadAllText("../../Resources/Objectives/Objective3/poem.txt");
            PoemOriginal = File.ReadAllText("../../Resources/Objectives/Objective3/poem_original.txt");
            TangleCoalbox = @"../../Resources/Objectives/Objective3/TangleCoalbox.png";
            Shape1 = CopyIcon(_triangle);
            Shape2 = CopyIcon(_triangle);
            Shape3 = CopyIcon(_triangle);
            Shape4 = CopyIcon(_triangle);
        }
        public string Poem
        {
            get => _poem;
            set => SetProperty(ref _poem, value);
        }
        public string PoemOriginal
        {
            get => _poemOriginal;
            set => SetProperty(ref _poemOriginal, value);
        }
        public PackIconFontAwesome Shape1
        {
            get => _shape1;
            set => SetProperty(ref _shape1, value);
        }
        public PackIconFontAwesome Shape2
        {
            get => _shape2;
            set => SetProperty(ref _shape2, value);
        }
        public PackIconFontAwesome Shape3
        {
            get => _shape3;
            set => SetProperty(ref _shape3, value);
        }
        public PackIconFontAwesome Shape4
        {
            get => _shape4;
            set => SetProperty(ref _shape4, value);
        }
        public string DoorMessage
        {
            get => _doorMessage;
            set => SetProperty(ref _doorMessage, $"Finished - {value}");
        }
        public string TangleCoalbox
        {
            get => _tangleCoalbox;
            set => SetProperty(ref _tangleCoalbox, value);
        }
        private PackIconFontAwesome CopyIcon(PackIconFontAwesome icon) => new PackIconFontAwesome
        {
            Kind = icon.Kind,
            Rotation = icon.Rotation,
            Width = icon.Width,
            Height = icon.Height
        };
        private ICommand _bruteForceCommand;
        public ICommand BruteForceCommand => _bruteForceCommand ?? (_bruteForceCommand = new RelayCommand(async () => 
                                                           {
                                                               var found = false;
                                                               for(var i1=0; i1<4; ++i1)
                                                               {
                                                                   if (found) { break; }
                                                                   SetShape1(i1);
                                                                   for (var i2=0; i2<4; ++i2)
                                                                   {
                                                                       if (found) { break; }
                                                                       SetShape2(i2);
                                                                       for (var i3=0; i3<4; ++i3)
                                                                       {
                                                                           if (found) { break; }
                                                                           SetShape3(i3);
                                                                           for (var i4 = 0; i4 < 4; ++i4)
                                                                           {
                                                                               if (found) { break; }
                                                                               SetShape4(i4);
                                                                               using (var httpClient = new HttpClient())
                                                                               {
                                                                                   var jsonResp = await httpClient.GetStringAsync($"https://doorpasscode.kringlecastle.com/checkpass.php?i={i1}{i2}{i3}{i4}&resourceId=%22");
                                                                                   var result = JsonConvert.DeserializeObject<DoorPassCodeResult>(jsonResp);
                                                                                   if (result.Success)
                                                                                   {
                                                                                       Application.Current.Dispatcher.Invoke(() => {
                                                                                           DoorMessage = result.Message;
                                                                                       });
                                                                                       found = true;
                                                                                       i4 = 100;
                                                                                       i3 = 100;
                                                                                       i2 = 100;
                                                                                       i1 = 100;
                                                                                       break;
                                                                                   }
                                                                                   else
                                                                                   {
                                                                                       Application.Current.Dispatcher.Invoke(() => {
                                                                                           DoorMessage = $"{i1}{i2}{i3}{i4} - {result.Message}";
                                                                                       });
                                                                                   }
                                                                               }
                                                                           }
                                                                       }
                                                                   }
                                                               }
                                                           }, () => { return true; }));

        private void SetShape4(int i) => Application.Current.Dispatcher.Invoke(() =>
        {
            Shape4 = GetShape(i);
        });
        private void SetShape3(int i) => Application.Current.Dispatcher.Invoke(() =>
        {
            Shape3 = GetShape(i);
        });
        private void SetShape2(int i) => Application.Current.Dispatcher.Invoke(() =>
        {
            Shape2 = GetShape(i);
        });
        private void SetShape1(int i) => Application.Current.Dispatcher.Invoke(() =>
        {
            Shape1 = GetShape(i);
        });
        private PackIconFontAwesome GetShape(int i)
        {
            switch (i)
            {
                case 1:
                    return CopyIcon(_square);
                case 2:
                    return CopyIcon(_circle);
                case 3:
                    return CopyIcon(_star);
                case 0:
                default:
                    return CopyIcon(_triangle);
            }
        }
    }
}