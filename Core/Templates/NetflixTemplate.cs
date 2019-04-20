using Core.Enums;
using Core.Models.Netflix;
using Core.Templates.Netflix;
using Xamarin.Forms;

namespace Core.Templates
{
	public class NetflixTemplate : DataTemplateSelector
	{
		private readonly DataTemplate _featured;
		private readonly DataTemplate _standard;

		public NetflixTemplate()
		{
			_featured = new DataTemplate(typeof(Featured));
			_standard = new DataTemplate(typeof(Standard));
		}

		protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
		{
			var movie = item as MovieModel;

			if (movie.Type == NetflixMovieType.Featured)
				return _featured;

			if (movie.Type == NetflixMovieType.Standard)
				return _standard;

			return _standard;
		}
	}
}
