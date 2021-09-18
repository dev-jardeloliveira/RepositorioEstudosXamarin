using RepositorioEstudos.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class DashBoardBancoViewModel:BaseViewModel
    {
        #region campos
        public ICommand VisibilidadeSaldoCommand { get; set; }
        public ICommand VisibilidadeSaldoFaturaCommand { get; set; }
        #endregion
        #region construtor
        public DashBoardBancoViewModel()
        {
            ListaDeAtivos();
            FinalNumeroCartao = 1637;
            ProgressCartaoDeCredito = 0.8;
            ValorDisponivelCartaoDeCredito = 6000m ;
            ValorUtilizadoCartaoDeCredito = 4000m ;
            ValorFaturaCartaoDeCredito = 1875m;
            ExpandirFatura = new Expandir
            {
                Icone = "\uf078",
                Texto = "expandir "
            };
            VisibilidadeSaldoCommand = new Command(() =>
            {
                SaldoVisibilidade();
            });
            VisibilidadeSaldoFaturaCommand = new Command(() =>
            {
                SaldoFaturaVisibilidade();
            });
        }
        #endregion
        #region metodo
        internal void SaldoVisibilidade()
        {
            VisibilidadeSaldo = VisibilidadeSaldo ? false : true;
        }
        internal void SaldoFaturaVisibilidade()
        {
            VisibilidadeSaldoFatura = VisibilidadeSaldoFatura ? false : true;
            if (VisibilidadeSaldoFatura)
            {
                ExpandirFatura = new Expandir
                {
                    Icone = "\uf077",
                    Texto = "ocultar "
                };
            }
            else
            {
                ExpandirFatura = new Expandir
                {
                    Icone = "\uf078",
                    Texto = "expandir "
                };
             
            }
        }
        internal void ListaDeAtivos()
        {
            Ativos = new ObservableCollection<Dashboard>
            {
                 new Dashboard{ Id= 1, Titulo="Soluções", Icone="\uf015"},
                 new Dashboard{ Id= 2, Titulo="Pix", Icone="\uf065"},
                 new Dashboard{ Id= 3, Titulo="Bitcoint", Icone="\uf080"},
                 new Dashboard{ Id= 4, Titulo="Pagar", Icone="\uf02a"},
                 new Dashboard{ Id= 5, Titulo="Financiamento", Icone="\uf1b9"},
                 new Dashboard{ Id= 6, Titulo="Contato", Icone="\uf075"},
                 new Dashboard{ Id= 7, Titulo="Campras", Icone="\uf290"}
            };
        }
        #endregion
        #region propriedade
        private bool _visibilidadeSaldo = true;
        public bool VisibilidadeSaldo
        {
            get { return _visibilidadeSaldo; }
            set { SetProperty(ref _visibilidadeSaldo , value); }
        }

        private bool _visibilidadeSaldoFatura = false;
        public bool VisibilidadeSaldoFatura
        {
            get { return _visibilidadeSaldoFatura; }
            set { SetProperty(ref _visibilidadeSaldoFatura, value); }
        }

        private ObservableCollection<Dashboard> _ativos;

        public ObservableCollection<Dashboard> Ativos
        {
            get { return _ativos; }
            set { SetProperty(ref _ativos, value); }
        }
        private int _finalNumeroCartao;
        public int FinalNumeroCartao
        {
            get { return _finalNumeroCartao; }
            set {SetProperty(ref _finalNumeroCartao, value); }
        }

        private double _progressCartaoDeCredito;
        public double ProgressCartaoDeCredito
        {
            get { return _progressCartaoDeCredito; }
            set {SetProperty(ref _progressCartaoDeCredito, value); }
        }

        private decimal _valorDisponivelCartaoDeCredito;
        public decimal ValorDisponivelCartaoDeCredito
        {
            get { return _valorDisponivelCartaoDeCredito; }
            set {SetProperty(ref _valorDisponivelCartaoDeCredito, value); }
        }
        private decimal _valorUtilizadoCartaoDeCredito;
        public decimal ValorUtilizadoCartaoDeCredito
        {
            get { return _valorUtilizadoCartaoDeCredito; }
            set { SetProperty(ref _valorUtilizadoCartaoDeCredito, value); }
        }
        private decimal _valorFaturaCartaoDeCredito;
        public decimal ValorFaturaCartaoDeCredito
        {
            get { return _valorFaturaCartaoDeCredito; }
            set { SetProperty(ref _valorFaturaCartaoDeCredito, value); }
        }

        private Expandir _expandirFatura;
        public Expandir ExpandirFatura
        {
            get { return _expandirFatura; }
            set {SetProperty(ref _expandirFatura, value); }
        }

        #endregion
    }
}
