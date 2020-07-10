using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinSample.Services;
using XamarinSample.Tools;
using XamarinSample.Views;

namespace XamarinSample.ViewModels
{
    public class addPersonneViewModel : ViewModelBase
    {
		private string _nom;

		public string Nom
		{
			get { return _nom; }
			set { SetValue(ref _nom, value); }
		}

		private string _email;

		public string Email
		{
			get { return _email; }
			set { SetValue(ref _email, value); }
		}

		private Command _validateButton;

		public Command ValidateButton
		{
			get { return _validateButton = _validateButton ?? new Command(Register); }
		}

		public void Register()
		{
			DependencyService.Get<PersonneService>().Add(new Models.Personne
			{
				Nom = Nom,
				Email = Email
			});
		}

		private Command _afficherListe;

		public Command AfficheListe
		{
			get { return _afficherListe = _afficherListe ?? new Command(Affiche); }
		}

		public void Affiche()
		{
			App.Current.MainPage.Navigation.PushModalAsync(new ListPersonneView());
		}

	}
}
