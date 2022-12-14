using System;
using System.Collections.Generic;
using System.Text;

namespace QuotesApplication
{
    public class Page1ViewModel
    {

        private string _loginUser;

        public string LoginUser
        {
            get { return _loginUser; }
            set { _loginUser = value; }
        }

        public Page1ViewModel(string parameter)
        {
            _loginUser = parameter;
        }



    }

}

