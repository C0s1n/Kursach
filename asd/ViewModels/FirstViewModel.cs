using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;
using Kotin_Curs.Models;https://github.com/C0s1n/Kursach/blob/main/asd/ViewModels/FirstViewModel.cs
    
namespace C0s.ViewModels
{
    public class FirstViewModel : ViewModelBase
    {

        public FirstViewModel(MainWindowViewModel? mainContext = null)
        {
            MainContext = mainContext;
        }

        public ReactiveCommand<Tabs, Unit> ButtonDeleteTab { get; }

        public MainWindowViewModel? MainContext { get; set; }


    }
}
