namespace RepositorioEstudos.Validacao
{
    public class IsNotNullOrEmptyRegra<T>: IValidationRegras<T>
    {
        public string ValidationMessage { get; set; }

        public bool Check(T value)
        {
            if (value == null)
            {
                return false;
            }

            var str = $"{value }";
            return !string.IsNullOrWhiteSpace(str);
        }
    }
}
