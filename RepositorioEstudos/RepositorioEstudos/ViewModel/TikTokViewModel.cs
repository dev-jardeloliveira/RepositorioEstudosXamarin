using System;
using System.Collections.Generic;
using System.Text;

namespace RepositorioEstudos.ViewModel
{
    public class TikTokViewModel:BaseViewModel
    {
        #region construtor
        public TikTokViewModel()
        {
            TabHome = "Home";
            TabHome.ToLower();
        }
        #endregion
        #region propriedade
        private string _tabHome;
        public string TabHome
        {
            get =>_tabHome; 
            set {SetProperty(ref _tabHome, value); }
        }

        #endregion
    }
}
