using System;
using System.Collections.Generic;
using Core.Enums;
using Core.Interfaces;
using Core.Models.Netflix;

namespace Core.Services
{
    public class NetflixService : INetflix
    {
        private IList<MovieModel> _movies;

        public NetflixService()
        {
            _movies = new List<MovieModel>();

			_movies.Add(GetMovie(
				photo: "https://occ-0-300-299.1.nflxso.net/dnm/api/v6/XsrytRUxks8BtTRf9HNlZkW2tvY/AAAABdEw93WVZ0zDG3TQJXeUTxkz9lY8hqoZgixCvIbdO2USNAnMgTprsaA2bJRmL8AaTDYH2O_afPTUUbib7ebkUjvk4G9qbn_nKg.jpg",
				category: string.Empty, 
				height: 400,
				type: NetflixCoverType.Featured
			));

			_movies.Add(GetMovie(
				photo: "https://media.fstatic.com/GorkuV4RLafbsTvrKmzud9GL6tY=/fit-in/290x478/smart/media/movies/covers/2019/04/MV5BMmYzNzNiNTQtNjhmNC00ZmIyLWI2YTYtNTg5NTUyN2Y1YjNlXkEyXkFqcGdeQX_USR6xpS.jpg",
				category: "Recently Added", 
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://i2.wp.com/www.jornadageek.com.br/wp-content/uploads/2019/03/No-Good-Nick.jpg?fit=607%2C900&ssl=1",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://upload.wikimedia.org/wikipedia/en/thumb/3/31/The_Silence_2019_film_poster.jpg/220px-The_Silence_2019_film_poster.jpg",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://onnetflix.ca/media/4/mighty-little-bheem_80211492.jpg",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://thecentraltrend.com/wp-content/uploads/2019/04/AAAABQr629iFfXp0VdUiRJHrrW9zxwkY98MEaEEyaNFIQjhiajmOMS4EV33gibA3QEqfoHwfP9cEa8hz9-IUN10J_OCc68m635SuKg.jpg",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://m.media-amazon.com/images/M/MV5BZmFkOTQxYzUtYzViNS00YjI3LWFhZDMtOTJjYjRiNDIxNDUzXkEyXkFqcGdeQXVyNDg4NjY5OTQ@._V1_UX182_CR0,0,182,268_AL_.jpg",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://m.media-amazon.com/images/M/MV5BMTkxODk1MTM3Nl5BMl5BanBnXkFtZTgwNDUxNzg0NzM@._V1_UY209_CR0,0,140,209_AL_.jpg",
				category: "Recently Added",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
                photo: "https://occ-0-999-1001.1.nflxso.net/art/98c02/fe062be973c1e5213a630913fce3e2422d198c02.jpg",
                category: "Continue Watching for Junior",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://occ-0-299-300.1.nflxso.net/art/36f99/0a6572bd35a35792ed7eb6d1575b3d96b1436f99.jpg",
                category: "Continue Watching for Junior",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BZDNhNzhkNDctOTlmOS00NWNmLWEyODQtNWMxM2UzYmJiNGMyXkEyXkFqcGdeQXVyNTMxMjgxMzA@._V1_UY268_CR4,0,182,268_AL_.jpg",
                category: "Continue Watching for Junior",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://www.ennetflix.pe/media/20/dr-house_70136117.jpg",
                category: "Continue Watching for Junior",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/0DW6CdE4gYtYx8iy3aj8gs9WtXE/AAAABbM_YP4LhpN0hEKHFfoh9i-gemVDb6uX5VNB9q77xCi46oJdAL7qhSiGRKJ6Jz_y8iI-FSt_MUslySZ8Kvlzup7WPEXXHWGX.jpg?r=1f7",
                category: "Available",
                height: 280,
                type: NetflixCoverType.Playable
            ));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/80013773.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/70257818.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTkyMDkwNDIyMV5BMl5BanBnXkFtZTgwNDU1OTEwNjE@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTg1ODg4NjUzNF5BMl5BanBnXkFtZTgwOTU5NDc3MTE@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://ia.media-imdb.com/images/M/MV5BMTM4NTc0Mzk5N15BMl5BanBnXkFtZTcwNDA4NDUyNg@@._V1_UX182_CR0,0,182,268_AL_.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://assets.nflxext.com/us/boxshots/ghd/60010932.jpg",
                category: "Watch It again",
				height: 160,
				type: NetflixCoverType.Standard
			));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABdpzPexZD5Acctpjbtz-OI-oC8kpuA6dEjgKLe7apg_CfbLLVBBX8uIckoztuXLXbluQfo9KXSEFKAbofrryCHx-WrdxO27zugt-eBdWXswQ8oWYBmHEZ7UP0bUCN0OIsEjETMNYEn7Azysy-Nn8LBwI8A.jpg?r=645",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABefoCCaOdKAnm4cYmcoIVJmBw2zLtjSkUFtNgQK85nLm35kTC6dYnH2uzYWo85mGYb32KVuKZUhaWnaK1KCbevi8lcBSI2IGCJdZRLA0q3YH4vY4GDNS39XQbhmqr4ys1MGxg_XtB6ITvQVzB6GUwEjydQ.jpg?r=97b",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABSdU32e5m_SHvzgupGs7ldEsz3XWA8I_zg3ZmO0l4g6mzGqQQHz0tkmZtCeO5KgZ36dBsYYvFtK4c-eucSnKmmRxJWXuiOB7EZBWiTpLsQ6s0U9cI-05cy7Ht46Kln49tRHxKCFqgDxIM7wEunJ9835woQ.jpg?r=aa2",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABVogRjQBVs112WcXAJFhTSvyxYSWYklVkqEuhyGASbpcrd1Mc78Qcp1MO0MMaU1m0qeegDM19A-iGArGVIGsPDDTYzsYwoiu7pH7QWYGBcFNJzkSA0aK03gSDzVG5IjbNR5JMc7-Ro9DKUNTZ1u1pREluQ.jpg?r=297",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABTh7T_c71ILV3-usb--1zUklvocnolzmHR2NSWEXhJz2h60LoKh8IFknPovIESc0Q7yhiNLfNdurYJddbaj7_jvHJE3Ytf1NzXzD1dpmEvm16V46jYe5_VGEC4-k7W_Gu_4orDh3GxWwL8Z9VRGOjO3dNg.jpg?r=c39",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABaWbs_-YMixe21MDrRZBS2K4GSdUL_zTqZ6oGnHeONNhASug5hLl4ku-6aphQix4qTDYpL3DabP68EjvLox2mb62NWf7opIjrNWiW4xFVquEhscxo88HTqSy84g2CBMtUbKVMUa0LBOMoWKO8okJacdhGA.jpg?r=f45",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABftlkyknkdwqdLVCA1c98PKgB70vPi0GrtmFhfDDuO2JvTER9ijvE5E3T9EFcIG1emOcySxtMvByq-MVUNPiiFWK2ilizRHFDjemjHDFBTtY0FHRbfo0488_s43gu07K51_mBz2m2gsEjPmZVC4ktCFPCo9UV74b9dy3L7Q9aSyoTgV0ZdGcP9Wu4qdJ_k20GgQ-VRJORjZpjg.jpg?r=ebc",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
                photo: "https://occ-0-125-1123.1.nflxso.net/dnm/api/v6/-3LCfR4ku5iSvFIKPvA7ecGrMpA/AAAABX2RXbtbODqch-vpCkqS16DGtSQv8a3r7FteCQoAzY5v1l3MBagiTgd6aIRiZQx9MqnXXCGUenX02QFo5cD0DtrVrycT9bYDKvj_HEeKjFbB3kqiaNutinRx4Lv5msQ31bAwaXTPDAV_cY8Dt3c8WkZNkw.jpg?r=7d0",
                category: "NETFLIX ORIGINALS",
                height: 300,
                type: NetflixCoverType.Standard
            ));

            _movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70243455.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70113298.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80220676.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80057120.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80087076.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80073823.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80224362.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80240964.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/197/80131552.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80039307.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80217054.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/81000504.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80238651.jpg",
				category: "Popular on Netflix",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80083790.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80045923.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80235276.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/60030968.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70038380.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80097521.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70299913.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80040267.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80187062.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70267837.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80185959.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70264711.jpg",
				category: "US Documentaries",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/197/70157348.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80239019.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70213471.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/70100278.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80130987.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80221908.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://i.pinimg.com/originals/49/02/34/490234a14c9fd39685760cb50c6ad3a2.jpg",
				category: "TV Shows",
				height: 160,
				type: NetflixCoverType.Standard
			));

			_movies.Add(GetMovie(
				photo: "https://assets.nflxext.com/us/boxshots/hd1080/80095708.jpg",
				category: "TV Shows",
				height: 160, 
				type: NetflixCoverType.Standard
			));
		}

        private MovieModel GetMovie(
            string photo,
            string category, 
			double height,
			NetflixCoverType type)
        {
            return new MovieModel()
            {
                Photo = photo,
                Category = category, 
				Height = height, 
				Type = type
            };
        }

        public IList<MovieModel> GetMovies()
        {
            return _movies;
        }
    }
}
