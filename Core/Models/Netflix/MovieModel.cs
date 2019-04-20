using System.Linq;
using System.Collections.Generic;
using Core.Enums;

namespace Core.Models.Netflix
{
    public class MovieModel
    {
        public string Photo { get; set; }
        public string Category { get; set; }
		public double Height { get; set; }
		public NetflixMovieType Type { get; set; }
	}

    public class GroupMovieModel : List<MovieModel>
    {
        public string GroupName { get; set; }
		public double Height { get; set; }

		public GroupMovieModel(string groupName, IList<MovieModel> movies)
        {
            GroupName = groupName;
            AddRange(movies);
			Height = movies.First().Height;
        }
    }
}
