using MediaBrowser.Model.ApiClient;

namespace Emby.Mobile.Core.Interfaces
{
    public interface IServices
    {
        ILog Log { get; }
        INavigationService Navigation { get; }
        IConnectionManager Connection { get; }
    }
}
