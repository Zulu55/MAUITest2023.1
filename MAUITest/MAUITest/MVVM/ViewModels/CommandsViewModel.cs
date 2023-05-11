﻿using System.Windows.Input;

namespace MAUITest.MVVM.ViewModels
{
    public class CommandsViewModel
    {
        public CommandsViewModel()
        {
        }

        public string SearchTerm { get; set; }

        public ICommand ClickCommand => new Command(() => App.Current.MainPage.DisplayAlert("Title", "Message", "Ok"));

        public ICommand SearchCommand => new Command(() => App.Current.MainPage.DisplayAlert("Búsqueda", $"Buscaste: {SearchTerm}", "Ok"));
    }
}
