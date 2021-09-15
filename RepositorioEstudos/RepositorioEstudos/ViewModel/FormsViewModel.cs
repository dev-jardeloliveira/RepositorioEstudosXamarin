using RepositorioEstudos.Validacao;
using System.ComponentModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace RepositorioEstudos.ViewModel
{
    public class FormsViewModel : INotifyPropertyChanged
    {
        #region campos
        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand ValidarCommand { get; set; }
        #endregion
        #region construtor
        public FormsViewModel()
        {
            AddValidations();
            ValidarCommand = new Command(() =>
            {
                ValidateUserName();
                   


            });

        }


        #endregion
        #region método
        private void AddValidations()
        {
            Nome.Validations.Add(new IsNotNullOrEmptyRegra<string> { ValidationMessage = "Preencher o nome" });

        }
        public bool ValidateUserName()
        {
            return Nome.Validate();
        }
        #endregion
        #region propriedade
        public ValidatableObject<string> Nome { get; set; } = new ValidatableObject<string>();
        
        #endregion
    }
}
