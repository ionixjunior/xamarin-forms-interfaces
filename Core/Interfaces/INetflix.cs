using System;
using System.Collections.Generic;
using Core.Models.Netflix;

namespace Core.Interfaces
{
    public interface INetflix
    {
        IEnumerable<MovieModel> GetMovies();
    }
}
