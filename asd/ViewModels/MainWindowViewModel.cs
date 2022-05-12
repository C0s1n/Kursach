using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using ReactiveUI;
using System.Reactive.Linq;
using Kotin_Curs.Models;

namespace Kotin_Curs.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateTabs();
            CreateGrid();
            CreateRequests();
            Content = Fv = new FirstViewModel(this);
            Sv = new SecondViewModel(this);
        }

        public FirstViewModel Fv { get; }
        public SecondViewModel Sv { get; }

        public void Change()
        {
            if (Content == Fv)
                Content = Sv;
            else if (Content == Sv)
                Content = Fv;
        }

        ViewModelBase content;
        public ViewModelBase Content
        {
            get { return content; }
            set { this.RaiseAndSetIfChanged(ref content, value); }
        }

        ObservableCollection<Tabs> tab;
        public ObservableCollection<Tabs> Tab
        {
            get { return tab; }
            set { this.RaiseAndSetIfChanged(ref tab, value); }
        }
        private void CreateTabs()
        {
            Tab = new ObservableCollection<Tabs>();
            Tab.Add(new Tabs("racer",false));
            Tab.Add(new Tabs("Запрос 1", true));
            Tab.Add(new Tabs("Запрос 2", true));
            Tab.Add(new Tabs("Запрос 3", true));

        }

        ObservableCollection<Tabs> request;
        public ObservableCollection<Tabs> Request
        {
            get { return request; }
            set { this.RaiseAndSetIfChanged(ref request, value); }
        }

        private void CreateRequests()
        {
            Request = new ObservableCollection<Tabs>();
            Request.Add(new Tabs("Запрос 1", true));
            Request.Add(new Tabs("Запрос 2", true));
            Request.Add(new Tabs("Запрос 3", true));
        }

        ObservableCollection<Grids> grid;
        public ObservableCollection<Grids> Grid
        {
            get { return grid; }
            set { this.RaiseAndSetIfChanged(ref grid, value); }
        }
        private void CreateGrid()
        {
            Grid = new ObservableCollection<Grids>();
            Grid.Add(new Grids("Joe Baiden", "1", "HAMBAGA" , "14"));
            Grid.Add(new Grids("Volodya Pupkin", "2", "UKRAINE", "12"));
            Grid.Add(new Grids("Nyaga Lee", "3", "THAILAND", "228"));
        }



        


    }
}
