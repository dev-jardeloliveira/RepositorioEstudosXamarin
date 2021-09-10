using RepositorioEstudos.Validacao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace RepositorioEstudos.ViewModel
{
    public class ComponentesCustomViewModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        #region Construtor
        public ComponentesCustomViewModel()
        {
            Nome.Validations.Add(new IsNotNullOrEmptyRegra<string> { ValidationMessage = "Preencha o campo nome." });
        }
        #endregion
        #region Propriedades
        private ValidatableObject<string> _nome;       

        public ValidatableObject<string> Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        #endregion
    }
}
