using System;
using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models.Netflix;
using Core.Externsions;
using System.Collections.Generic;
using Prism.Navigation;

namespace Core.ViewModels
{
    public class NetflixHomeViewModel : BaseViewModel
    {
        private readonly INetflix _netflix;

        private IList<MovieModel> _movies;
        public IList<MovieModel> Movies
        {
            get { return _movies; }
            set
            {
                _movies = value;
                RaisePropertyChanged();
            }
        }

        public NetflixHomeViewModel(INetflix netflix)
        {
            Title = "Netflix";
            _netflix = netflix;

            //Movies = new ObservableCollection<MovieModel>(
            //    netflix.GetMovies()
            //);
        }

		public override void OnNavigatingTo(NavigationParameters parameters)
		{
            base.OnNavigatingTo(parameters);
            Movies = _netflix.GetMovies();
		}
	}
}
