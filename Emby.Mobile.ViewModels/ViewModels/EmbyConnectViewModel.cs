using Emby.Mobile.Core.Interfaces;

namespace Emby.Mobile.ViewModels
{
    public class EmbyConnectViewModel : ViewModelBase
    {
        public EmbyConnectViewModel(IServices services) 
            : base(services)
        {
        }

        public string Username { get; set; }
        public string Password { get; set; }

        public bool CanSignIn => !ProgressIsVisible
                                 && !string.IsNullOrWhiteSpace(Username)
                                 && !string.IsNullOrWhiteSpace(Password);

        public override void UpdateProperties()
        {
            RaisePropertyChanged(() => CanSignIn);
        }
    }
}
