using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace QuotesApplication
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }

        private string _userName;   //propfull + Tab.

        private INavigation _navigation;
 
        public string UserName      // 'Οτι γράφω στο Entry πηγαίνει στο property UserName.
        {
            get { return _userName; }
            set { _userName = value; OnPropertyChanged("UserName"); }
        }

        public MainViewModel(INavigation navigation)
        {
            LoginCommand = new Command(Login);
            _navigation = navigation;
        }

        private void Login()
        {
            //App.Current.MainPage.DisplayAlert("Hi", _userName, "Alright");
            _navigation.PushAsync(new Page1(_userName));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
