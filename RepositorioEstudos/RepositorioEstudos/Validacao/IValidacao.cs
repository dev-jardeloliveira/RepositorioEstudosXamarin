using System.Collections.Generic;
using System.ComponentModel;

namespace RepositorioEstudos.Validacao
{
    public interface IValidacao<T>:INotifyPropertyChanged
    {
        List<IValidationRegras<T>> Validations { get; }

        List<string> Errors { get; set; }

        bool Validate();

        bool IsValid { get; set; }
    }
}
