

using RepositorioEstudos.Model;
using System.Collections.ObjectModel;

namespace RepositorioEstudos.ViewModel
{
    public class OnboardingViewModel
    {
        #region propriedade
        private ObservableCollection<Onboarding> _onboardings;

        public ObservableCollection<Onboarding> Onboardings 
        {
            get { return _onboardings; }
            set { _onboardings = value; }
        }

        #endregion
        #region contrutor
        public OnboardingViewModel()
        {
            
            CardsAdd();
        }
        #endregion
        #region método
        private void CardsAdd()
        {
            Onboardings = new ObservableCollection<Onboarding>();
            Onboardings.Add(new Onboarding { Id = 1, Imagem = "stock2", Texto = "Texto texto texto", Titulo = "Churros!", SubTitulo= "Texto texto texto" });
            Onboardings.Add(new Onboarding { Id = 2, Imagem = "Munffins", Texto = "Texto texto texto", Titulo = "Lorem Ipsum", SubTitulo = "Texto texto texto" });
            Onboardings.Add(new Onboarding { Id = 3, Imagem = "Munffins2", Texto = "Texto texto texto", Titulo = "Lorem Ipsum", SubTitulo = "Texto texto texto" });
        }
        #endregion
    }
}
