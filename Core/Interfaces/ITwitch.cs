using System.Collections.Generic;
using Core.Models.Twitch;

namespace Core.Interfaces
{
    public interface ITwitch
    {
        IList<TwitchChannelModel> GetChannels();
        IList<GroupTwitchChannelModel> GetGroupedChannels();
    }
}
