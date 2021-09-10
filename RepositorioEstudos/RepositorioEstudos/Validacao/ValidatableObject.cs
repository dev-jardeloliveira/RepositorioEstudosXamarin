using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace RepositorioEstudos.Validacao
{
    public class ValidatableObject<T> : IValidacao<T>
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public List<IValidationRegras<T>> Validations { get; } = new List<IValidationRegras<T>>();

        public List<string> Errors { get; set; } = new List<string>();

        public bool CleanOnChange { get; set; } = true;

        T _value;
        public T Value
        {
            get => _value;
            set
            {
                _value = value;

                if (CleanOnChange)
                    IsValid = true;
            }
        }

        public bool IsValid { get; set; } = true;

        List<IValidationRegras<T>> IValidacao<T>.Validations => throw new NotImplementedException();

        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged
        {
            add
            {
                throw new NotImplementedException();
            }

            remove
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool Validate()
        {
            Errors.Clear();

            IEnumerable<string> errors = Validations.Where(v => !v.Check(Value))
                .Select(v => v.ValidationMessage);

            Errors = errors.ToList();
            IsValid = !Errors.Any();

            return this.IsValid;
        }
        public override string ToString()
        {
            return $"{Value}";
        }
    
    }
}
