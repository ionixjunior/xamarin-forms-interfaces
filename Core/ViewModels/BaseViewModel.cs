using System;
using Prism.Mvvm;

namespace Core.ViewModels
{
    public class BaseViewModel : BindableBase
    {
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        private string _title;
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }
    }
}
