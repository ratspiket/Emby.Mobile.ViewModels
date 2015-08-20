using Emby.Mobile.Core.Interfaces;
using MediaBrowser.Model.ApiClient;

namespace Emby.Mobile.ViewModels
{
    public abstract class ViewModelBase : GalaSoft.MvvmLight.ViewModelBase
    {
        protected IServices Services { get; }
        public ILog Log { get; }

        protected ViewModelBase(IServices services)
        {
            Services = services;
            Log = Services.Log;

            if (!IsInDesignMode)
            {
                WireMessages();
            }
        }

        protected virtual void WireMessages()
        {
        }

        public void SetProgressBar(string text)
        {
            ProgressIsVisible = true;
            ProgressText = text;

            UpdateProperties();
        }

        public void SetProgressBar()
        {
            ProgressIsVisible = false;
            ProgressText = string.Empty;

            UpdateProperties();
        }

        public virtual void UpdateProperties() { }
        
        public bool ProgressIsVisible { get; set; }
        public string ProgressText { get; set; }

        protected IApiClient ApiClient => Services.Connection.GetApiClient("");
    }
}