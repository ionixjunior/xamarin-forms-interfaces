using System;
using System.Collections.ObjectModel;
using Core.Interfaces;
using Core.Models.Netflix;
using Core.Externsions;
using System.Collections.Generic;

namespace Core.ViewModels
{
    public class NetflixHomeViewModel : BaseViewModel
    {
        public IEnumerable<MovieModel> Movies { get; }

        public NetflixHomeViewModel(INetflix netflix)
        {
            Title = "Netflix";

            Movies = netflix.GetMovies();

            //Movies = new ObservableCollection<MovieModel>(
            //    netflix.GetMovies()
            //);
        }
    }
}
