

namespace RepositorioEstudos.Validacao
{
    public interface IValidationRegras<T>
    {
        string ValidationMessage { get; set; }
        bool Check(T value);
    }
}
