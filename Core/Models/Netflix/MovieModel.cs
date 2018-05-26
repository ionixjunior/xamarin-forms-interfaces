using System;
using System.Collections.Generic;

namespace Core.Models.Netflix
{
    public class MovieModel
    {
        public string Photo { get; set; }
        public string Category { get; set; }
    }

    public class GroupMovieModel : List<MovieModel>
    {
        public string GroupName { get; set; }

        public GroupMovieModel(string groupName, IList<MovieModel> movies)
        {
            GroupName = groupName;
            AddRange(movies);
        }
    }
}
