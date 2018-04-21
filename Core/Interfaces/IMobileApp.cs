using System.Collections.Generic;
using Core.Models;

namespace Core.Interfaces
{
    public interface IMobileApp
    {
        IList<MobileAppModel> GetApps();
    }
}
