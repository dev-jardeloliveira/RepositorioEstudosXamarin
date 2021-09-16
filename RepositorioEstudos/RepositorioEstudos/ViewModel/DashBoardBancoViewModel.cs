using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class DashBoardBancoViewModel:BaseViewModel
    {
        #region campos
        public ICommand VisibilidadeSaldoCommand { get; set; }
        #endregion
        #region construtor
        public DashBoardBancoViewModel()
        {
            VisibilidadeSaldoCommand = new Command(() =>
            {
                SaldoVisibilidade();
            });
        }
        #endregion
        #region metodo
        public void SaldoVisibilidade()
        {
            VisibilidadeSaldo = VisibilidadeSaldo ? false : true;
        }
        #endregion
        #region propriedade
        private bool _visibilidadeSaldo = true;
        public bool VisibilidadeSaldo
        {
            get { return _visibilidadeSaldo; }
            set { SetProperty(ref _visibilidadeSaldo , value); }
        }

        #endregion
    }
}
