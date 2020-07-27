using System.Collections.Generic;
using Core.Interfaces;
using Core.Models.Twitch;
using System.Linq;

namespace Core.Services
{
    public class TwitchService : ITwitch
    {
        private IList<TwitchChannelModel> _channels;

        public TwitchService()
        {
            _channels = new List<TwitchChannelModel>();

            _channels.Add(new TwitchChannelModel
            {
                Name = "Vovo_Tibiano",
                Avatar = "",
                Description = "🔞 Vovô Tibiano 19/07.2929 joganto Tibia",
                Category = "Tibia",
                Tags = new List<string> { "Portuguese" },
                GroupName = "LIVE CHANNELS",
                TotalWatching = 59
             });

            _channels.Add(new TwitchChannelModel
            {
                Name = "Leshrot",
                Avatar = "",
                Description = "[DA Study] Fazendo comida em live",
                Category = "Art",
                Tags = new List<string> { "Portuguese" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 10
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "rinconhacking",
                Avatar = "",
                Description = "UHC - Ultimate Hacking",
                Category = "Science & Technology",
                Tags = new List<string> { "Portuguese" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 24
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "VapeJuiceJordan",
                Avatar = "",
                Description = "FAANG Staff Software Engineer building frontend app // !today",
                Category = "Science & Technology",
                Tags = new List<string> { "English", "Programming", "Web Development", "Software Development" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 138
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "JdotW",
                Avatar = "",
                Description = "[Swift+React+NodeJS] | GOD THE JOB",
                Category = "Science & Technology",
                Tags = new List<string> { "English" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 171
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "Leshrot",
                Avatar = "",
                Description = "[DA Study] Fazendo comida em live",
                Category = "Art",
                Tags = new List<string> { "Portuguese" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 10
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "rinconhacking",
                Avatar = "",
                Description = "UHC - Ultimate Hacking",
                Category = "Science & Technology",
                Tags = new List<string> { "Portuguese" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 24
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "VapeJuiceJordan",
                Avatar = "",
                Description = "FAANG Staff Software Engineer building frontend app // !today",
                Category = "Science & Technology",
                Tags = new List<string> { "English", "Programming", "Web Development", "Software Development" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 138
            });

            _channels.Add(new TwitchChannelModel
            {
                Name = "JdotW",
                Avatar = "",
                Description = "[Swift+React+NodeJS] | GOD THE JOB",
                Category = "Science & Technology",
                Tags = new List<string> { "English" },
                GroupName = "RECOMMENDED CHANNELS",
                TotalWatching = 171
            });
        }

        public IList<TwitchChannelModel> GetChannels()
        {
            return _channels;
        }

        public IList<GroupTwitchChannelModel> GetGroupedChannels()
        {
            return _channels
                .GroupBy(x => x.GroupName)
                .Select(x => new GroupTwitchChannelModel(x.Key, x.ToList()))
                .ToList();
        }
    }
}
