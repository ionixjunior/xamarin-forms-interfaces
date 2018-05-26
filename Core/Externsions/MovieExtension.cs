using System.Linq;
using System.Collections.Generic;
using Core.Models.Netflix;

namespace Core.Externsions
{
    public static class MovieExtension
    {
        public static IList<GroupMovieModel> GroupByCategory(
            this IList<MovieModel> movies)
        {
            return movies.GroupBy(m => m.Category)
                         .Select(
                             group => new GroupMovieModel(
                                 group.Key, 
                                 group.ToList()
                                )
                            )
                         .ToList();
        }
    }
}
