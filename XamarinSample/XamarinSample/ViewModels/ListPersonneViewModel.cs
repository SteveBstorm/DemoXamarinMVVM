using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinSample.Models;
using XamarinSample.Services;
using XamarinSample.Tools;

namespace XamarinSample.ViewModels
{
    public class ListPersonneViewModel : ViewModelBase
    {
        private List<Personne> _maListe;

        public List<Personne> MaListe
        {
            get { return _maListe; }
            set { SetValue(ref _maListe, value); }
        }

        public ListPersonneViewModel()
        {
            LoadItems();
        }

        private void LoadItems()
        {
            if (MaListe != null) MaListe.Clear();
            MaListe = DependencyService.Get<PersonneService>().GetAll();
        }

        private Command _fermer;

        public Command Fermer
        {
            get { return _fermer = _fermer ?? new Command(fermeture); }
        }

        public void fermeture()
        {
            App.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
