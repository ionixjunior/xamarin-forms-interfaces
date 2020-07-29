using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Core.Interfaces;
using Core.Models.Twitch;
using Prism.Commands;
using Prism.Navigation;

namespace Core.ViewModels
{
    public class TwitchHomeViewModel : BaseViewModel, IInitialize
    {
        private readonly ITwitch _twitch;
        public ObservableCollection<GroupTwitchChannelModel> Channels { get; private set; }
        public ICommand LoadDataCommand { get; private set; }

        private bool _isRefreshing;
        public bool IsRefreshing
        {
            get => _isRefreshing;
            set => RaisePropertyChanged();
        }

        public TwitchHomeViewModel(ITwitch twitch)
        {
            _twitch = twitch;
            Channels = new ObservableCollection<GroupTwitchChannelModel>();
            LoadDataCommand = new DelegateCommand(LoadData);
        }

        private void LoadData()
        {
            IsRefreshing = true;
            Channels.Clear();

            foreach (var channel in _twitch.GetGroupedChannels())
                Channels.Add(channel);
            IsRefreshing = false;
        }

        public override void Initialize(INavigationParameters parameters)
        {
            if (LoadDataCommand.CanExecute(null))
                LoadDataCommand.Execute(null);
        }
    }
}
