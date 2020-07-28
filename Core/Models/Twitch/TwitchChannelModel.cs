using System;
using System.Collections.Generic;

namespace Core.Models.Twitch
{
    public class TwitchChannelModel
    {
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public IList<string> Tags { get; set; }
        public string GroupName { get; set; }
        public int TotalWatching { get; set; }

        public TwitchChannelModel()
        {
            Tags = new List<string>();
        }
    }

    public class GroupTwitchChannelModel : List<TwitchChannelModel>
    {
        public string GroupName { get; set; }

        public GroupTwitchChannelModel(string groupName, List<TwitchChannelModel> channels)
        {
            GroupName = groupName;
            AddRange(channels);
        }
    }
}
