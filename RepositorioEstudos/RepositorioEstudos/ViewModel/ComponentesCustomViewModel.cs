using RepositorioEstudos.Validacao;
using System.ComponentModel;

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
        public ValidatableObject<string> Nome { get; set; } = new ValidatableObject<string>();
      

        #endregion
    }
}
