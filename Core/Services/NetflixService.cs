using System;
using System.Collections.Generic;
using Core.Interfaces;
using Core.Models.Netflix;

namespace Core.Services
{
    public class NetflixService : INetflix
    {
        private List<MovieModel> _movies;

        public NetflixService()
        {
            _movies = new List<MovieModel>();

            _movies.Add(GetMovie(
                photo: "https://occ-0-999-1001.1.nflxso.net/art/98c02/fe062be973c1e5213a630913fce3e2422d198c02.jpg",
                category: "Continue Watching for Junior"
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-299-300.1.nflxso.net/art/36f99/0a6572bd35a35792ed7eb6d1575b3d96b1436f99.jpg",
                category: "Continue Watching for Junior"
            ));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BZDNhNzhkNDctOTlmOS00NWNmLWEyODQtNWMxM2UzYmJiNGMyXkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_UY268_CR4,0,182,268_AL_.jpg",
                category: "Continue Watching for Junior"
            ));

            _movies.Add(GetMovie(
                photo: "https://www.ennetflix.pe/media/20/dr-house_70136117.jpg",
                category: "Continue Watching for Junior"
            ));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/80013773.jpg",
                category: "Watch It again"
            ));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/70257818.jpg",
                category: "Watch It again"
            ));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTkyMDkwNDIyMV5BMl5BanBnXkFtZTgwNDU1OTEwNjE@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again"
            ));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTg1ODg4NjUzNF5BMl5BanBnXkFtZTgwOTU5NDc3MTE@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again"
            ));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTM4NTc0Mzk5N15BMl5BanBnXkFtZTcwNDA4NDUyNg@@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again"
            ));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/60010932.jpg",
                category: "Watch It again"
            ));
        }

        private MovieModel GetMovie(
            string photo,
            string category)
        {
            return new MovieModel()
            {
                Photo = photo,
                Category = category
            };
        }

        public IEnumerable<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
